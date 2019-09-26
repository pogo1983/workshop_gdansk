using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Podaj pierewsza liczbe ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe ");
            int b = int.Parse(Console.ReadLine());
            int sum = Add(a,b);
            int sum1 = Sub(a, b);
            int sum2 = Multilpy(a, b);
            double sum3 = Division(a, b);

            Console.WriteLine("Suma to " + sum + " Odejmowanie to " + sum1 + " Monzenie to " + sum2 + " Dzielenie to " + sum3);
            Console.ReadLine();
            Console.ReadKey();//roznica miedzy line, ze kazdy przycisk zamknie

        }


        public static int Add(int a , int b)
        {
            int sum = a + b;
            return sum;
        }

        public static int Sub(int a, int b)
        {
            int sum = a - b;
            return sum;
        }

        public static int Multilpy(int a, int b)
        {
            int sum = a * b;
            return sum;
        }

        public static double Division(double a, double b)
        {
            double sum = a / b;
            return sum;
        }

    }
}
