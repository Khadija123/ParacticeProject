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
    public class BCPatientRegistration
    {
        ErrorLog elog = new ErrorLog();
        DbManager dbm = new DbManager();



      public int PatientInsertion(ref ErrorLog elog, BCPropOfPatient obj)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(dbm.InParam("@patient_name", SqlDbType.VarChar, 50, obj.Pname));
            param.Add(dbm.InParam("@patient_fname", SqlDbType.VarChar, 50, obj.Pfname));
            param.Add(dbm.InParam("@patient_address", SqlDbType.VarChar, 150, obj.Paddress));
            param.Add(dbm.InParam("@patient_contactno", SqlDbType.VarChar, 50, obj.Pcontactno));
            param.Add(dbm.InParam("@patient_CNICno", SqlDbType.VarChar, 50, obj.Pcnic));
            param.Add(dbm.InParam("@patient_referencedBy", SqlDbType.VarChar, 50, obj.Prefencedby));
            param.Add(dbm.InParam("@create_date", SqlDbType.DateTime, 50, obj.CreateDate));
            param.Add(dbm.InParam("@create_user", SqlDbType.Int, 4, obj.Create_User));


            return dbm.Manage(ref elog, param, "sp_patientRegistrationInsertionn");
        }


    }
}
