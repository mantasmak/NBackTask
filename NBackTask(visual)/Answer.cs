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
        public Boolean Correct { get; set; }
        public long TimeDuration { get; set; }

        public Answer(Boolean value, Boolean correct, long time)
        {
            Value = value;
            Correct = correct; 
            TimeDuration = time;
        }

        override public String ToString()
        {
            if (Value == true && Correct == true)
                return "T - " + "Teisingai";
            else if (Value == true && Correct == false)
                return "T - " + "Neteisingai";
            else if (Value == false && Correct == true)
                return "N - " + "Teisingai";
            else
                return "N - " + "Neteisingai";
        }
    }
}
