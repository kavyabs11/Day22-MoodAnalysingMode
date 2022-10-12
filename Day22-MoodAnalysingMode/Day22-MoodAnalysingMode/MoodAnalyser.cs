using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_MoodAnalysingMode
{

    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser() //default constructor
        {
        }
        public MoodAnalyser(string message) //parameterized constructor
        {
            this.message = message;
        }
        public string analyseMood()
        {
            if (this.message.ToUpper().Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}


