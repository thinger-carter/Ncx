using Ncx.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ncx.Core.Repisitories
{
	/// <summary>
	/// 自定义主键类型的仓储接口
	/// </summary>
	/// <typeparam name="TEntity">实体泛型</typeparam>
	/// <typeparam name="TPrimaryKey">主键类型</typeparam>
	public interface IRepositoryOfEntityAndPrimaryKey<TEntity,TPrimaryKey>
		:IRepository 
		where TEntity:class,IEntityOfPrimaryKey<TPrimaryKey>
	{
		#region 查询(Select/Get/Query)

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <returns></returns>
		IQueryable<TEntity> GetAll();

		/// <summary>
		/// 获取所有数据集合
		/// </summary>
		/// <returns></returns>
		List<TEntity> GetAllList();

		/// <summary>
		/// 根据条件查询数据集合
		/// </summary>
		/// <param name="predicate">查询条件</param>
		/// <returns></returns>
		List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);

		/// <summary>
		/// 根据主键查询实体
		/// </summary>
		/// <param name="key">主键</param>
		/// <returns></returns>
		TEntity Get(TPrimaryKey key);

		/// <summary>
		/// 根据添加查询单个实体数据
		/// </summary>
		/// <param name="predicate">查询条件</param>
		/// <returns></returns>
		TEntity Single(Expression<Func<TEntity, bool>> predicate);

		/// <summary>
		/// 根据主键查询
		/// </summary>
		/// <param name="key">主键</param>
		/// <returns></returns>
		TEntity FirstOrDefault(TPrimaryKey key);

		/// <summary>
		/// 根据条件查询
		/// </summary>
		/// <param name="predicate">查询条件</param>
		/// <returns></returns>
		TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

		#endregion

		#region 添加

		/// <summary>
		/// 添加
		/// </summary>
		/// <param name="entity">要添加实体</param>
		/// <returns></returns>
		TEntity Insert(TEntity entity);

		#endregion

		#region 修改

		/// <summary>
		/// 修改
		/// </summary>
		/// <param name="entity">修改后的实体</param>
		/// <returns></returns>
		TEntity Update(TEntity entity);

		#endregion

		#region 删除

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="entity">要删除的实体</param>
		void Delete(TEntity entity);

		#endregion

		#region 统计

		/// <summary>
		/// 获取总记录条数
		/// </summary>
		/// <returns></returns>
		int Count();

		/// <summary>
		/// 根据条件获取总记录条数
		/// </summary>
		/// <param name="predicate">查询条件</param>
		/// <returns></returns>
		int Count(Expression<Func<TEntity, bool>> predicate);

		#endregion
	}
}
