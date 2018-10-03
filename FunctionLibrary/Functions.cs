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

        public static object Subtract(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public static object Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }

        public static double Sum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static double Minimum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static double Maximum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static object Average(double[] numbers)
        {
            throw new NotImplementedException();
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
            public void MultiCall(double m)
            {
                if (m == 1)
                {
                    Console.WriteLine(GetTheAnswerToLifeTheUniverseAndEverything());
                }
                else if (m == 2)
                {
                    double mm1 = double.Parse(Console.ReadLine());
                    double mm2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Calculator.Multiply(mm1, mm2));
                }
            }
            public void DivCall (double d)
            {
                if (d == 1)
                {
                    Console.WriteLine(GetTheAnswerToLifeTheUniverseAndEverything());
                }
                else if (d == 2)
                {
                    double dd1 = double.Parse(Console.ReadLine());
                    double dd2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Calculator.Divide(dd1, dd2));
                }
            }
        }
    }
}
