using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncx.Core.Entities.Audit
{
	/// <summary>
	/// 审计接口
	/// </summary>
	public interface IAudited:ICreationAudited,IModicationAudited
	{

	}
}
