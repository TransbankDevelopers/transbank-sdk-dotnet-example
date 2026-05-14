using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Transbank.Exceptions;
using Transbank.Webpay.Oneclick;
using Transbank.Webpay.Common;
using Transbank.Webpay.Oneclick.Responses;
using TransbankSdkDotnetExample.Utils;

namespace TransbankSdkDotnetExample.Controllers;

[Route("promotions-oneclick-mall")]
public class PromotionsOneclickMallController : Controller
{
    private readonly ILogger<PromotionsOneclickMallController> _logger;
    private readonly MallInscription _inscription;
    private readonly MallTransaction _transaction;
    private readonly MallInfoBin _binInfo;
    private readonly string _childCommerceCode1;
    private readonly string _childCommerceCode2;
    private const string ErrorPagePath = "~/Views/Shared/error/errorPage.cshtml";
    private const int InscriptionSuccessfulCode = 0;

    public PromotionsOneclickMallController(ILogger<PromotionsOneclickMallController> logger, IConfiguration configuration)
    {
        _logger = logger;

        var commerceCode = configuration["Transbank:OneclickMallPromotions:CommerceCode"]
            ?? throw new InvalidOperationException("Missing config Transbank:OneclickMallPromotions:CommerceCode");
        var apiKey = configuration["Transbank:OneclickMallPromotions:ApiKey"]
            ?? throw new InvalidOperationException("Missing config Transbank:OneclickMallPromotions:ApiKey");

        _childCommerceCode1 = configuration["Transbank:OneclickMallPromotions:ChildCommerceCode1"]
            ?? throw new InvalidOperationException("Missing config Transbank:OneclickMallPromotions:ChildCommerceCode1");
        _childCommerceCode2 = configuration["Transbank:OneclickMallPromotions:ChildCommerceCode2"]
            ?? throw new InvalidOperationException("Missing config Transbank:OneclickMallPromotions:ChildCommerceCode2");

        _inscription = MallInscription.buildForIntegration(commerceCode, apiKey);
        _transaction = MallTransaction.buildForIntegration(commerceCode, apiKey);
        _binInfo = MallInfoBin.buildForIntegration(commerceCode, apiKey);
    }

    [HttpGet("start")]
    public IActionResult Start()
    {
        try
        {
            var username = $"User-{Random.Shared.Next(1000)}";
            var email = $"user.{Random.Shared.Next(1000)}@example.com";
            var responseUrl = Url.Action("Finish", "PromotionsOneclickMall", null, Request.Scheme);

            HttpContext.Session.SetString("username", username);
            HttpContext.Session.SetString("email", email);

            var resp = _inscription.Start(username, email, responseUrl);
            ViewBag.Url = resp.Url;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.RequestData = JsonSerializer.Deserialize<Dictionary<string, object>>(resp.OriginalRequest) ?? new Dictionary<string, object>();
            ViewBag.Token = resp.Token;

            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Promotions Start: {Message}", e.Message);
            return View(ErrorPagePath, model: GetDisplayableErrorMessage(e));
        }
    }

    [HttpGet("finish")]
    [HttpPost("finish")]
    public IActionResult Finish(
        [ModelBinder(Name = "TBK_TOKEN")] string? token,
        [ModelBinder(Name = "TBK_ORDEN_COMPRA")] string? tbkOrdenCompra,
        [ModelBinder(Name = "TBK_ID_SESION")] string? tbkIdSesion,
        [ModelBinder(Name = "token_ws")] string? token_ws)
    {
        var hasTBKToken = !string.IsNullOrEmpty(token);
        var hasTbkOrdenCompra = !string.IsNullOrEmpty(tbkOrdenCompra);
        var hasTbkIdSesion = !string.IsNullOrEmpty(tbkIdSesion);
        var hasTokenWs = !string.IsNullOrEmpty(token_ws);

        var requestData = new Dictionary<string, string>();
        if (hasTBKToken) requestData.Add("TBK_TOKEN", token!);
        if (hasTbkOrdenCompra) requestData.Add("TBK_ORDEN_COMPRA", tbkOrdenCompra!);
        if (hasTbkIdSesion) requestData.Add("TBK_ID_SESION", tbkIdSesion!);
        if (hasTokenWs) requestData.Add("token_ws", token_ws!);

        ViewBag.productName = "Webpay Oneclick Mall Promociones";
        ViewBag.requestData = requestData;

        if (Request.Method == "POST" && hasTBKToken && hasTbkOrdenCompra && hasTokenWs)
        {
            return View("~/Views/Shared/error/form_error.cshtml");
        }

        if (hasTbkOrdenCompra)
        {
            return View("~/Views/Shared/error/aborted.cshtml");
        }

        try
        {
            var resp = _inscription.Finish(token);

            if (resp.ResponseCode != InscriptionSuccessfulCode)
            {
                ViewBag.token = token;
                ViewBag.resp = resp;
                return View("~/Views/Shared/error/rejected.cshtml");
            }

            ViewBag.RequestData = new Dictionary<string, string>
            {
                { "username", HttpContext.Session.GetString("username") ?? string.Empty },
                { "tbk_user", resp.TbkUser ?? string.Empty }
            };
            ViewBag.Username = HttpContext.Session.GetString("username") ?? string.Empty;
            ViewBag.TbkUser = resp.TbkUser ?? string.Empty;
            ViewBag.Token = token;
            ViewBag.ResponseUrl = Url.Action("Finish", "PromotionsOneclickMall", null, Request.Scheme);
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.ChildCommerceCode1 = _childCommerceCode1;
            ViewBag.ChildCommerceCode2 = _childCommerceCode2;

            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Promotions Finish: {Message}", e.Message);
            return View(ErrorPagePath, model: GetDisplayableErrorMessage(e));
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
            _logger.LogError(e, "Error al ejecutar Promotions Delete: {Message}", e.Message);
            return View(ErrorPagePath, model: GetDisplayableErrorMessage(e));
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

            var buyOrder = $"buyOrder_{Random.Shared.Next(1000)}";
            var buyOrderMallOne = $"childBuyOrder1_{Random.Shared.Next(1000)}";
            var buyOrderMallTwo = $"childBuyOrder2_{Random.Shared.Next(1000)}";

            List<PaymentRequest> details =
            [
                new PaymentRequest(childCommerceCode1, buyOrderMallOne, childCommerceAmount1, childCommerceInstallments1),
                new PaymentRequest(childCommerceCode2, buyOrderMallTwo, childCommerceAmount2, childCommerceInstallments2)
            ];

            var resp = _transaction.Authorize(username, tbkUser, buyOrder, details);
            ViewBag.ResponseData = resp;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });

            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Promotions Authorize: {Message}", e.Message);
            return View(ErrorPagePath, model: GetDisplayableErrorMessage(e));
        }
    }

    [HttpGet("status")]
    public IActionResult Status([FromQuery(Name = "buy_order")] string buyOrder)
    {
        try
        {
            var resp = _transaction.Status(buyOrder);
            ViewBag.BuyOrder = buyOrder;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Promotions Status: {Message}", e.Message);
            return View(ErrorPagePath, model: GetDisplayableErrorMessage(e));
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
            _logger.LogError(e, "Error al ejecutar Promotions Refund: {Message}", e.Message);
            return View(ErrorPagePath, model: GetDisplayableErrorMessage(e));
        }
    }

    [HttpGet("info-bin")]
    public IActionResult InfoBin([FromQuery(Name = "tbk_user")] string tbkUser)
    {
        try
        {
            var resp = _binInfo.queryBin(tbkUser);
            ViewBag.TbkUser = tbkUser;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(resp!), new JsonSerializerOptions { WriteIndented = true });
            return View();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error al ejecutar Promotions InfoBin: {Message}", e.Message);
            return View(ErrorPagePath, model: GetDisplayableErrorMessage(e));
        }
    }

    private static string GetDisplayableErrorMessage(Exception exception)
    {
        for (var current = exception; current is not null; current = current.InnerException)
        {
            if (current is TransbankException)
            {
                return current.Message;
            }
        }

        return "Ocurrió un error inesperado al procesar la operación.";
    }
}
