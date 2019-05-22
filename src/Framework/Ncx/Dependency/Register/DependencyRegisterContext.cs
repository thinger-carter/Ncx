using Autofac;
using System.Reflection;

namespace Ncx.Dependency.Register
{
	/// <summary>
	/// 依赖注册上下文
	/// </summary>
	public class DependencyRegisterContext
	{
		/// <summary>
		/// 需要注册的上下文
		/// </summary>
		public Assembly Assembly { get;private set; }

		/// <summary>
		/// Ioc容器
		/// </summary>
		public ContainerBuilder IocContainer { get; set; }

		public DependencyRegisterContext(Assembly assembly, ContainerBuilder iocContainer)
		{
			Assembly = assembly;
			IocContainer = iocContainer;
		}
	}
}
