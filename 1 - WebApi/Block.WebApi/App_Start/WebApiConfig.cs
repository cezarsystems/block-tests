using Block.IoC;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Block.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Force always JSON formatter
            config.Formatters
                .JsonFormatter
                .SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));

            // IoC
            config.DependencyResolver = 
                new IoCResolverConfiguration(RegisterDependency.Register());
        }
    }
}
