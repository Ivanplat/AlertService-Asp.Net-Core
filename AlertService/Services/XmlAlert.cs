namespace AlertService.Services
{
    public class XmlAlert : IAlert
    {
        IConfiguration _config;
        public XmlAlert(IWebHostEnvironment env)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(env.ContentRootPath);
            configurationBuilder.AddXmlFile("settings.xml");
            _config = configurationBuilder.Build();
        }
        public string GetMessage()
        {
            return _config.GetSection("Alert")["Msg"];
        }
    }
}
