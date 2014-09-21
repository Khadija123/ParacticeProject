using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorLogNet;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Class_Files
{
    public class VerifyingUser
    {
        #region DECLATIONS
        ErrorLog elog = new ErrorLog();
        DbManager dbm = new DbManager();
        
        #endregion
        #region PROPERTIES
        
        #endregion
        #region METHODS
        public DataSet UserAttentication(ref ErrorLog elog, string Username, String Password)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(dbm.InParam("@Username", SqlDbType.VarChar, 50, Username));
            param.Add(dbm.InParam("@Password", SqlDbType.VarChar, 50, Password));

            return dbm.GetDS(ref elog, param, "sp_VerfiyingUsers");
        }
        #endregion
    }
}
