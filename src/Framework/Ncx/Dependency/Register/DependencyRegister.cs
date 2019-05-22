using Autofac;
using Castle.DynamicProxy;

namespace Ncx.Dependency.Register
{
	/// <summary>
	/// 注册程序集依赖
	/// </summary>
	public class DependencyRegister : IDependencyRegister
	{
		/// <summary>
		/// 注册程序集依赖
		/// </summary>
		/// <param name="context">依赖注册上下文</param>
		public void RegisterAssembly(DependencyRegisterContext context)
		{

			//注册生命周期内实例唯一
			context.IocContainer.RegisterAssemblyTypes(context.Assembly)
				.PublicOnly()
				.Where(t => typeof(ILifetimeScopeDependency).IsAssignableFrom(t))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();

			//注册单例
			context.IocContainer.RegisterAssemblyTypes(context.Assembly)
				.PublicOnly()
				.Where(t => typeof(ISingleDependency).IsAssignableFrom(t))
				.AsImplementedInterfaces()
				.SingleInstance();

			//注册单例
			context.IocContainer.RegisterAssemblyTypes(context.Assembly)
				.PublicOnly().Where(t => typeof(IInterceptor).IsAssignableFrom(t))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
		}
	}
}
