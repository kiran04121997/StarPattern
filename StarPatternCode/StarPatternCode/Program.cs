using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternCode
{
    class StarPattern
    {
        public static void Main()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)   // to combine both make i<=4 and In inner for loop make j<=4
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
