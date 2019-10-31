using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class MemberInfoBLL
    {
        MemberInfoDAL mid = new MemberInfoDAL();
        public List<MemberInfo> GetMemberInfoList(int tag)
        {
            return mid.GetDataList(tag);
        }

        public bool Add(MemberInfo mi)
        {
            if (mid.Insert(mi)>0)
            {
                return true;

            }
            return false;
        }

        public bool Alert(MemberInfo mi)
        {

            if (mid.Update(mi)>0)
            {
                return true;
            }
            return false;
        }

        public bool Remov(int index)
        {
            if (mid.Delete(index)>0)
            {
                return true;
            }
            return false;
        }
    }
}
