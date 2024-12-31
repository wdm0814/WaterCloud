using System.Collections.Generic;

namespace WaterCloud.Code.Model
{
	public class SystemConfig
	{
		/// <summary>
		/// 是否是Demo模式
		/// </summary>
		public bool Demo { get; set; }

		/// <summary>
		/// 是否是调试模�?
		/// </summary>
		public bool Debug { get; set; }

		/// <summary>
		/// 允许一个用户在多个电脑同时登录
		/// </summary>
		public bool LoginMultiple { get; set; }

		/// <summary>
		/// 允许跨域的站�?
		/// </summary>
		public string AllowCorsSite { get; set; }

		/// <summary>
		/// 主库数据库类�?
		/// </summary>
		public string DBProvider { get; set; }

		/// <summary>
		/// 主库数据库连�?
		/// </summary>
		public string DBConnectionString { get; set; }

		/// <summary>
		/// 数据库连接超�?
		/// </summary>
		public int DBCommandTimeout { get; set; }

        /// <summary>
        /// 是否初始化数据库
        /// </summary>
        public bool IsInitDb { get; set; }

        /// <summary>
        /// 是否初始化种子数�?
        /// </summary>
        public bool IsSeedData { get; set; }

		/// <summary>
		/// 缓存类型
		/// </summary>
        public string CacheProvider { get; set; }

		/// <summary>
		/// redis连接�?
		/// </summary>
		public string RedisConnectionString { get; set; }

		/// <summary>
		/// api token名称
		/// </summary>
		public string TokenName { get; set; }

		//缓存过期时间
		public int LoginExpire { get; set; }

		/// <summary>
		/// 主页
		/// </summary>
		public string HomePage { get; set; }

		/// <summary>
		/// 是否局域网
		/// </summary>
		public bool? LocalLAN { get; set; }

		/// <summary>
		/// 数据库模�?
		/// </summary>
		public string SqlMode { get; set; }

		/// <summary>
		/// 项目前缀
		/// </summary>
		public string ProjectPrefix { get; set; }

		/// <summary>
		/// 是否重置密码
		/// </summary>
		public bool? ReviseSystem { get; set; }

		/// <summary>
		/// 登录错误次数
		/// </summary>
		public int? LoginErrorCount { get; set; }

		/// <summary>
		/// 多数据库�?
		/// </summary>
		public List<DBConfig> SqlConfig { get; set; }

		/// <summary>
		/// 是否集群
		/// </summary>
		public bool? IsCluster { get; set; }

		/// <summary>
		/// 是否删除定时调度任务
		/// </summary>
		public bool? NeedClear { get; set; }

		/// <summary>
		/// 主程序数据库编号
		/// </summary>
		public string MainDbNumber { get; set; }

		/// <summary>
		/// 是否开启定时任�?
		/// </summary>
		public bool? OpenQuartz { get; set; }

		/// <summary>
		/// api文档配置
		/// </summary>
		public DocumentSettings DocumentSettings { get; set; }

		/// <summary>
		/// rabbitmq配置
		/// </summary>
		public MqConfig RabbitMq { get; set; }
	}

	public class DocumentSettings
	{
		/// <summary>
		/// 标题
		/// </summary>
		public string DocumentTitle { get; set; }
		public List<GroupOpenApiInfo> GroupOpenApiInfos { get; set; }
	}

	public class GroupOpenApiInfo
	{
		/// <summary>
		/// 分组
		/// </summary>
		public string Group { get; set; }

		/// <summary>
		/// 组标�?
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 描述
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// 版本
		/// </summary>
		public string Version { get; set; }
	}

	public class DBConfig
	{
		/// <summary>
		/// 数据库序�?
		/// </summary>
		public string DBNumber { get; set; }

		/// <summary>
		/// 数据库类�?
		/// </summary>
		public string DBProvider { get; set; }

		/// <summary>
		/// 数据库连�?
		/// </summary>
		public string DBConnectionString { get; set; }
	}
}