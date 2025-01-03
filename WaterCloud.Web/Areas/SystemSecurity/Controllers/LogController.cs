/*******************************************************************************
 * Copyright © 2020 WaterCloud.Framework 版权所有
 * Author: WaterCloud
 * Description: WaterCloud快速开发平台
 * Website：
*********************************************************************************/

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WaterCloud.Code;

namespace WaterCloud.Web.Areas.SystemSecurity.Controllers
{
	[Area("SystemSecurity")]
	public class LogController : BaseController
	{
		[HttpGet]
		[HandlerAuthorize]
		public ActionResult RemoveLog()
		{
			return View();
		}

		[HttpGet]
		[HandlerAjaxOnly]
		public async Task<ActionResult> GetGridJson(Pagination pagination, string keyword, int timetype = 2)
		{
			if (string.IsNullOrEmpty(pagination.field))
			{
				pagination.order = "desc";
				pagination.field = "F_CreatorTime";
			}
			//导出全部页使用
			if (pagination.rows == 0 && pagination.page == 0)
			{
				pagination.rows = 99999999;
				pagination.page = 1;
			}
			var data = await _logService.GetList(pagination, timetype, keyword);
			return Success(pagination.records, data);
		}

		[HttpPost]
		[HandlerAjaxOnly]
		public async Task<ActionResult> SubmitRemoveLog(string keepTime)
		{
			await _logService.RemoveLog(keepTime);
			return Success("清空成功。");
		}
	}
}