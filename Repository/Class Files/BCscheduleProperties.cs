using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Class_Files
{
    public class BCscheduleProperties
    {
        public string schDay { get; set; }
        public DateTime schStartingTime { get; set; }
        public DateTime schClosingTime { get; set; }
        public DateTime schEffectiveDate { get; set; }
        public DateTime schExpiryDate { get; set; }
        public bool schApprovedBit { get; set; }
        public bool schDisableBit { get; set; }
        public int schCreateUser { get; set; }
        public DateTime schCreateDate { get; set; }
        public int schUpdateUser { get; set; }
        public DateTime schUpdateDate { get; set; }
        public string daysch { get; set; }
    }
}
