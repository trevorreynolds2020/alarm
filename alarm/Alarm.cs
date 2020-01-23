using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alarm
{
    public class Alarm
    {
        private DateTime dateTime;
        private bool status;

        public DateTime time { get; set; }
        public bool on { get; set; }
        
        public Alarm(DateTime dateTime, bool on)
        {
            dateTime = this.dateTime;
            on = this.status;
        }
        public Alarm()
        {

        }
    }
}
