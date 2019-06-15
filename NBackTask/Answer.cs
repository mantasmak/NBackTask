using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBackTask
{
    public class Answer
    {
        public Boolean Value { get; set; }
        public long TimeDuration { get; set; }

        public Answer(Boolean Value, long Time)
        {
            this.Value = Value;
            TimeDuration = Time;
        }

        override public String ToString()
        {
            if (Value == true)
                return "T - " + TimeDuration + "ms";
            else
                return "N - " + TimeDuration + "ms";
        }
    }
}
