using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorLogNet;
using DAL;
using Repository.Class_Files;
using System.Data;

namespace Services
{
    public class ManagementServices
    {
        #region DECLARATIONS
        
        #endregion

        #region VERIFYING USERAME
        public DataSet VerfiyingUserServices(LoggedUser user, ref ErrorLog elog)
        {
            VerifyingUser obj = new VerifyingUser();
            return obj.UserAttentication(ref elog, user.USERNAME, user.PASSWORD);
        }
        #endregion
    }
}
