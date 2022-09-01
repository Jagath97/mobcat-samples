using Microsoft.AspNetCore.Authentication;

namespace PushDemoApi.Authentication
{
    public class ApiKeyAuthOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScheme = "3a22964e-f531-4c8c-a705-f7a4317ef1ac";
        public string Scheme => DefaultScheme;
        public string ApiKey { get; set; }
    }
}