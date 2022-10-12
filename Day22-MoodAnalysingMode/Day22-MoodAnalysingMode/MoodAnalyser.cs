﻿using System;
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
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new Exception("Mood should not be empty");
                }
                else if (this.message.ToUpper().Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (Exception obj)
            {

                Console.WriteLine(obj.Message);
            }
            return "HAPPY";
        }
    }
}



