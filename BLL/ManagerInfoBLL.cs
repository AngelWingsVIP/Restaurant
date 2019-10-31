using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class ManagerInfoBLL
    {
        ManagerInfoDal midal = new ManagerInfoDal();
        public List<ManagerInfo> GetManagerInfoList()
        {
            return midal.GetManagerInfoList();
        }

        public bool Add(ManagerInfo mi)
        {

            return Convert.ToBoolean(midal.Insert(mi));


        }

        public int Remove(int index)
        {
            return midal.Delete(index);

        }

        public int alter(ManagerInfo mi)
        {
           return  midal.Updata(mi);
        }

        public bool Login(ManagerInfo mi)
        {
            var dt = midal.CheckLogin(mi);

            if (dt.Rows.Count>0)
            {
                mi.Mtype = Convert.ToInt32(dt.Rows[0][3].ToString());
              
                return true;
            }
            else
            {
                return false;

            }

        }
    }
}
