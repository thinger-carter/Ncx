using Ncx.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncx.Web.Dependency
{
	public class IocResolver<T> : IIocResolver<T>
	{
		public T Resolve<T>()
		{
			throw new NotImplementedException();
		}
	}
}
