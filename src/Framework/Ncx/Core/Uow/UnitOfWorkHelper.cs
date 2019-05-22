using Ncx.Core.Repisitories;
using System;
using System.Reflection;

namespace Ncx.Core.Uow
{
	/// <summary>
	/// 工作单元帮助类
	/// </summary>
	internal static class UnitOfWorkHelper
	{
		public static bool ShouldPerformUnitOfWork(MethodInfo methodInfo)
		{
			return HasUnitOfWorkAttribute(methodInfo) || IsRepositoryClass(methodInfo.DeclaringType);
		}

		/// <summary>
		/// 判断给定的Class是否为仓储接口的实现类
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsRepositoryClass(Type type)
		{
			return typeof(IRepository).IsAssignableFrom(type);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="methodInfo"></param>
		/// <returns></returns>
		public static bool HasUnitOfWorkAttribute(MethodInfo methodInfo)
		{
			return methodInfo.IsDefined(typeof(UnitOfWorkAttribute), true);
		}
	}
}
