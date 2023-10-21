using System;

namespace Uppgift_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta");
            int VAL = int.Parse(Console.ReadLine());

            if( VAL == 1 )
            {
                Console.WriteLine("skriv in tal 1");
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("skriv in tal 2");
                int tal2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Det blir " + (tal1 - tal2));
                Console.ReadKey();
            }
            else if (VAL == 2)
            {
                Console.WriteLine("skriv in tal 1");
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("skriv in tal 2");
                int tal2 = int.Parse(Console.ReadLine());
                if (tal2 == 0)
                {
                    Console.WriteLine("Det blir oändligt");
                }
                else
                {
                    Console.WriteLine("Det blir " + (tal1 / tal2));
                }
                Console.ReadKey();
            }
        }
    }
}