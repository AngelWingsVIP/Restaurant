﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MemberTypeInfo
    {
        public int Mid { get; set; }

        public string Mtitle { get; set; }

        public decimal Mdiscount { get; set; }

        public bool MIsDelete { get; set; } = false;

    }
}
