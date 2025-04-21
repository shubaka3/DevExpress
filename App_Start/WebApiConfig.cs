using System.Net.Http.Headers;
using System.Web.Http;

namespace DXWebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Ép trả JSON kể cả khi browser yêu cầu HTML
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(
                new MediaTypeHeaderValue("text/html")
            );

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "WebsiteContentApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { controller = "WebsiteContent", action = "GetWebsiteContent" }
            );

        }
    }
}
