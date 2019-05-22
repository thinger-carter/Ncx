using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncx.Core.Entities
{
	/// <summary>
	/// Int类型主键接口
	/// </summary>
	public interface IEntity:IEntityOfPrimaryKey<int>
	{
	}
}
