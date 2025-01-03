﻿using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using System;
using System.Linq;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.SystemOrganize;
using WaterCloud.Service.SystemOrganize;

namespace WaterCloud.Web.Areas.SystemOrganize.Controllers
{
	/// <summary>
	/// 创 建：超级管理员
	/// 日 期：2020-06-12 13:50
	/// 描 述：系统设置控制器类
	/// </summary>
	[Area("SystemOrganize")]
	public class SystemSetController : BaseController
	{
		public SystemSetService _service { get; set; }

		#region 获取数据

		[HttpGet]
		[HandlerAuthorize]
		[HandlerAdmin(false)]
		public virtual ActionResult SetForm()
		{
			return View();
		}

		[HttpGet]
		[HandlerAjaxOnly]
		[HandlerAdmin]
		public async Task<ActionResult> GetGridJson(Pagination pagination, string keyword)
		{
			if (string.IsNullOrEmpty(pagination.field))
			{
				pagination.order = "desc";
				pagination.field = "F_Id";
			}
			//导出全部页使用
			if (pagination.rows == 0 && pagination.page == 0)
			{
				pagination.rows = 99999999;
				pagination.page = 1;
			}
			var data = await _service.GetLookList(pagination, keyword);
			return Success(pagination.records, data);
		}

		[HttpGet]
		[HandlerAjaxOnly]
		public async Task<ActionResult> GetListJson(string keyword)
		{
			var data = await _service.GetList(keyword);
			var currentuser = _service.currentuser;
			if (currentuser.UserId == null)
			{
				return null;
			}
			else
			{
				data = data.Where(a => a.F_Id == _service.currentuser.CompanyId).ToList();
				foreach (var item in data)
				{
					item.F_AdminAccount = null;
					item.F_AdminPassword = null;
					item.F_DBProvider = null;
					item.F_DbString = null;
					item.F_HostUrl = null;
					item.F_PrincipalMan = null;
					item.F_MobilePhone = null;
				}
				return Content(data.ToJson());
			}
		}

		[HttpGet]
		[HandlerAjaxOnly]
		public ActionResult GetDbTypeJson()
		{
			var data = EnumHelper.EnumToList<DbType>();
			return Content(data.ToJson());
		}

		[HttpGet]
		[HandlerAjaxOnly]
		[HandlerAdmin]
		public async Task<ActionResult> GetFormJson(string keyValue)
		{
			var data = await _service.GetForm(keyValue);
			return Content(data.ToJson());
		}

		[HttpGet]
		[HandlerAjaxOnly]
		[HandlerAdmin(false)]
		public async Task<ActionResult> GetSetFormJson()
		{
			var data = await _service.GetForm(_service.currentuser.CompanyId);
			return Content(data.ToJson());
		}

		#endregion 获取数据

		#region 提交数据

		[HttpPost]
		[HandlerAjaxOnly]
		[HandlerAdmin]
		public async Task<ActionResult> SubmitForm(SystemSetEntity entity, string permissionbuttonIds, string permissionfieldsIds, string keyValue)
		{
			try
			{
				await _service.SubmitForm(entity, keyValue, string.IsNullOrEmpty(permissionbuttonIds) ? null : permissionbuttonIds.Split(','), string.IsNullOrEmpty(permissionfieldsIds) ? null : permissionfieldsIds.Split(','));
				return await Success("操作成功。", "", keyValue);
			}
			catch (Exception ex)
			{
				return await Error(ex.Message, "", keyValue);
			}
		}

		[HttpPost]
		[HandlerAjaxOnly]
		[HandlerAdmin(false)]
		public async Task<ActionResult> SetSubmitForm(SystemSetEntity entity)
		{
			var keyValue = _service.currentuser.CompanyId;
			try
			{
				entity.F_DeleteMark = false;
				entity.F_EnabledMark = null;
				entity.F_EndTime = null;
				await _service.SubmitForm(entity, keyValue);
				return await Success("操作成功。", "", keyValue);
			}
			catch (Exception ex)
			{
				return await Error(ex.Message, "", keyValue);
			}
		}

		[HttpPost]
		[HandlerAjaxOnly]
		[HandlerAuthorize]
		[HandlerAdmin]
		public async Task<ActionResult> DeleteForm(string keyValue)
		{
			try
			{
				await _service.DeleteForm(keyValue);
				return await Success("操作成功。", "", keyValue, DbLogType.Delete);
			}
			catch (Exception ex)
			{
				return await Error(ex.Message, "", keyValue, DbLogType.Delete);
			}
		}

		#endregion 提交数据
	}
}