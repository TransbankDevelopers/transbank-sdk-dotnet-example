using Microsoft.AspNetCore.Mvc;
using Transbank.Webpay.WebpayPlus;
using Transbank.Webpay.WebpayPlus.Responses;
using System.Text.Json;
using TransbankSdkDotnetExample.Utils;

namespace TransbankSdkDotnetExample.Controllers;

[Route("webpay-plus")]
public class WebpayPlusController : Controller
{
    private readonly Transaction _transaction;

    public WebpayPlusController()
    {
        var commerceCode = Transbank.Common.IntegrationCommerceCodes.WEBPAY_PLUS;
        var apiKey = Transbank.Common.IntegrationApiKeys.WEBPAY;
        Transaction transaction = Transaction.buildForIntegration(commerceCode, apiKey);
        _transaction = transaction;
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        string baseUrl = $"{Request.Scheme}://{Request.Host}";
        var buyOrder = $"O-{Random.Shared.Next(1, 100000)}";
        var sessionId = $"S-{Random.Shared.Next(1, 100000)}";
        var amount = Random.Shared.Next(1000, 200000);
        var returnUrl = $"{baseUrl}/webpay-plus/commit";

        CreateResponse createResponse = _transaction.Create(buyOrder, sessionId, amount, returnUrl);
        ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(createResponse!), new JsonSerializerOptions { WriteIndented = true });
        ViewBag.token = createResponse.Token;
        ViewBag.url = createResponse.Url;
        ViewBag.baseUrl = baseUrl;
        ViewBag.requestData = JsonSerializer.Deserialize<Dictionary<string, object>>(createResponse.OriginalRequest) ?? new Dictionary<string, object>();
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
            ViewBag.productName = "Webpay Plus";
            ViewBag.createUrl = Url.Action("Create", "WebpayPlus");
            // error Formulario
            if (!string.IsNullOrEmpty(TBK_TOKEN) && !string.IsNullOrEmpty(token_ws))
            {
                return View("~/Views/Shared/error/form_error.cshtml");
            }
            else if (!string.IsNullOrEmpty(TBK_TOKEN))
            {
                // Pago abortado
                var resp = _transaction.Status(TBK_TOKEN);
                ViewBag.respondData = ResponseUtils.ToMap(resp);
                return View("~/Views/Shared/error/aborted.cshtml");
            }
            else if (!string.IsNullOrEmpty(token_ws))
            {
                // Flujo normal: commit
                CommitResponse commitResponse = _transaction.Commit(token_ws);
                ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(commitResponse!), new JsonSerializerOptions { WriteIndented = true });
                ViewBag.token = token_ws;
                ViewBag.buyOrder = commitResponse.BuyOrder;
                ViewBag.authorizationCode = commitResponse.AuthorizationCode;
                ViewBag.amount = (int)(commitResponse.Amount ?? 0);
                ViewBag.url = $"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}";
                return View();
            }
            else
            {
                // Timeout o caso no manejado
                return View("~/Views/Shared/error/timeout.cshtml");
            }
        }
        catch (Exception e)
        {
            return View("~/Views/Shared/error/errorPage.cshtml", model: e.Message);
        }
    }

    [HttpGet("status")]
    public IActionResult Status(string token)
    {
        StatusResponse statusResponse = _transaction.Status(token);
        ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(statusResponse!), new JsonSerializerOptions { WriteIndented = true });
        return View();
    }

    [HttpGet("refund")]
    public IActionResult Refund(string token, decimal amount)
    {
        RefundResponse refundResponse = _transaction.Refund(token, amount);
        ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(refundResponse!), new JsonSerializerOptions { WriteIndented = true });
        ViewBag.token = token;
        return View();
    }
}
