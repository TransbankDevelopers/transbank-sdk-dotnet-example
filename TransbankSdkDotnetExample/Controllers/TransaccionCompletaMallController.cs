using Microsoft.AspNetCore.Mvc;
using Transbank.Common;
using Transbank.Webpay.Common;
using Transbank.Webpay.TransaccionCompletaMall;
using Transbank.Webpay.TransaccionCompletaMall.Common;
using Transbank.Webpay.TransaccionCompletaMall.Responses;
using System.Text.Json;
using TransbankSdkDotnetExample.Utils;

namespace TransbankSdkDotnetExample.Controllers;

[Route("transaccion-completa-mall")]
public class TransaccionCompletaMallController : Controller
{
    private readonly MallFullTransaction _transaction;
    private const string ErrorPagePath = "~/Views/Shared/error/errorPage.cshtml";
    private const string SessionDetailsKey = "tcm_details";

    public TransaccionCompletaMallController()
    {
        _transaction = new MallFullTransaction(new Options(
            IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL,
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
    public IActionResult Create(string number, string cvc, string expiry)
    {
        try
        {
            var cardNumberClean = number.Replace(" ", "");
            var parts = expiry.Split('/');
            var cardExpiryFormatted = $"{parts[1]}/{parts[0]}";

            var buyOrder = $"O-{Random.Shared.Next(1, 100000)}";
            var sessionId = $"S-{Random.Shared.Next(1, 100000)}";

            var detailSessions = BuildMallDetailSessions(
                IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL_CHILD1,
                IntegrationCommerceCodes.TRANSACCION_COMPLETA_MALL_CHILD2
            );

            var details = detailSessions
                .Select(d => new CreateDetails(d.Amount, d.CommerceCode, d.BuyOrder))
                .ToList();

            MallCreateResponse createResponse = _transaction.Create(
                buyOrder,
                sessionId,
                cardNumberClean,
                cardExpiryFormatted,
                details,
                Convert.ToInt16(cvc)
            );

            SaveDetailsToSession(SessionDetailsKey, detailSessions);

            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(createResponse), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.BuyOrder = buyOrder;
            ViewBag.SessionId = sessionId;
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
    public IActionResult Installments(string token, [FromForm(Name = "installments_number")] int installmentsNumber)
    {
        try
        {
            var detailSessions = GetDetailsFromSession(SessionDetailsKey);
            if (!detailSessions.Any())
            {
                return View(ErrorPagePath, model: "Debes crear la transacción antes de consultar cuotas.");
            }
            var details = detailSessions
                .Select(d => new MallInstallmentsDetails(d.CommerceCode, d.BuyOrder, installmentsNumber))
                .ToList();

            MallInstallmentsDetailsResponse response = _transaction.Installments(token, details);

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
    public IActionResult Commit(string token, int? idQueryInstallments, int? deferredPeriodIndex, bool gracePeriod)
    {
        try
        {
            var detailSessions = GetDetailsFromSession(SessionDetailsKey);
            if (!detailSessions.Any())
            {
                return View(ErrorPagePath, model: "Debes crear la transacción antes de confirmar.");
            }
            var details = detailSessions
                .Select(d => new MallCommitDetails(d.CommerceCode, d.BuyOrder, idQueryInstallments, deferredPeriodIndex, gracePeriod))
                .ToList();

            MallCommitResponse response = _transaction.Commit(token, details);

            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(response), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.Token = token;
            ViewBag.Details = detailSessions ?? new List<MallDetailSession>();

            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    [HttpGet("refund")]
    public IActionResult Refund(
        string token,
        [FromQuery(Name = "buy_order")] string buyOrder,
        [FromQuery(Name = "commerce_code")] string commerceCode,
        int amount)
    {
        try
        {
            MallRefundResponse response = _transaction.Refund(token, buyOrder, commerceCode, amount);
            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(response), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.Token = token;
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
            MallStatusResponse response = _transaction.Status(token);
            ViewBag.response = JsonSerializer.Serialize(ResponseUtils.ToMap(response), new JsonSerializerOptions { WriteIndented = true });
            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    private static List<MallDetailSession> BuildMallDetailSessions(string commerceCode1, string commerceCode2)
    {
        return new List<MallDetailSession>
        {
            new()
            {
                Amount = Random.Shared.Next(1001, 2000),
                CommerceCode = commerceCode1,
                BuyOrder = $"O-{Random.Shared.Next(1, 100000)}"
            },
            new()
            {
                Amount = Random.Shared.Next(1001, 2000),
                CommerceCode = commerceCode2,
                BuyOrder = $"O-{Random.Shared.Next(1, 100000)}"
            }
        };
    }

    private void SaveDetailsToSession(string key, List<MallDetailSession> details)
    {
        HttpContext.Session.SetString(key, JsonSerializer.Serialize(details));
    }

    private List<MallDetailSession> GetDetailsFromSession(string key)
    {
        var json = HttpContext.Session.GetString(key);
        if (string.IsNullOrWhiteSpace(json))
        {
            return new List<MallDetailSession>();
        }

        return JsonSerializer.Deserialize<List<MallDetailSession>>(json) ?? new List<MallDetailSession>();
    }
}
