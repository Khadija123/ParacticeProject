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
    public class BCManagePatients
    {
        ErrorLog elog = new ErrorLog();
        DbManager dbm = new DbManager();

        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public string patient_name{ get; set; }

        public DataSet fillingPatient(ref ErrorLog elog)
        {

            List<SqlParameter> param = new List<SqlParameter>();
            //param.Add(dbm.InParam("@Name", SqlDbType.VarChar, 50, patient_name));
            param.Add(dbm.InParam("@Name", SqlDbType.VarChar, 50, patient_name));
            param.Add(dbm.InParam("@From_Date", SqlDbType.Date, 8, fromDate));
            param.Add(dbm.InParam("@To_Date", SqlDbType.Date, 8, toDate));
            return dbm.GetDS(ref elog, param, "ShowingPatientRecords");
        }

        public DataSet fillingGV(ref ErrorLog elog)
        {
            return dbm.GetDS(ref elog, null, "[sp_gvpatient]");
            
        }



    }
}
