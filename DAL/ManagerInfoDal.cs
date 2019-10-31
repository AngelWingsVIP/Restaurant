using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SQLite;
using Common;
namespace DAL
{
    public class ManagerInfoDal
    {
       public List<ManagerInfo> GetManagerInfoList()
        {
            //执行查询语句

            System.Data.DataTable table = SqliteHelper.GetDataList("select * from ManagerInfo");

            //数据集合                                  

            List<ManagerInfo> list = new List<ManagerInfo>();


            //遍历数据  

            foreach (System.Data.DataRow row in table.Rows)
            {
                list.Add(new ManagerInfo()
                {

                    Mid = Convert.ToInt32(row["MId"]),
                    Mname = row["MName"].ToString(),
                    Mpwd = row["MPwd"].ToString(),
                    Mtype = Convert.ToInt32(row["MType"])
                });
            }

            return list;
        }

        public int Insert(ManagerInfo mi)
        {
            string sql = "insert into ManagerInfo(MName,MPwd,MType) values(@Name,@Pwd,@Type)";

            SQLiteParameter[] ps = { 
            new SQLiteParameter("@Name",mi.Mname),
            new SQLiteParameter("@Pwd",mi.Mpwd),
            new SQLiteParameter("@Type",mi.Mtype)
            };

            return SqliteHelper.Execute(sql,Model.sqltype.ExecuteNonQuery,ps);
        }

        public int Delete(int index)
        {
            string sql = "delete from ManagerInfo where Mid=@id";

                SQLiteParameter[] ps = {
                new SQLiteParameter("@id",index)
            };

            return SqliteHelper.Execute(sql,Model.sqltype.ExecuteNonQuery, ps);
           
        }

        public int Updata(ManagerInfo mi)
        {
            string sql = "update  ManagerInfo set MId=@id,MName=@user,Mpwd=@pwd,MType=@type where mid=@id";

            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@id",mi.Mid),
                new SQLiteParameter("@user",mi.Mname),
                new SQLiteParameter("@pwd",mi.Mpwd),
                new SQLiteParameter("@type",mi.Mtype)

            };
            return SqliteHelper.Execute(sql,Model.sqltype.ExecuteNonQuery,ps);
        }

        public System.Data.DataTable CheckLogin(ManagerInfo mi)
        {
            string sql = "select * from ManagerInfo where mname=@name and mpwd=@pwd";

            SQLiteParameter[] ps = { 
            
                new SQLiteParameter("@name",mi.Mname),           
                new SQLiteParameter("@pwd",MD5Helper.Md5_Encrypt(mi.Mpwd))
            };

            return SqliteHelper.GetDataList(sql,ps);
        }
    }
}
