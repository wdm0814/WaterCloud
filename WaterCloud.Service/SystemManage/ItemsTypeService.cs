﻿/*******************************************************************************
 * Copyright © 2020 WaterCloud.Framework 版权所有
 * Author: WaterCloud
 * Description: WaterCloud快速开发平台
 * Website：
*********************************************************************************/

using SqlSugar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterCloud.Domain.SystemManage;

namespace WaterCloud.Service.SystemManage
{
	public class ItemsTypeService : BaseService<ItemsEntity>, IDenpendency
	{
		public ItemsTypeService(ISqlSugarClient context) : base(context)
		{
		}

		public async Task<List<ItemsEntity>> GetList()
		{
			var query = repository.IQueryable();
			return await query.Where(a => a.F_DeleteMark == false).OrderBy(a => a.F_SortCode).ToListAsync();
		}

		public async Task<List<ItemsEntity>> GetLookList()
		{
			var query = repository.IQueryable().Where(a => a.F_DeleteMark == false);
			query = GetDataPrivilege("a", "", query);
			return await query.OrderBy(a => a.F_SortCode).ToListAsync();
		}

		public async Task<ItemsEntity> GetLookForm(string keyValue)
		{
			var data = await repository.FindEntity(keyValue);
			return GetFieldsFilterData(data);
		}

		public async Task<ItemsEntity> GetForm(string keyValue)
		{
			var data = await repository.FindEntity(keyValue);
			return data;
		}

		public async Task DeleteForm(string keyValue)
		{
			if (await repository.IQueryable(a => a.F_ParentId.Equals(keyValue)).AnyAsync())
			{
				throw new Exception("删除失败！操作的对象包含了下级数据。");
			}
			else
			{
				await repository.Delete(a => a.F_Id == keyValue);
			}
		}

		public async Task SubmitForm(ItemsEntity itemsEntity, string keyValue)
		{
			if (!string.IsNullOrEmpty(keyValue))
			{
				itemsEntity.Modify(keyValue);
				await repository.Update(itemsEntity);
			}
			else
			{
				itemsEntity.F_DeleteMark = false;
				itemsEntity.F_IsTree = false;
				itemsEntity.Create();
				await repository.Insert(itemsEntity);
			}
		}
	}
}