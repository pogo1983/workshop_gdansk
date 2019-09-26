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
            int sum = a + b;
            Console.WriteLine("Suma to " + sum);
            Console.ReadLine();
            Console.ReadKey();//roznica miedzy line, ze kazdy przycisk zamknie

        }
    }
}
