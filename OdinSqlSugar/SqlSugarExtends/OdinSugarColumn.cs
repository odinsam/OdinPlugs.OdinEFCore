using SqlSugar;

namespace OdinPlugs.OdinEFCore.OdinSqlSugar.SqlSugarExtends
{
    public class OdinSugarColumn : SugarColumn
    {
        public OdinSugarColumn()
        {
            this.IsNullable = true;
        }
    }
    public class OdinSugarStringColumn : SugarColumn
    {
        public OdinSugarStringColumn()
        {
            this.IsNullable = true;
            this.Length = 4096;
        }
    }

}