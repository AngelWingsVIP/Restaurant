using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class MemberInfoDAL
    {
        public List<MemberInfo> GetDataList(int tag)
        {
            string sql = "select * from MemberInfo where Mtypeid=@typeid";

            SQLiteParameter ps = new SQLiteParameter("@typeid",tag);

            DataTable dt= SqliteHelper.GetDataList(sql, ps);

            List<MemberInfo> list = new List<MemberInfo>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MemberInfo()
                {
                    Mid = Convert.ToInt32(row["Mid"]),

                    MTypeid = Convert.ToInt32(row["MTypeid"]),

                    MIsDelete = Convert.ToBoolean(row["MIsDelete"]),

                    MMoney = Convert.ToDecimal(row["MMoney"]),

                    MName = row["MName"].ToString(),

                    Mphone = row["Mphone"].ToString()
                }) ; 
            }

            return list;
        }

        public int Insert(MemberInfo mi)
        {
           
            string sql = "insert into MemberInfo(MTypeId,MName,MPhone,MMoney,MIsDelete) values(@TypeId,@Name,@Phone,@Money,@IsDelete)";

            SQLiteParameter[] ps = {
                new SQLiteParameter("@IsDelete",mi.MIsDelete),
                new SQLiteParameter("@Money",mi.MMoney),
                new SQLiteParameter("@Name",mi.MName),
                new SQLiteParameter("@Phone",mi.Mphone),
                new SQLiteParameter("@TypeId",mi.MTypeid)
            };

            return SqliteHelper.Execute(sql, sqltype.ExecuteNonQuery, ps);
        }

        public int Update(MemberInfo mi)
        {
            string sql = "update MemberInfo as mi set MTypeId=@TypeId,MName=@Name,MPhone=@Phone,MMoney=@Money,MIsDelete=@IsDelete " +
                                             "where EXISTS(select * from MemberTypeInfo mti where mti.mid=@TypeId and mi.Mid=@mid)";

            SQLiteParameter[] ps = { 
            
            new SQLiteParameter("@TypeId",mi.MTypeid),
             new SQLiteParameter("@IsDelete",mi.MIsDelete),
              new SQLiteParameter("@Money",mi.MMoney),
               new SQLiteParameter("@Phone",mi.Mphone),
                new SQLiteParameter("@Name",mi.MName),
                    new SQLiteParameter("@mid",mi.Mid)
            };

           return  SqliteHelper.Execute(sql, sqltype.ExecuteNonQuery, ps);

        }

        public int Delete(int index)
        {
            string sql  = "delete from MemberInfo where mid=@id";

            SQLiteParameter ps = new SQLiteParameter("@id",index);

             return SqliteHelper.Execute(sql, sqltype.ExecuteNonQuery, ps);

        }
    }
}
    