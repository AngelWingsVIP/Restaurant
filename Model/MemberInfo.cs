using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MemberInfo
    {
        public int Mid { get; set; }
        public int MTypeid {get;set; }
        public string MName { get; set; }
        public string Mphone { get; set; }
        public decimal MMoney { get; set; }
        public bool MIsDelete { get; set; } = false;




    }
}
