using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.DashBoard
{
    public class clsLoginInfo
    {
        //public clsCompanyInfo CompanyInfo { get; set; }
        //public clsUserInfo UserInfo { get; set; }
        //public clsUserPermission UserPermission { get; set; }

        //public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AccountId { get; set; }
        public string BranchId { get; set; }
        public string Logout { get; set; }
        public string Logo { get; set; }
        public string HomeURL { get; set; }

        public string UserCategory { get; set; }
        public int UserId { get; set; }


        //clsCompanyInfo _CompanyInfo;
        //clsUserInfo _UserInfo;
        //clsUserPermission _UserPermission;
        public clsLoginInfo()
        {
        }
        //public clsLoginInfo(clsUserInfo ParamUserInfo, clsCompanyInfo ParamCompanyInfo)
        //{
        //    _UserInfo = ParamUserInfo;
        //    _CompanyInfo = ParamCompanyInfo;
        //    _UserPermission = new clsUserPermission();
        //}

    }
}
