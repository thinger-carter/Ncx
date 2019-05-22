namespace Ncx.Core.Uow
{
	/// <summary>
	/// 工作单元接口
	/// </summary>
	public interface IUnitOfWork
	{
		/// <summary>
		/// 开启事务
		/// </summary>
		void BeginTransaction();

		/// <summary>
		/// 提交事务
		/// </summary>
		void Commit();

		/// <summary>
		/// 回滚事务
		/// </summary>
		void Callback();
	}
}
