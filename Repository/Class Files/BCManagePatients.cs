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
    class BCManagePatients
    {
        ErrorLog elog = new ErrorLog();
        DbManager dbm = new DbManager();



        public DataSet fillingPatient()
        {
            return dbm.GetDS(ref elog, null, "sp_patientview");

        }





    }
}
