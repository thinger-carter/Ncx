using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncx.Core.Entities
{
	/// <summary>
	/// 自定义主键类型的实体接口
	/// </summary>
	/// <typeparam name="TPrimaryKey">主键类型</typeparam>
	public interface IEntityOfPrimaryKey<TPrimaryKey>
	{
		/// <summary>
		/// 主键
		/// </summary>
		TPrimaryKey Id { get; set; }
	}
}
