using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drills_cs
{
    class Program
    {
        private int int1, int2;

        static void Main(string[] args)
        {
            Numbers A = new Numbers();
            A.Calculate();

            // Wait for Final User Input before closing.
            Console.ReadLine();
        }
    }
}
