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




            // int a = int.Parse(Console.ReadLine());
            int a = GetValueFromUser("Podaj Pierwsza liczbe");
            int b = GetValueFromUser("Podaj Druga liczbe");
            Console.WriteLine("Podaj rodzaj dzialania czyli : + albo - albo * albo / ");
            string operation = Console.ReadLine();
            var sum = DoMath(a, b, operation);
            Console.WriteLine(sum);
            //int sum = Add(a,b);
            //int sum1 = Sub(a, b);
            //int sum2 = Multilpy(a, b);
            //double sum3 = Division(a, b);
            //Console.WriteLine("Podaj rodzaj dzialania czyli : + albo - albo * albo / ");
            //string operation = Console.ReadLine();

            //double sum=0;
            //////switch
            //switch (operation)
            //{
            //    case "+":
            //        sum = Add(a, b);
            //        break;
            //    case "-":
            //        sum = Sub(a, b);
            //        break;
            //    case "x":
            //    case "*":
            //        sum = Multilpy(a, b);
            //        break;
            //    case "/":
            //        sum = Division(a, b);
            //        break;
            //    default:
            //        Console.WriteLine("nie znaleziono");
            //        break;
            //}

            //else if
            //if (operation == "-")
            //{
            //    sum = Sub(a, b);
            //}
            //else if (operation == "+")
            //{
            //    sum = Add(a, b);
            //}
            //else if (operation == "*")
            //{
            //    sum = Multilpy(a, b);
            //}
            //else if (operation == "/" )
            //{
            //    sum = Division(a, b);
            //}

            //else 
            //{
            //    Console.WriteLine("Error nie znalazlem dzialania");
            //}

            //Console.WriteLine("wynik to ");
            //Console.WriteLine(sum);

            //Console.WriteLine("Suma to " + sum + " Odejmowanie to " + sum1 + " Monzenie to " + sum2 + " Dzielenie to " + sum3);
            // Console.WriteLine($"Suma to "{ sum } ");
            Console.ReadLine();
            Console.ReadKey();//roznica miedzy line, ze kazdy przycisk zamknie

        }

        public static double DoMath (int a, int b, string operation)
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

        public static int GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            string x = Console.ReadLine();
            int a = 0;
            if (!int.TryParse(x, out a))
            {
                Console.WriteLine($"nie znana liczba {a}");
            }
            return a;
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
