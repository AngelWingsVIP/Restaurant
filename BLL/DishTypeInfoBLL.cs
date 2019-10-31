using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
   public class DishTypeInfoBLL
    {

        DishTypeInfoDAL mbtdal = new DishTypeInfoDAL();
        public List<DishTypeInfo> GetDishTypeList()
        {
            return mbtdal.GetDishTypeList();

        }

        public bool Add(DishTypeInfo mti)
        {
            if (mbtdal.Insert(mti) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Alert(DishTypeInfo mti,int index)
        {

            if (mbtdal.Update(mti,index) > 0)
            {
                return true;

            }
            return false;
        }

        public bool Remove(int index)
        {
            if (mbtdal.Delete(index) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
