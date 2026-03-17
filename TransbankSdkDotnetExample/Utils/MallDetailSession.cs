namespace TransbankSdkDotnetExample.Utils
{
    public class MallDetailSession
    {
        public int Amount { get; set; }
        public string CommerceCode { get; set; } = string.Empty;
        public string BuyOrder { get; set; } = string.Empty;
        public string? AuthorizationCode { get; set; }
    }
}
