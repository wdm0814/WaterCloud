using System.Collections.Generic;
using WaterCloud.Code;
using WaterCloud.DataBase;

namespace WaterCloud.Domain.SystemSecurity
{
    /// <summary>
    /// �� ������������Ա
    /// �� �ڣ�2024-07-19 19:42
    /// �� ������ʱ��������
    /// </summary>
    public class ServerStateSeedData : ISqlSugarEntitySeedData<ServerStateEntity>
    {
        [IgnoreSeedDataUpdate]
        public IEnumerable<ServerStateEntity> SeedData()
        {
            var data = "";
            return data.ToObject<List<ServerStateEntity>>();
        }
    }
}