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
                cfg.CreateMap<Entities.LegoPart, Models.LegoPartDto>()
                    .ForMember(m => m.Name, s => s.MapFrom(d => $"{d.Name}  {d.Shape}"));
                cfg.CreateMap<Models.LegoPartDto, Entities.LegoPart>();
                cfg.CreateMap<Models.LegoPartCreateDto, Entities.LegoPart>();
                cfg.CreateMap<Models.LegoPartUpdateDto, Entities.LegoPart>();
                cfg.CreateMap<Entities.LegoToy, Models.LegoToyDto>();
                cfg.CreateMap<Models.LegoToyDto, Entities.LegoToy>();
                cfg.CreateMap<Models.LegoToyUpdateDto, Entities.LegoToy>();
                cfg.CreateMap<Models.LegoToyCreateDto, Entities.LegoToy>();
            });
        }
    }
}
