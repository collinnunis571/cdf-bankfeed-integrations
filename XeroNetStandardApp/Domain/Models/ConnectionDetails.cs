namespace XeroNetStandardApp.Domain.Models
{
    public class ConnectionDetails
    {
        public string TenantId { get; set; }
        public string TenantName { get; set; }
        public string ConnectionStatus { get; set; }
        public bool IsConnected { get; set; }
    }
}
