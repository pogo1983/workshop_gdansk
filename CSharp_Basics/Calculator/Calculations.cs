using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculations
    {
        public static double DoMath(MathData mathData)
        {
        //    return DoMath(mathData.FirstNumber,mathData.SecondNumber,mathData.Operation);
        //}
        //public static double DoMath(int a, int b, string operation)
        //{



            double sum = 0;
            ////switch
            switch (mathData.Operation)
            {
                case "+":
                    sum = Add(mathData.FirstNumber,mathData.SecondNumber);
                    break;
                case "-":
                    sum = Sub(mathData.FirstNumber, mathData.SecondNumber);
                    break;
                case "x":
                case "*":
                    sum = Multilpy(mathData.FirstNumber, mathData.SecondNumber);
                    break;
                case "/":
                    if (mathData.SecondNumber == 0)
                    {
                        Console.WriteLine("nie dzielimy przez 0");
                        break;
                    }
                    sum = Division(mathData.FirstNumber, mathData.SecondNumber);
                    break;
                default:
                    Console.WriteLine("nie znaleziono");
                    break;
            }
            return sum;
        }

       

        private static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        private static int Sub(int a, int b)
        {
            int sum = a - b;
            return sum;
        }

        private static int Multilpy(int a, int b)
        {
            int sum = a * b;
            return sum;
        }

        private static double Division(double a, double b)
        {
            double sum = a / b;
            return sum;
        }

    }
}
