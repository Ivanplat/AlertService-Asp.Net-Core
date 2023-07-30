namespace AlertService.Services
{
    public class JsonAlert : IAlert
    {
        private IConfiguration _config;
        public JsonAlert(IConfiguration config)
        {
           _config = config;
        }
        public string GetMessage()
        {
            return _config.GetSection("Alert")["Msg"];
        }
    }
}
