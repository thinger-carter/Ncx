using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Ncx.Dependency.Register;

namespace Ncx.Dependency
{
	public class IocManager
	{
		public static IocManager Instance { get; private set; }

		public ContainerBuilder IocContainer { get; private set; }

		public ILifetimeScope LifetimeScope { get;private set; }

		private IocManager()
		{
			IocContainer=new ContainerBuilder();
		}

		static IocManager()
		{
			Instance=new IocManager();
		}

		public void SetLifeScope(ILifetimeScope lifetimeScope)
		{
			LifetimeScope = lifetimeScope;
		}



		public void RegisterAssembly(Assembly assembly,ContainerBuilder iocContainer)
		{
			DependencyRegisterContext context = new DependencyRegisterContext(assembly, iocContainer);

			DependencyRegister dependencyRegister=new DependencyRegister();
			
			dependencyRegister.RegisterAssembly(context);
		}
	}
}
