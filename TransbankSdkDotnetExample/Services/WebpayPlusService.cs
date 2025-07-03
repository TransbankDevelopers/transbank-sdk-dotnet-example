namespace TransbankSdkDotnetExample.Services;

using System;
using Microsoft.Extensions.Logging;
using Transbank.Webpay.WebpayPlus;
using Transbank.Webpay.WebpayPlus.Responses;

public class WebpayPlusService
{
    private readonly ILogger<WebpayPlusService> _logger;
    private readonly Transaction _tx;

    public WebpayPlusService(ILogger<WebpayPlusService> logger)
    {
        _logger = logger;
        var commerceCode = Transbank.Common.IntegrationCommerceCodes.WEBPAY_PLUS;
        var apiKey = Transbank.Common.IntegrationApiKeys.WEBPAY;
        _tx = Transaction.buildForIntegration(commerceCode, apiKey);
    }

    public CreateResponse Create(String baseUrl)
    {
        try
        {
            var buyOrder = $"O-{Random.Shared.Next(1, 10000)}";
            var sessionId = $"S-{Random.Shared.Next(1, 10000)}";
            var amount = Random.Shared.Next(1000, 2000);
            var returnUrl = $"{baseUrl}/webpay-plus/commit";

            return _tx.Create(buyOrder, sessionId, amount, returnUrl);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al crear transacción");
            throw;
        }
    }

    public CommitResponse Commit(string token)
    {
        try
        {
            return _tx.Commit(token);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al hacer commit con token {Token}", token);
            throw;
        }
    }

    public RefundResponse Refund(string token, decimal amount)
    {
        try
        {
            return _tx.Refund(token, amount);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al hacer refund con token {token}", token);
            throw;
        }
    }

    public StatusResponse Status(string token)
    {
        try
        {
            return _tx.Status(token);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al consultar status con token {token}", token);
            throw;
        }
    }
}
