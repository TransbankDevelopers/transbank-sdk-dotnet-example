using Microsoft.AspNetCore.Mvc;
using Transbank.Webpay.WebpayPlus;
using Transbank.Webpay.WebpayPlus.Responses;
using System.Text.Json;
using TransbankSdkDotnetExample.Utils;

namespace TransbankSdkDotnetExample.Controllers;

[Route("webpay-plus-deferred")]
public class WebpayPlusDeferredController : Controller
{
    private readonly Transaction _transaction;

    public WebpayPlusDeferredController()
    {
        var commerceCode = Transbank.Common.IntegrationCommerceCodes.WEBPAY_PLUS_DEFERRED;
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
        var returnUrl = $"{baseUrl}/webpay-plus-deferred/commit";

        CreateResponse createResponse = _transaction.Create(buyOrder, sessionId, amount, returnUrl);
        ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(createResponse!), new JsonSerializerOptions { WriteIndented = true });
        ViewBag.token = createResponse.Token;
        ViewBag.url = createResponse.Url;
        ViewBag.baseUrl = baseUrl;
        ViewBag.requestData = JsonSerializer.Deserialize<Dictionary<string, object>>(createResponse.OriginalRequest) ?? new Dictionary<string, object>();
        return View();
    }

    [HttpGet("commit")]
    public IActionResult Commit(string token_ws)
    {
        CommitResponse commitResponse = _transaction.Commit(token_ws);
        ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(commitResponse!), new JsonSerializerOptions { WriteIndented = true });
        ViewBag.token = token_ws;
        ViewBag.buyOrder = commitResponse.BuyOrder;
        ViewBag.authorizationCode = commitResponse.AuthorizationCode;
        ViewBag.amount = (int)commitResponse.Amount;
        ViewBag.url = $"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}";
        return View();
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

    [HttpGet("capture")]
    public IActionResult Capture(string token, string buyOrder, string authorizationCode, decimal captureAmount)
    {
        CaptureResponse commitResponse = _transaction.Capture(token, buyOrder, authorizationCode, captureAmount);
        ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(commitResponse!), new JsonSerializerOptions { WriteIndented = true });
        ViewBag.token = token;
        ViewBag.amount = (int)commitResponse.CapturedAmount;
        return View();
    }


}