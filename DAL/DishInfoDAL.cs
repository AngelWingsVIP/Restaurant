using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
   public class DishInfoDAL
    {
        public List<DishInfo> GetDataList()
        {
            string sql = "select * from DishInfo where DIsDelete=0";

            System.Data.DataTable dt = SqliteHelper.GetDataList(sql);

            List<DishInfo> list = new List<DishInfo>();

            foreach (System.Data.DataRow row in dt.Rows)
            {
                list.Add(new DishInfo()
                {
                    Did = Convert.ToInt32(row["did"]),

                    DTitle =row["DTitle"].ToString(),

                    DTypeId = Convert.ToInt32(row["DTypeId"]),

                    DPrice = Convert.ToDecimal(row["DPrice"]),

                    DChar = row["DChar"].ToString()

                });
            }

            return list;
        }

    }
}
