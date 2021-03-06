﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using LiteShop.DataServices;
using LiteShop.Web.Registrars;

namespace LiteShop.Web
{
	// Примечание: Инструкции по включению классического режима IIS6 или IIS7 
	// см. по ссылке http://go.microsoft.com/?LinkId=9394801
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			System.Data.Entity.Database.SetInitializer(new LiteShopSeedData());
			GlobalConfiguration.Configure(WebApiConfig.Register);
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			MappingRegistrar.RegisterMappings();
			DependencyRegistrar.RegisterDependencies();
		}
	}
}