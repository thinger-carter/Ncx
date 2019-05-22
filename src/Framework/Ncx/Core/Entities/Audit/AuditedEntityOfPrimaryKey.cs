using System;

namespace Ncx.Core.Entities.Audit
{
	/// <summary>
	/// 自定义主键审计接口
	/// </summary>
	/// <typeparam name="TPrimaryKey">主键类型</typeparam>
	public abstract class AuditedEntityOfPrimaryKey<TPrimaryKey>:EntityOfPrimaryKey<TPrimaryKey>,IAudited
	{
		/// <summary>
		/// 实体创建时间
		/// </summary>
		public virtual DateTime CreationTime { get; set; }

		/// <summary>
		/// 实体创建用户Id
		/// </summary>
		public virtual int? CreatorUserId { get; set; }

		/// <summary>
		/// 最后修改时间
		/// </summary>
		public virtual DateTime? LastModificationTime { get; set; }

		/// <summary>
		/// 最后修改用户Id
		/// </summary>
		public virtual int? LastModifierUserId { get; set; }
	}
}
