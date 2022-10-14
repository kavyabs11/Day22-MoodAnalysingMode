﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day22_MoodAnalysingMode
{
    public class MoodAnalyserReflection
    {
        public MoodAnalyserReflection()
        {
        }
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Your input is not valid");
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }
                catch (Exception)
                {
                    Console.WriteLine("Something wrong happened.");
                }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
            return null;
        }
    }
}