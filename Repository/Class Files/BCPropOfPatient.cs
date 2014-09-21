using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Class_Files
{
    public class BCPropOfPatient
    {

        public string Pname { get; set; }
        public string Pfname { get; set; }
        public string Paddress { get; set; }
        public string Pcontactno { get; set; }
        public string Pcnic { get; set; }
        public string Prefencedby { get; set; }
        public DateTime CreateDate { get; set; }
        public int Create_User { get; set; }
    }
}
