using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Interface
    {
        public static bool quit = false;
        public static MathData GetAllValuesFromCustomer()
        {
            int first = GetValueFromUser("Podaj Pierwsza");
            int second = GetValueFromUser("Podaj druga");
            string operation = GetOperations ();
            return new MathData(first, second, operation);

        }

        public static int GetValueFromUser(string message)
        {

            int a = 0;
            bool isProper = false;
            while (!isProper)
            {
                Console.WriteLine(message);
                string x = Console.ReadLine();
                if (x == "q")
                {
                    quit = true;
                    return 0;
                }
                isProper = int.TryParse(x, out a);
                if (!isProper)
                {
                    message = $"Wartosc {x} spoza wartosci";
                }
            }
            return a;
            //if (!int.TryParse(x, out a))
            //{
            //    Console.WriteLine($"nie znana liczba {a}");
            //}
            //return a;
        }


        public static string GetOperations()
        {
            Console.WriteLine("Podaj rodzaj dzialania czyli : + albo - albo * albo / ");
            string operation = Console.ReadLine();
            if (operation == "q")
            {
                Console.WriteLine("zamykam aplikacje");
                Console.ReadKey();
               

            }
            return operation;
        }
    }
}
