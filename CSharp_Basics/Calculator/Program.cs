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
            //int sum = Add(a,b);
            //int sum1 = Sub(a, b);
            //int sum2 = Multilpy(a, b);
            //double sum3 = Division(a, b);
            Console.WriteLine("Podaj rodzaj dzialania czyli : + albo - albo * albo / ");
            string operation = Console.ReadLine();

            double sum=0;
////switch
//            switch (operation)
//            {
//                case "+":sum = Add(a, b);
//                    break;
//                case "-":sum = Sub(a, b);
//                    break;
//                    case "x":
//                case "*":
//                    sum = Multilpy(a, b);
//                    break;
//                case "/":
//                    sum = Division(a, b);
//                    break;
//                default: Console.WriteLine("nie znaleziono");
//                    break;
//            }

//else if
            if (operation == "-")
            {
                sum = Sub(a, b);
            }
            else if (operation == "+")
            {
                sum = Add(a, b);
            }
            else if (operation == "*")
            {
                sum = Multilpy(a, b);
            }
            else if (operation == "/" && a!=0 && b!=0)
            {
                sum = Division(a, b);
            }

            else 
            {
                Console.WriteLine("Error nie znalazlem dzialania");
            }

            Console.WriteLine("wynik to ");
            Console.WriteLine(sum);

            //Console.WriteLine("Suma to " + sum + " Odejmowanie to " + sum1 + " Monzenie to " + sum2 + " Dzielenie to " + sum3);
            // Console.WriteLine($"Suma to "{ sum } ");
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
