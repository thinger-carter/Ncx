using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Ncx.Dependency;
using Module = Autofac.Module;

namespace NcxSample.Service
{
	public class ServiceModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			IocManager.Instance.RegisterAssembly(Assembly.GetExecutingAssembly(),builder);
		}
	}
}
