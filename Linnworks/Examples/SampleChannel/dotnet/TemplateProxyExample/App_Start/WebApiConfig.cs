using System.Web.Http;
using System.Web.Routing;

namespace TemplateProxyExample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
            );
        }
    }
}
