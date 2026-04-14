using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Transbank.Common;
using Transbank.PatpassComercio;
using TransbankSdkDotnetExample.Utils;

namespace TransbankSdkDotnetExample.Controllers;

[Route("patpass-comercio")]
public class PatpassComercioController : Controller
{
    private readonly Inscription _inscription;
    private const string ErrorPagePath = "~/Views/Shared/error/errorPage.cshtml";
    private const string SessionTokenKey = "patpass_j_token";
    private const string DefaultVoucherUrl = "https://pagoautomaticocontarjetasint.transbank.cl/nuevo-ic-rest/tokenVoucherLogin";

    public PatpassComercioController()
    {
        var commerceCode = IntegrationCommerceCodes.PATPASS_COMERCIO;
        var apiKey = IntegrationApiKeys.PATPASS_COMERCIO;
        _inscription = Inscription.buildForIntegration(commerceCode, apiKey);
    }

    [HttpGet("")]
    public IActionResult Start()
    {
        try
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}";
            var requestData = new Dictionary<string, object>
            {
                ["serviceId"] = $"Service-{Random.Shared.Next(1, 10001)}",
                ["maxAmount"] = 100,
                ["returnUrl"] = $"{baseUrl}/patpass-comercio/commit",
                ["finalUrl"] = $"{baseUrl}/patpass-comercio/voucher",
                ["name"] = "Isaac",
                ["lastName"] = "Newton",
                ["secondLastName"] = "Gonzales",
                ["rut"] = "11111111-1",
                ["phone"] = "123456734",
                ["cellPhone"] = "123456723",
                ["patpassName"] = "Membresia de cable",
                ["personEmail"] = "developer@continuum.cl",
                ["commerceEmail"] = "developer@continuum.cl",
                ["address"] = "Satelite 101",
                ["city"] = "Santiago"
            };

            var response = _inscription.Start(
                requestData["returnUrl"].ToString(),
                requestData["name"].ToString(),
                requestData["lastName"].ToString(),
                requestData["secondLastName"].ToString(),
                requestData["rut"].ToString(),
                requestData["serviceId"].ToString(),
                requestData["finalUrl"].ToString(),
                Convert.ToDecimal(requestData["maxAmount"]),
                requestData["phone"].ToString(),
                requestData["cellPhone"].ToString(),
                requestData["patpassName"].ToString(),
                requestData["personEmail"].ToString(),
                requestData["commerceEmail"].ToString(),
                requestData["address"].ToString(),
                requestData["city"].ToString()
            );

            ViewBag.RequestData = requestData;
            ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(response!), new JsonSerializerOptions { WriteIndented = true });
            ViewBag.Token = response.Token;
            ViewBag.Url = response.Url;
            return View();
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    [HttpGet("commit")]
    [HttpPost("commit")]
    public IActionResult Commit()
    {
        try
        {
            var jToken = GetIncomingToken("j_token", "J_TOKEN", "token");
            var isPost = HttpMethods.IsPost(Request.Method);
            var missingTokenMessage = isPost
                ? "No se recibió el token de inscripción (J_TOKEN)."
                : "No se encontró el token de inscripción (J_TOKEN).";
            IActionResult result;

            if (string.IsNullOrWhiteSpace(jToken))
            {
                return View(ErrorPagePath, model: missingTokenMessage);
            }

            if (isPost)
            {
                HttpContext.Session.SetString(SessionTokenKey, jToken);
                result = RedirectToAction(nameof(Commit));
            }
            else
            {
                var response = _inscription.Status(jToken);
                HttpContext.Session.SetString(SessionTokenKey, jToken);

                ViewBag.Token = jToken;
                ViewBag.VoucherUrl = string.IsNullOrWhiteSpace(response.UrlVoucher) ? DefaultVoucherUrl : response.UrlVoucher;
                ViewBag.ResponsePayload = new Dictionary<string, object?>
                {
                    ["authorized"] = response.Status,
                    ["voucherUrl"] = response.UrlVoucher
                };
                ViewBag.ResponseJson = JsonSerializer.Serialize(ResponseUtils.ToMap(response!), new JsonSerializerOptions { WriteIndented = true });
                result = View();
            }

            return result;
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    [HttpGet("voucher")]
    [HttpPost("voucher")]
    public IActionResult Voucher()
    {
        try
        {
            var jToken = GetIncomingToken("j_token", "J_TOKEN", "tokenComercio", "token");
            var isPost = HttpMethods.IsPost(Request.Method);
            var missingTokenMessage = isPost
                ? "No se recibió el token de inscripción (J_TOKEN)."
                : "No se encontró el token de inscripción (J_TOKEN).";
            IActionResult result;

            if (string.IsNullOrWhiteSpace(jToken))
            {
                return View(ErrorPagePath, model: missingTokenMessage);
            }

            if (isPost)
            {
                HttpContext.Session.SetString(SessionTokenKey, jToken);
                result = RedirectToAction(nameof(Voucher));
            }
            else
            {
                ViewBag.Token = jToken;
                ViewBag.VoucherUrl = DefaultVoucherUrl;
                result = View();
            }

            return result;
        }
        catch (Exception e)
        {
            return View(ErrorPagePath, model: e.Message);
        }
    }

    private string? GetIncomingToken(params string[] keys)
    {
        foreach (var key in keys)
        {
            if (Request.HasFormContentType && Request.Form.TryGetValue(key, out var formValue) && !string.IsNullOrWhiteSpace(formValue))
            {
                return formValue.ToString();
            }

            if (Request.Query.TryGetValue(key, out var queryValue) && !string.IsNullOrWhiteSpace(queryValue))
            {
                return queryValue.ToString();
            }
        }

        return HttpContext.Session.GetString(SessionTokenKey);
    }
}
