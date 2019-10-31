using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SQLite;
namespace DAL
{
    public class DishTypeInfoDAL
    {
        public List<DishTypeInfo> GetDishTypeList()
        {
            string sql = "select * from DishTypeInfo where DIsDelete=0";

            var dt = SqliteHelper.GetDataList(sql);

            List<DishTypeInfo> list = new List<DishTypeInfo>();

            foreach (System.Data.DataRow row in dt.Rows)
            {
                list.Add(new DishTypeInfo()
                {

                    Did = Convert.ToInt32(row["did"]),
                    Dtitle = row["dtitle"].ToString(),
    
                });
            }

            return list;
        }

        public int Insert(DishTypeInfo mti)
        {
            string sql = "insert into DishTypeInfo(DId,dtitle,DIsDelete) values(@id,@type,@IsDelete)";    

            SQLiteParameter[] ps = {
                new SQLiteParameter("@id",mti.Did),
                 new SQLiteParameter("@type",mti.Dtitle),
                 new SQLiteParameter("@IsDelete",mti.DIsDelete)
            };

            return SqliteHelper.Execute(sql, sqltype.ExecuteNonQuery, ps);
        }

        public int Update(DishTypeInfo mti,int index)
        {
            //想要修改的话 必须拿到目前ID
            string sql = "update DishTypeInfo set did=@id,dtitle=@title where did=@index"; 

            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@id",mti.Did),
                new SQLiteParameter("@title",mti.Dtitle),
                new SQLiteParameter("@index",index)

            };

            return SqliteHelper.Execute(sql, sqltype.ExecuteNonQuery, ps);
        }

        public int Delete(int index)
        {

            string sql = "delete from DishInfo where DTypeId=@id";

            string sql2 = "delete from DishTypeInfo where did=@id";

            SQLiteParameter ps = new SQLiteParameter("@id", index);

            if (SqliteHelper.Execute(sql, sqltype.ExecuteNonQuery, ps) > -1)
            {
                return SqliteHelper.Execute(sql2, sqltype.ExecuteNonQuery, ps);
            }
            return -1;

        }
    }
}
