﻿namespace WaterCloud.Domain
{
	public class HomeInfoEntity
	{
		public string title { get; set; }
		public string href { get; set; }

		public HomeInfoEntity()
		{
			title = "首页";
			href = "../Home/Default";
		}
	}
}