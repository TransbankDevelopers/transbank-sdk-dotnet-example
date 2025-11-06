using Microsoft.AspNetCore.Mvc;
using Transbank.Webpay.WebpayPlus;
using Transbank.Webpay.Common;
using Transbank.Common;
using System.Text.Json;
using TransbankSdkDotnetExample.Utils;

namespace TransbankSdkDotnetExample.Controllers;

[Route("webpay-mall")]
public class WebpayPlusMallController : Controller
{
    private readonly MallTransaction _transaction;
    private const string ErrorPagePath = "~/Views/Shared/error/errorPage.cshtml";

    public WebpayPlusMallController()
    {
        var commerceCode = IntegrationCommerceCodes.WEBPAY_PLUS_MALL;
        var apiKey = IntegrationApiKeys.WEBPAY;
        _transaction = MallTransaction.buildForIntegration(commerceCode, apiKey);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        
        string baseUrl = $"{Request.Scheme}://{Request.Host}";
        try
        {
            var buyOrder = $"O-{Random.Shared.Next(1, 100000)}";
            var sessionId = $"S-{Random.Shared.Next(1, 100000)}";
            var returnUrl = $"{baseUrl}/webpay-mall/commit";

            var childCommerceCode1 = IntegrationCommerceCodes.WEBPAY_PLUS_MALL_CHILD1;
            var childBuyOrder1 = $"childBuyOrder-{Random.Shared.Next(1, 100000)}";
            decimal amount1 = 1000;

            var childCommerceCode2 = IntegrationCommerceCodes.WEBPAY_PLUS_MALL_CHILD2;
            var childBuyOrder2 = $"childBuyOrder-{Random.Shared.Next(1, 100000)}";
            decimal amount2 = 1000;
            
            var details = new List<TransactionDetail>();
            details.Add(new TransactionDetail(
                amount1,
                childCommerceCode1,
                childBuyOrder1
            ));
            details.Add(new TransactionDetail(
                amount2,
                childCommerceCode2,
                childBuyOrder2
            ));

            var response = _transaction.Create(buyOrder, sessionId, returnUrl, details);
            ViewBag.Response = response;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(response!), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.RequestData = JsonSerializer.Deserialize<Dictionary<string, object>>(response.OriginalRequest) ?? new Dictionary<string, object>();
        }
        catch (Exception e){
            return View(ErrorPagePath, model: e.Message);
        }
        return View();
    }

    
    [HttpGet("commit")]
    [HttpPost("commit")]
    public IActionResult Commit(string? TBK_TOKEN, string? token_ws)
    {
        try
        {
            ViewBag.requestData = Request.HasFormContentType 
                ? Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString())
                : Request.Query.ToDictionary(x => x.Key, x => x.Value.ToString());
            ViewBag.ProductName = "Webpay Plus";
            if (!string.IsNullOrEmpty(TBK_TOKEN) && !string.IsNullOrEmpty(token_ws))
            {
                return View("~/Views/Shared/error/form_error.cshtml");
            }
            else if (!string.IsNullOrEmpty(TBK_TOKEN))
            {
                // Pago abortado
                var resp = _transaction.Status(TBK_TOKEN);
                ViewBag.RespondData = ResponseUtils.ToMap(resp);
                return View("~/Views/Shared/error/aborted.cshtml");
            }
            else if (!string.IsNullOrEmpty(token_ws))
            {
                // Flujo normal: commit
                var response = _transaction.Commit(token_ws);
                ViewBag.Response = response;
                ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(response!), new JsonSerializerOptions { WriteIndented = true });
                ViewBag.Token = token_ws;
                ViewBag.Url = $"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}";
                return View();
            }
            else
            {
                return View("~/Views/Shared/error/timeout.cshtml");
            }
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }


    [HttpGet("status")]
    public IActionResult Status(string token)
    {
        try
        {
            var response = _transaction.Status(token);
            ViewBag.Response = response;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(response!), new JsonSerializerOptions { WriteIndented = true });
            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    [HttpGet("refund")]
    public IActionResult Refund(string token, string buyOrder, string childCommerceCode, decimal amount)
    {
        try
        {
            var response = _transaction.Refund(token, buyOrder, childCommerceCode, amount);
            ViewBag.Response = response;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(response!), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.Token = token;
            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }
    


}
