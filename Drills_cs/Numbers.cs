using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drills_cs
{
    public class Numbers
    {
        private int int1, int2;

        public Numbers()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Smart Application c; \n");
            Console.WriteLine("Enter A Numbers:");

            int1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another Numer:");
            int2 = Convert.ToInt32(Console.ReadLine());
        }

        private static void ThreadSleep()
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }


        public void Calculate()
        {
            if (int1 == int2)
            {
                Console.WriteLine("{0} and {1} are numbers. Game Over!\n" +
                "Press 'K' to try again and install malware . . . ", int1, int2);
                while (Console.ReadKey(false).Key == ConsoleKey.K)
                {
                    // Do something
                    Console.WriteLine("DONT PUSH K");
                }
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal. \n" +
                "You aren't very good at this are you?" + "\n" +
                "Press 'K' to try again and install malware . . . ", int1, int2);
                if (Console.ReadKey(false).Key == ConsoleKey.K)
                {
                    // Do something
                    Console.WriteLine("DONT PUSH K");
                    while (Console.ReadKey(false).Key != ConsoleKey.K)
                    {
                        Console.ReadKey(false);
                        Console.WriteLine("No, you have to push 'K'!");
                    }
                }
            }
        }
    }
}
