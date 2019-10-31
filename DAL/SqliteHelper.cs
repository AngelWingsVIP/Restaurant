using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.ComponentModel;

namespace DAL
{
    public static class SqliteHelper
    {
        private static readonly string strConn = ConfigurationManager.ConnectionStrings["cater"].ConnectionString;

        public  static DataTable GetDataList(string sql,params SQLiteParameter[] ps)
        {
               //连接 数据库

            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                //桥接 数据库 操作
                if (ps.Length>0)
                {
                    SQLiteCommand comm = new SQLiteCommand(sql,conn);

                    comm.Parameters.AddRange(ps);

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                    //构造 数据表 对象

                    DataTable table = new DataTable();

                    //映射数据表
                    adapter.Fill(table);
                    //返回数据
                    return table;
                }
                else
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql,conn);

                    //构造 数据表 对象

                    DataTable table = new DataTable();

                    //映射数据表
                    adapter.Fill(table);
                    //返回数据
                    return table;
                }

                
                
                    
                
            }

        }

        public static int Execute(string sql,Model.sqltype etype,params SQLiteParameter[] ps)
        {
            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                try
                {
                    conn.Open();

                    SQLiteCommand comm = new SQLiteCommand(sql,conn);

                    comm.Parameters.AddRange(ps);

                    switch (etype)
                    {
                        case Model.sqltype.ExecuteScalar:
                            return Convert.ToInt32(comm.ExecuteScalar());
                        case Model.sqltype.ExecuteNonQuery:
                            return comm.ExecuteNonQuery();
                           
                        default:
                            return -1;
                           
                    }



                }
                catch (Exception)
                {

                    return -1;


                }


            }

        }
    }
}
