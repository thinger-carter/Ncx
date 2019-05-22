using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncx.Core.Entities
{
	/// <summary>
	/// 自定义主键的实体基类
	/// </summary>
	/// <typeparam name="TPrimaryKey">主键类型</typeparam>
	public abstract class EntityOfPrimaryKey<TPrimaryKey> : IEntityOfPrimaryKey<TPrimaryKey>
	{
		/// <summary>
		/// 实体主键
		/// </summary>
		public TPrimaryKey Id { get; set ; }
	}
}
