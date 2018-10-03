using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            return v1 + v2;
        }
    }
    public class Functions
    {
        public static string DoThis()
        {
            return "Result from DoThis";
        }
        public static string DoThat()
        {
            return "Result from DoThat";
        }
        public static string DoSomething(string something)
        {
            if (string.IsNullOrEmpty(something))
                throw new Exception("You need to specify something!");

            return "Result from doing: " + something;
        }
        public static int GetTheAnswerToLifeTheUniverseAndEverything()
        {
            return 42;
        }
        public class Binding
        {
            public void Exit()
            {
                Environment.Exit(1);
            }
            public void Call(int v)
            {
               if (v == 1)
                {
                    Console.WriteLine(GetTheAnswerToLifeTheUniverseAndEverything());
                    
                }
               else if (v == 2)
                {
                    double svar1 = double.Parse(Console.ReadLine());
                    double svar2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Calculator.Add(svar1, svar2));
                }

                
            }
        }
    }
}
