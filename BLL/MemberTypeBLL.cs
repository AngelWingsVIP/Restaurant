using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class MemberTypeBLL
    {
        MemberTypeDAL mbtdal = new MemberTypeDAL();
        public List<MemberTypeInfo> GetMemberTypeInfo()
        {
            return mbtdal.GetMemberTypeList();

        }

        public bool Add(MemberTypeInfo mti)
        {
            if (mbtdal.Insert(mti)>0)
            {
                return true;
            }

            return false;
        }

        public bool Alert(MemberTypeInfo  mti)
        {

            if (mbtdal.Update(mti)>0)
            {
                return true;

            }
            return false;
        }

        public bool Remove(int index)
        {
            if (mbtdal.Delete(index)>0)
            {
                return true;
            }
            return false;
        }
    }
}