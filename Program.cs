using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public  class MoodAnalyser
    {
        public string message;

        public  MoodAnalyser()
        {
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("HAPPY"))
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}
