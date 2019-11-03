﻿using Ninject;
using Ninject.Modules;
using QuestRoomCatalog.BusinessLayer.Helpers;
using QuestRoomCatalog.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace QuestRoomCatalog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            NinjectModule ninjectBO = new NinjectUnitOfWork("Model1");
            NinjectModule ninjectWeb = new NinjectHelper();

            var kernel = new StandardKernel(ninjectWeb, ninjectBO);
            DependencyResolver.SetResolver(new Ninject.Web.Mvc.NinjectDependencyResolver(kernel));
        }
    }
}
