﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
   public class DishInfoBLL
    {

        DishInfoDAL mid = new DishInfoDAL();
        public List<DishInfo> GetDataList()
        {
            return mid.GetDataList();
        }
    }
}
