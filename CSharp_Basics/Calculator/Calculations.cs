using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculations
    {
        public static double DoMath(int a, int b, string operation)
        {



            double sum = 0;
            ////switch
            switch (operation)
            {
                case "+":
                    sum = Add(a, b);
                    break;
                case "-":
                    sum = Sub(a, b);
                    break;
                case "x":
                case "*":
                    sum = Multilpy(a, b);
                    break;
                case "/":
                    sum = Division(a, b);
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
