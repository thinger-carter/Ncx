using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncx.Core.Entities.Audit
{
	/// <summary>
	/// 修改审计接口
	/// </summary>
	public interface IModicationAudited
	{
		/// <summary>
		/// 最后修改时间
		/// </summary>
		DateTime? LastModificationTime { get; set; }

		/// <summary>
		/// 最后修改用户Id
		/// </summary>
		int? LastModifierUserId { get; set; }
	}
}
