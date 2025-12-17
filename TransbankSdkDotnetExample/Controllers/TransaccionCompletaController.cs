using Microsoft.AspNetCore.Mvc;
using Transbank.Common;
using Transbank.Webpay.Common;
using Transbank.Webpay.TransaccionCompleta;
using Transbank.Webpay.TransaccionCompleta.Responses;
using System.Text.Json;
using TransbankSdkDotnetExample.Utils;

namespace TransbankSdkDotnetExample.Controllers;

[Route("transaccion-completa")]
public class TransaccionCompletaController : Controller
{
    private readonly FullTransaction _transaction;
    private const string ErrorPagePath = "~/Views/Shared/error/errorPage.cshtml";

    public TransaccionCompletaController()
    {
        _transaction = new FullTransaction(new Options(
            IntegrationCommerceCodes.TRANSACCION_COMPLETA,
            IntegrationApiKeys.WEBPAY,
            WebpayIntegrationType.Test
        ));
    }

    [HttpGet("")]
    [HttpGet("index")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(string number, string cvc, string expiry, int installments_number)
    {
        try
        {
            var cardNumberClean = number.Replace(" ", "");
            var parts = expiry.Split('/');
            var cardExpiryFormatted = $"{parts[1]}/{parts[0]}"; 

            var buyOrder = $"O-{Random.Shared.Next(1, 100000)}";
            var sessionId = $"S-{Random.Shared.Next(1, 100000)}";
            var amount = Random.Shared.Next(1000, 2000);

            CreateResponse createResponse = _transaction.Create(
                buyOrder,
                sessionId,
                amount,
                Convert.ToInt16(cvc),
                cardNumberClean,
                cardExpiryFormatted
            );

            HttpContext.Session.SetString("tc_amount", amount.ToString());

            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(createResponse), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.BuyOrder = buyOrder;
            ViewBag.SessionId = sessionId;
            ViewBag.Amount = amount;
            ViewBag.CardNumber = cardNumberClean;
            ViewBag.Expiry = cardExpiryFormatted;
            ViewBag.Cvc = cvc;
            ViewBag.InstallmentsNumber = 3;
            ViewBag.Token = createResponse.Token;

            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    [HttpPost("installments")]
    public IActionResult Installments(string token, int installments_number)
    {
        try
        {
            InstallmentsResponse response = _transaction.Installments(token, installments_number);
            
            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(response), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.Token = token;
            
            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    [HttpPost("commit")]
    public IActionResult Commit(string token, int idQueryInstallments, int deferredPeriodIndex, bool gracePeriod)
    {
        try
        {
            CommitResponse response = _transaction.Commit(token, idQueryInstallments, (sbyte)deferredPeriodIndex, gracePeriod);

            var amount = HttpContext.Session.GetString("tc_amount");
            
            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(response), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.Amount = amount;

            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    [HttpGet("refund")]
    public IActionResult Refund(string token, int amount)
    {
        try
        {
            RefundResponse response = _transaction.Refund(token, amount);
            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(response), new JsonSerializerOptions { WriteIndented = true });
            return View();
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
            StatusResponse response = _transaction.Status(token);
            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(response), new JsonSerializerOptions { WriteIndented = true });
            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }
}