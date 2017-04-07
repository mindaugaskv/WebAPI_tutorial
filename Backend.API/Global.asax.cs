using AutoMapper;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Backend.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            

            var config = GlobalConfiguration.Configuration;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Enties.LegoPart, Models.LegoPartDto>()
                    .ForMember(m => m.Id, s => s.Ignore())
                    .ForMember(m => m.Name, s => s.MapFrom(d => $"{d.Name}  {d.Shape}"))
                    ;

                cfg.CreateMap<Models.LegoPartDto, Enties.LegoPart>();
                
            });
        }
    }
}
