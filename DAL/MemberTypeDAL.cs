using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SQLite;
namespace DAL
{
   public class MemberTypeDAL
    {
        public List<MemberTypeInfo> GetMemberTypeList()
        {
            string sql = "select * from MemberTypeInfo where MIsDelete=0";

            var dt = SqliteHelper.GetDataList(sql);

            List<MemberTypeInfo> list = new List<MemberTypeInfo>();

            foreach (System.Data.DataRow row in dt.Rows)
            {
                list.Add(new MemberTypeInfo() { 
                
                     Mid =Convert.ToInt32(row["Mid"]),
                     Mtitle = row["mtitle"].ToString(),
                     Mdiscount = Convert.ToDecimal(row["mdiscount"])

                });
            }

            return list;
        }

        public int Insert(MemberTypeInfo mti)
        {
            string sql = "insert into MemberTypeInfo(mid,mtitle,mdiscount,misdelete) values(@id,@type,@discount,@isdelete)";

            SQLiteParameter[] ps = { 
                new SQLiteParameter("@id",mti.Mid),
                 new SQLiteParameter("@type",mti.Mtitle),
                  new SQLiteParameter("@discount",mti.Mdiscount),
                   new SQLiteParameter("@isdelete",mti.MIsDelete)

            };

            return SqliteHelper.Execute(sql, sqltype.ExecuteNonQuery, ps);
        }

        public int Update(MemberTypeInfo mti)
        {
            string sql = "update MemberTypeInfo set Mtitle=@title,Mdiscount=@discount,MIsDelete=@isdelete where mid=@id";

            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@id",mti.Mid),
                new SQLiteParameter("@title",mti.Mtitle),
                new SQLiteParameter("@discount",mti.Mdiscount),
                 new SQLiteParameter("@isdelete",mti.MIsDelete)
            };

            return SqliteHelper.Execute(sql,sqltype.ExecuteNonQuery,ps);
        }

        public int Delete(int index)
        {
           
            string sql = "delete from MemberInfo where MTypeId=@id";

            string sql2 = "delete from MemberTypeInfo where mid=@id";

            SQLiteParameter ps = new SQLiteParameter("@id",index);

            if (SqliteHelper.Execute(sql, sqltype.ExecuteNonQuery, ps)>-1)
            {
               return SqliteHelper.Execute(sql2, sqltype.ExecuteNonQuery, ps);
            }
            return -1;

        }
    }
}
