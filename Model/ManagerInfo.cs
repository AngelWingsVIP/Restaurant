﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ManagerInfo
    {
                public int Mid { get; set; }
                public string Mname { get; set; }
                public string Mpwd { get; set; }
                public  int Mtype { get;set;}
    
    }
    public enum sqltype
    {
        ExecuteScalar,

        ExecuteNonQuery
    }
}
