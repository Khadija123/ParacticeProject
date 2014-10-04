using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ErrorLogNet;
using DAL;


namespace Repository.Class_Files
{
    public class BCschedule
    {
        ErrorLog elog = new ErrorLog();
        DbManager dbm = new DbManager();

      
        public int schedulePatients(ref ErrorLog elog, BCscheduleProperties obj)
        {
              List<SqlParameter> param = new List<SqlParameter>();
              param.Add(dbm.InParam("@schedule_Day", SqlDbType.VarChar, 50, obj.schDay));
              param.Add(dbm.InParam("@schedule_Starting_Time", SqlDbType.DateTime, 8, obj.schStartingTime));
              param.Add(dbm.InParam("@schedule_CLosing_Time", SqlDbType.DateTime, 8, obj.schClosingTime));
              param.Add(dbm.InParam("@schedule_Effective_Date", SqlDbType.DateTime, 8, obj.schEffectiveDate));
              param.Add(dbm.InParam("@schedule_Expiry_Date ", SqlDbType.DateTime, 8, obj.schExpiryDate));
              param.Add(dbm.InParam("@schedule_approved_Bit", SqlDbType.Bit, 1, obj.schApprovedBit));
              param.Add(dbm.InParam("@schedule_Disable_Bit", SqlDbType.Bit, 1, obj.schDisableBit));
              param.Add(dbm.InParam("@schedule_Create_User", SqlDbType.Int, 4, obj.schCreateUser));
              param.Add(dbm.InParam("@schedule_Create_Date", SqlDbType.DateTime, 8, obj.schCreateDate));
              //param.Add(dbm.InParam("@schedule_Update_User", SqlDbType.Int, 4, obj.schUpdateUser));
              //param.Add(dbm.InParam("@schedule_Update_Date", SqlDbType.Bit, 1, obj.schUpdateDate));

              return dbm.Manage(ref elog, param, "sp_schedulePatients");

        }


        public DataSet fillingschedule(ref ErrorLog elog)
        {
            return dbm.GetDS(ref elog, null, "sp_selectschedule1");
        }


        public DataSet callScheduleDay(ref ErrorLog elog, BCscheduleProperties obj)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(dbm.InParam("@schedule_day", SqlDbType.VarChar, 50, obj.daysch));
            return dbm.GetDS(ref elog,param,"sp_scheduleday");
        }
    }
}
