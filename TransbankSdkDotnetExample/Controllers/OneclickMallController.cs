using Microsoft.AspNetCore.Mvc;
using Transbank.Webpay.Oneclick;
using Transbank.Webpay.Oneclick.Responses;
using Transbank.Webpay.Common;
using Transbank.Common;
using System.Text.Json;
using TransbankSdkDotnetExample.Utils;

namespace TransbankSdkDotnetExample.Controllers;

[Route("oneclick-mall")]
public class OneclickMallController : Controller
{
    private readonly ILogger<OneclickMallController> _logger;
    private readonly MallInscription _inscription;
    private readonly MallTransaction _transaction;
    private const string ErrorPagePath = "~/Views/Shared/error/errorPage.cshtml";
    private const int InscriptionSuccessfulCode = 0;

    public OneclickMallController(ILogger<OneclickMallController> logger)
    {
        _logger = logger;
        var commerceCode = IntegrationCommerceCodes.ONECLICK_MALL;
        var apiKey = IntegrationApiKeys.WEBPAY;
        _inscription = MallInscription.buildForIntegration(commerceCode, apiKey);
        _transaction = MallTransaction.buildForIntegration(commerceCode, apiKey);
    }

    [HttpGet("start")]
    public IActionResult Start()
    {
        try
        {
            var username = $"User-{new Random().Next(1000)}";
            var email = $"user.{new Random().Next(1000)}@example.com";
            var responseUrl = Url.Action("Finish", "OneclickMall", null, Request.Scheme);
            _logger.LogInformation("URL generada: {Url}", responseUrl);

            HttpContext.Session.Set("username", System.Text.Encoding.UTF8.GetBytes(username));
            HttpContext.Session.Set("email", System.Text.Encoding.UTF8.GetBytes(email));

            MallStartResponse resp = _inscription.Start(username, email, responseUrl);
            ViewBag.Url = resp.Url;
            _logger.LogInformation("URL regresada: {Url}", resp.Url);

            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.RequestData = JsonSerializer.Deserialize<Dictionary<string, object>>(resp.OriginalRequest) ?? new Dictionary<string, object>();
            ViewBag.Token = resp.Token;
            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Start: {Message}", e.Message);
            return View(ErrorPagePath, e.Message);
        }
    }

    [HttpGet("finish")]
    [HttpPost("finish")]
    public IActionResult Finish(
        [ModelBinder(Name = "TBK_TOKEN")] string? token,
        [ModelBinder(Name = "TBK_ORDEN_COMPRA")] string? tbkOrdenCompra,
        [ModelBinder(Name = "TBK_ID_SESION")] string? tbkIdSesion)
    {
        var hasToken = !string.IsNullOrEmpty(token);
        var hasTbkOrdenCompra = !string.IsNullOrEmpty(tbkOrdenCompra);
        var hasTbkIdSesion = !string.IsNullOrEmpty(tbkIdSesion);

        var requestData = new Dictionary<string, string>();
        if (hasToken) requestData.Add("TBK_TOKEN", token!);
        if (hasTbkOrdenCompra) requestData.Add("TBK_ORDEN_COMPRA", tbkOrdenCompra!);
        if (hasTbkIdSesion) requestData.Add("TBK_ID_SESION", tbkIdSesion!);

        ViewBag.productName = "Webpay Oneclick Mall";
        ViewBag.requestData = requestData;

        if (Request.Method == "POST" && hasToken && hasTbkOrdenCompra)
        {
            return View("~/Views/Shared/error/form_error.cshtml");
        }
        
        if (hasTbkOrdenCompra)
        {
            return View("~/Views/Shared/error/recover.cshtml");
        }

        try
        {
            var resp = _inscription.Finish(token);
            HttpContext.Session.Set("tbk_user", System.Text.Encoding.UTF8.GetBytes(resp.ToString()));

            if (resp.ResponseCode == -96)
            {
                ViewBag.token = token;
                ViewBag.resp = resp;
                return View("~/Views/Shared/error/timeout.cshtml");
            }

            if (resp.ResponseCode != InscriptionSuccessfulCode)
            {
                ViewBag.token = token;
                ViewBag.resp = resp;
                return View("~/Views/Shared/error/rejected.cshtml");
            }

            ViewBag.RequestData = new Dictionary<string, string>
                {
                    { "username", HttpContext.Session.GetString("username") ?? "" },
                    { "tbk_user", resp.TbkUser  ?? "" }
                };
            ViewBag.Username = HttpContext.Session.GetString("username") ?? "";
            ViewBag.TbkUser = resp.TbkUser ?? "";
            ViewBag.Token = token;
            ViewBag.ResponseUrl = Url.Action("Finish", "OneclickMall", null, Request.Scheme);
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.ChildCommerceCode1 = IntegrationCommerceCodes.ONECLICK_MALL_CHILD1;
            ViewBag.ChildCommerceCode2 = IntegrationCommerceCodes.ONECLICK_MALL_CHILD2;
            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Finish: {Message}", e.Message);
            return View(ErrorPagePath, e.Message);
        }
    }

    [HttpGet("delete")]
    public IActionResult Delete([FromQuery] string? username, [FromQuery(Name = "tbk_user")] string? tbkUser)
    {
        try
        {
            _inscription.Delete(tbkUser, username);
            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Delete: {Message}", e.Message);
            return View(ErrorPagePath, e.Message);
        }
    }

    [HttpGet("authorize")]
    public IActionResult Authorize()
    {
        try
        {
            var query = Request.Query.ToDictionary(x => x.Key, x => x.Value.ToString());

            string? username = query.GetValueOrDefault("username");
            string? tbkUser = query.GetValueOrDefault("tbk_user");
            string? childCommerceCode1 = query.GetValueOrDefault("child_commerce_code1");
            string? childCommerceCode2 = query.GetValueOrDefault("child_commerce_code2");

            decimal.TryParse(query.GetValueOrDefault("child_commerce_amount1"), out var childCommerceAmount1);
            decimal.TryParse(query.GetValueOrDefault("child_commerce_amount2"), out var childCommerceAmount2);
            int.TryParse(query.GetValueOrDefault("child_commerce_installments1"), out var childCommerceInstallments1);
            int.TryParse(query.GetValueOrDefault("child_commerce_installments2"), out var childCommerceInstallments2);

            var buyOrder = $"buyOrder_{new Random().Next(1000)}";
            var buyOrderMallOne = $"childBuyOrder1_{new Random().Next(1000)}";
            var buyOrderMallTwo = $"childBuyOrder2_{new Random().Next(1000)}";

            List<PaymentRequest> details = new List<PaymentRequest>();
            details.Add(new PaymentRequest(
              childCommerceCode1, buyOrderMallOne, childCommerceAmount1, childCommerceInstallments1
            ));
            details.Add(new PaymentRequest(
              childCommerceCode2, buyOrderMallTwo, childCommerceAmount2, childCommerceInstallments2
            ));

            var resp = _transaction.Authorize(username, tbkUser, buyOrder, details);
            ViewBag.ResponseData = resp;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Authorize: {Message}", e.Message);
            return View(ErrorPagePath, e.Message);
        }
    }

    [HttpGet("status")]
    public IActionResult Status([FromQuery] string buy_order)
    {
        try
        {
            var resp = _transaction.Status(buy_order);

            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Status: {Message}", e.Message);
            return View(ErrorPagePath, e.Message);
        }
    }

    [HttpGet("refund")]
    public IActionResult Refund(
       
        [FromQuery(Name = "buy_order")] string buyOrder,
        [FromQuery(Name = "child_commerce_code")] string childCommerceCode,
        [FromQuery(Name = "child_buy_order")] string childBuyOrder,
        [FromQuery] decimal amount)

    {
        try
        {
            
          

            var resp = _transaction.Refund(buyOrder, childCommerceCode, childBuyOrder, amount);
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            
            ViewBag.BuyOrder = buyOrder;
           
            
            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Refund: {Message}", e.Message);
            return View(ErrorPagePath, e.Message);
        }
    }

    
}
