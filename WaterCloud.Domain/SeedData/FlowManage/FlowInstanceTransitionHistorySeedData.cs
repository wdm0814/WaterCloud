﻿using System.Collections.Generic;
using WaterCloud.Code;
using WaterCloud.DataBase;

namespace WaterCloud.Domain.FlowManage
{
    /// <summary>
    /// 创 建：超级管理员
    /// 日 期：2024-07-19 19:42
    /// 描 述：工作流实例流转历史记录种子
    /// </summary>
    public class FlowInstanceTransitionHistorySeedData : ISqlSugarEntitySeedData<FlowInstanceTransitionHistory>
    {
        [IgnoreSeedDataUpdate]
        public IEnumerable<FlowInstanceTransitionHistory> SeedData()
        {
            var data = "[\r\n    {\r\n        \"F_Id\": \"08daf4c4-5c37-4b2b-82dc-f007b2bfc7e5\",\r\n        \"F_InstanceId\": \"08daf4c4-5c10-4445-87ca-5aaa89d4f980\",\r\n        \"F_FromNodeId\": \"1673542870291\",\r\n        \"F_FromNodeType\": \"3\",\r\n        \"F_FromNodeName\": \"开始_1\",\r\n        \"F_ToNodeId\": \"1673542873160\",\r\n        \"F_ToNodeType\": \"2\",\r\n        \"F_ToNodeName\": \"任务节点_3\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 01:42:22.4269816\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf4c5-0e8f-48e9-89ca-58b3764d62a3\",\r\n        \"F_InstanceId\": \"08daf4c4-5c10-4445-87ca-5aaa89d4f980\",\r\n        \"F_FromNodeId\": \"1673542873160\",\r\n        \"F_FromNodeType\": \"2\",\r\n        \"F_FromNodeName\": \"任务节点_3\",\r\n        \"F_ToNodeId\": \"1673542870291\",\r\n        \"F_ToNodeType\": \"3\",\r\n        \"F_ToNodeName\": \"开始_1\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 01:47:21.6376172\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf4c5-190d-49c6-8022-38633d83305b\",\r\n        \"F_InstanceId\": \"08daf4c4-5c10-4445-87ca-5aaa89d4f980\",\r\n        \"F_FromNodeId\": \"1673542870291\",\r\n        \"F_FromNodeType\": \"3\",\r\n        \"F_FromNodeName\": \"开始_1\",\r\n        \"F_ToNodeId\": \"1673542873160\",\r\n        \"F_ToNodeType\": \"2\",\r\n        \"F_ToNodeName\": \"任务节点_3\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 01:47:39.2403604\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf4c8-fef4-45d7-8436-2ad4b05099c2\",\r\n        \"F_InstanceId\": \"08daf4c8-f13b-42cc-83b8-dd3835c6c1a0\",\r\n        \"F_FromNodeId\": \"1595465816935\",\r\n        \"F_FromNodeType\": \"3\",\r\n        \"F_FromNodeName\": \"node_1\",\r\n        \"F_ToNodeId\": \"1595465820221\",\r\n        \"F_ToNodeType\": \"2\",\r\n        \"F_ToNodeName\": \"第一级\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 02:15:33.4412663\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf4cb-f98b-4c43-8573-6a2ac0e5e11c\",\r\n        \"F_InstanceId\": \"08daf4c4-5c10-4445-87ca-5aaa89d4f980\",\r\n        \"F_FromNodeId\": \"1673542873160\",\r\n        \"F_FromNodeType\": \"2\",\r\n        \"F_FromNodeName\": \"任务节点_3\",\r\n        \"F_ToNodeId\": \"1673542871983\",\r\n        \"F_ToNodeType\": \"4\",\r\n        \"F_ToNodeName\": \"结束_2\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 1,\r\n        \"F_CreatorTime\": \"2023-01-13 02:36:52.8571477\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf4cf-040c-4dfb-834a-b3aaa1b58052\",\r\n        \"F_InstanceId\": \"08daf4c8-f13b-42cc-83b8-dd3835c6c1a0\",\r\n        \"F_FromNodeId\": \"1595465820221\",\r\n        \"F_FromNodeType\": \"2\",\r\n        \"F_FromNodeName\": \"第一级\",\r\n        \"F_ToNodeId\": \"1595465821942\",\r\n        \"F_ToNodeType\": \"2\",\r\n        \"F_ToNodeName\": \"第二级\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 02:58:38.9708589\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf50d-9ce4-4c72-8932-9bd768cf2acc\",\r\n        \"F_InstanceId\": \"08daf50d-9cd9-4b42-8150-02643167cc4d\",\r\n        \"F_FromNodeId\": \"1673542870291\",\r\n        \"F_FromNodeType\": \"3\",\r\n        \"F_FromNodeName\": \"开始_1\",\r\n        \"F_ToNodeId\": \"1673542873160\",\r\n        \"F_ToNodeType\": \"2\",\r\n        \"F_ToNodeName\": \"任务节点_3\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 10:26:44.1967169\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf50d-a35d-4f3c-85d5-a4289751c159\",\r\n        \"F_InstanceId\": \"08daf50d-9cd9-4b42-8150-02643167cc4d\",\r\n        \"F_FromNodeId\": \"1673542873160\",\r\n        \"F_FromNodeType\": \"2\",\r\n        \"F_FromNodeName\": \"任务节点_3\",\r\n        \"F_ToNodeId\": \"1673542870291\",\r\n        \"F_ToNodeType\": \"3\",\r\n        \"F_ToNodeName\": \"开始_1\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 10:26:55.0569998\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf50d-aa5d-41e0-863e-0c7baac60ffd\",\r\n        \"F_InstanceId\": \"08daf50d-9cd9-4b42-8150-02643167cc4d\",\r\n        \"F_FromNodeId\": \"1673542870291\",\r\n        \"F_FromNodeType\": \"3\",\r\n        \"F_FromNodeName\": \"开始_1\",\r\n        \"F_ToNodeId\": \"1673542873160\",\r\n        \"F_ToNodeType\": \"2\",\r\n        \"F_ToNodeName\": \"任务节点_3\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 10:27:06.7955763\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf50d-c457-4de3-80f8-f214d6dcb807\",\r\n        \"F_InstanceId\": \"08daf50d-9cd9-4b42-8150-02643167cc4d\",\r\n        \"F_FromNodeId\": \"1673542873160\",\r\n        \"F_FromNodeType\": \"2\",\r\n        \"F_FromNodeName\": \"任务节点_3\",\r\n        \"F_ToNodeId\": \"1673542871983\",\r\n        \"F_ToNodeType\": \"4\",\r\n        \"F_ToNodeName\": \"结束_2\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 1,\r\n        \"F_CreatorTime\": \"2023-01-13 10:27:50.3819372\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf511-3927-40d7-8670-2da8fa04272c\",\r\n        \"F_InstanceId\": \"08daf511-3913-4b78-8716-1c0726a7667c\",\r\n        \"F_FromNodeId\": \"1673542870291\",\r\n        \"F_FromNodeType\": \"3\",\r\n        \"F_FromNodeName\": \"开始_1\",\r\n        \"F_ToNodeId\": \"1673542873160\",\r\n        \"F_ToNodeType\": \"2\",\r\n        \"F_ToNodeName\": \"任务节点_3\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 10:52:34.845814\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf511-5bdf-43d8-802c-cf8c36ce8297\",\r\n        \"F_InstanceId\": \"08daf511-3913-4b78-8716-1c0726a7667c\",\r\n        \"F_FromNodeId\": \"1673542873160\",\r\n        \"F_FromNodeType\": \"2\",\r\n        \"F_FromNodeName\": \"任务节点_3\",\r\n        \"F_ToNodeId\": \"1673542871983\",\r\n        \"F_ToNodeType\": \"4\",\r\n        \"F_ToNodeName\": \"结束_2\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 1,\r\n        \"F_CreatorTime\": \"2023-01-13 10:53:33.0952662\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf513-ea03-40cc-8d09-4f8a15ba489e\",\r\n        \"F_InstanceId\": \"08daf513-e9f1-4d00-8d37-46b7ffa5e7eb\",\r\n        \"F_FromNodeId\": \"1673542870291\",\r\n        \"F_FromNodeType\": \"3\",\r\n        \"F_FromNodeName\": \"开始_1\",\r\n        \"F_ToNodeId\": \"1673542873160\",\r\n        \"F_ToNodeType\": \"2\",\r\n        \"F_ToNodeName\": \"任务节点_3\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 0,\r\n        \"F_CreatorTime\": \"2023-01-13 11:11:50.560116\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    },\r\n    {\r\n        \"F_Id\": \"08daf516-2330-4692-8d20-2c9502fce007\",\r\n        \"F_InstanceId\": \"08daf513-e9f1-4d00-8d37-46b7ffa5e7eb\",\r\n        \"F_FromNodeId\": \"1673542873160\",\r\n        \"F_FromNodeType\": \"2\",\r\n        \"F_FromNodeName\": \"任务节点_3\",\r\n        \"F_ToNodeId\": \"1673542871983\",\r\n        \"F_ToNodeType\": \"4\",\r\n        \"F_ToNodeName\": \"结束_2\",\r\n        \"F_TransitionSate\": 0,\r\n        \"F_IsFinish\": 1,\r\n        \"F_CreatorTime\": \"2023-01-13 11:27:45.4808773\",\r\n        \"F_CreatorUserId\": \"9f2ec079-7d0f-4fe2-90ab-8b09a8302aba\",\r\n        \"F_CreatorUserName\": \"超级管理员\"\r\n    }\r\n]";
            return data.ToObject<List<FlowInstanceTransitionHistory>>();
        }
    }
}