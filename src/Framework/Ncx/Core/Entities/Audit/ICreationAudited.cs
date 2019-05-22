using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncx.Core.Entities.Audit
{
	/// <summary>
	/// 创建审计
	/// </summary>
	public interface ICreationAudited
	{
		/// <summary>
		/// 创建时间
		/// </summary>
		DateTime CreationTime { get; set; }

		/// <summary>
		/// 创建用户Id
		/// </summary>
		int?  CreatorUserId { get; set; }
	}
}
