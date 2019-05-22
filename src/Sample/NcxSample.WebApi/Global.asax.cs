using Ncx.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Autofac;
using NcxSample.Service;
using NcxSample.Service.User;

namespace NcxSample.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            IocManager.Instance.IocContainer.RegisterModule<ServiceModule>();
          var container=   IocManager.Instance.IocContainer.Build();
          using (var scope= container.BeginLifetimeScope())
          {
	          var service = scope.Resolve<IUserServcie>();
          }
        }
    }
}
