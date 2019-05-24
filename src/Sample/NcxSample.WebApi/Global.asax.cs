using Ncx.Dependency;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
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
          var resolver = new AutofacWebApiDependencyResolver(container);
          var servcie = resolver.Container.Resolve<IUserServcie>();

        }
    }
}
