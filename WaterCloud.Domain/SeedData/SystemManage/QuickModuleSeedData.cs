using System.Collections.Generic;
using WaterCloud.Code;
using WaterCloud.DataBase;

namespace WaterCloud.Domain.SystemManage
{
    /// <summary>
    /// �� ������������Ա
    /// �� �ڣ�2024-07-19 19:42
    /// �� ������ݲ˵�����
    /// </summary>
    public class QuickModuleSeedData : ISqlSugarEntitySeedData<QuickModuleEntity>
    {
        [IgnoreSeedDataUpdate]
        public IEnumerable<QuickModuleEntity> SeedData()
        {
            var data = "";
            return data.ToObject<List<QuickModuleEntity>>();
        }
    }
}