using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncx.Dependency.Register
{
	/// <summary>
	/// 依赖注册接口
	/// </summary>
	public interface IDependencyRegister
	{
		/// <summary>
		/// 注册程序集依赖
		/// </summary>
		/// <param name="context">依赖注册上下文</param>
		void RegisterAssembly(DependencyRegisterContext context);
	}
}
