using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPinyin;
namespace Common
{
    public class PYHelper
    {
        public string Get_char_pingying(string text)
        {
            return Pinyin.GetInitials(text); 

        }

    }
}
