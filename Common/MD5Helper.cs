using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public  class MD5Helper
    {
        public static string Md5_Encrypt(string txt)
        {
            MD5 md5 = MD5.Create();

            byte[] bys = Encoding.UTF8.GetBytes(txt);

            byte[]Enbys  = md5.ComputeHash(bys);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Enbys.Length; i++)
            {
                sb.Append(Enbys[i].ToString("x2").ToUpper());
            }

            return sb.ToString();
        }
    }
}
