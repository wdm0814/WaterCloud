﻿/*******************************************************************************
 * Copyright © 2020 WaterCloud.Framework 版权所有
 * Author: WaterCloud
 * Description: WaterCloud快速开发平台
 * Website：
*********************************************************************************/

using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WaterCloud.Code;

namespace WaterCloud.DataBase
{
	/// <summary>
	/// 泛型仓储实现
	/// </summary>
	/// <typeparam name="TEntity"></typeparam>
	public class RepositoryBase<TEntity> where TEntity : class, new()
	{
		// 用于其他表操作
		public ITenant Tenant
		{
			get { return _tenant; }
		}

		private ITenant _tenant;

		private SqlSugarScopeProvider _db;

		public SqlSugarScopeProvider Db
		{
            get { return _db; }
		}

		/// <summary>
		/// 切换上下文，不传参切换到实体租户
		/// </summary>
		/// <param name="configId"></param>
		/// <returns></returns>
		public ISqlSugarClient ChangeEntityDb(object configId = null)
		{
			if (!configId.IsEmpty())
			{
                _db = _tenant.GetConnectionScope(configId);
			}
			else
			{
                _db = _tenant.GetConnectionScopeWithAttr<TEntity>();
			}
			return _db;
		}

		public RepositoryBase(ISqlSugarClient scope)
		{
			_tenant = scope.AsTenant();
            _db = Tenant.GetConnectionScopeWithAttr<TEntity>();
		}

		public async Task<TEntity> Insert(TEntity entity)
		{
			return await _db.Insertable(entity).ExecuteReturnEntityAsync();
		}

		public async Task<int> Insert(List<TEntity> entitys)
		{
			return await _db.Insertable(entitys).ExecuteCommandAsync();
		}

		public async Task<int> Update(TEntity entity)
		{
			return await _db.Updateable(entity).IgnoreColumns(ignoreAllNullColumns: true).ExecuteCommandAsync();
		}

		public async Task<int> Update(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TEntity>> content)
		{
			return await _db.Updateable(content).Where(predicate).ExecuteCommandAsync();
		}

		public async Task<int> Delete(TEntity entity)
		{
			return await _db.Deleteable(entity).ExecuteCommandAsync();
		}

		public async Task<int> Delete(Expression<Func<TEntity, bool>> predicate)
		{
			return await _db.Deleteable(predicate).ExecuteCommandAsync();
		}

		public async Task<TEntity> FindEntity(object keyValue)
		{
			return await IQueryable().InSingleAsync(keyValue);
		}

		public async Task<TEntity> FindEntity(Expression<Func<TEntity, bool>> predicate)
		{
			return await IQueryable().FirstAsync(predicate);
		}

		public ISugarQueryable<TEntity> IQueryable()
		{
			return _db.Queryable<TEntity>();
		}

		public ISugarQueryable<TEntity> IQueryable(Expression<Func<TEntity, bool>> predicate)
		{
			return IQueryable().Where(predicate);
		}

		public ISugarQueryable<TEntity> IQueryable(string strSql)
		{
			return _db.SqlQueryable<TEntity>(strSql);
		}
	}
}