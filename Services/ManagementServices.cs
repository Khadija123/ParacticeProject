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

        public int PatientInsertionServices(ref ErrorLog elog, BCPropOfPatient objPropOfPatient)
        {
            BCPatientRegistration objPR = new BCPatientRegistration();
            return objPR.PatientInsertion(ref elog, objPropOfPatient);
        }
        #endregion
        public DataSet FillingGridviewOfAllPatientRecord(ref ErrorLog elog)
        {
            BCManagePatients mp = new BCManagePatients();
            return mp.fillingGV(ref elog);
        }
       
        public int SchedulePatientServices(ref ErrorLog elog, BCscheduleProperties objP)
        {
            BCschedule objpp = new BCschedule();
            return objpp.schedulePatients(ref elog, objP);
        }

        public int signedupservices (SignedUser userr, ref ErrorLog elog)
        {
            BCsignedUP obj = new BCsignedUP();
            return obj.userSigningUP(ref elog, userr.Sfirstname, userr.Slastname, userr.Semail, userr.Spasswaord,userr.SUsername);
        }
    }
}
