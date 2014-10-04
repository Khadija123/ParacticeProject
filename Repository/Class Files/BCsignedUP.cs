using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using ErrorLogNet;
using DAL;
using System.Data.SqlClient;

namespace Repository.Class_Files
{
    public class BCsignedUP
    {
        ErrorLog elog = new ErrorLog();
        DbManager dbm = new DbManager();


        public int userSigningUP(ref ErrorLog elog, string firstname, string lastname, string email, string password, string username)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(dbm.InParam("@firstname", SqlDbType.VarChar, 50, firstname));
            param.Add(dbm.InParam("@lastname", SqlDbType.VarChar, 50, lastname));
            param.Add(dbm.InParam("@email", SqlDbType.VarChar, 50, email));
            param.Add(dbm.InParam("@password", SqlDbType.VarChar, 50, password));
            param.Add(dbm.InParam("@Username", SqlDbType.VarChar, 50, username));

            return dbm.Manage(ref elog, param, "sp_signeduser");
        }
    }
}
