using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ncx.Core.Repisitories;

namespace Ncx.Core.Uow
{
	[AttributeUsage(AttributeTargets.Method)]
	public class UnitOfWorkAttribute:Attribute
	{
		
	}
}
