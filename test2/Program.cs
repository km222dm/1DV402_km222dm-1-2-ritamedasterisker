using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {

            //bestäm att den ska skriva ut 25 rader
            for (int row = 0; row < 25; row++)  // for-loop som skriver ut 25 rader.
            {

                Console.WriteLine();             // byter rad

                switch (row % 3)                // switch-sats som ska göra så att var tredje rad blir i färgen gul, var tredje magenta och var tredje grön
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }

                //bestämm att varannan rad ska vara indragen
                if (row % 2 != 1)               // varannan gång loopen går runt kommer denna uträkning att stämma i och med att vartannan uträkning blir 1,
                {
                    Console.Write(" ");         // därför kommer den skriva ut detta varannan gång.
                }

                //bestäm att den ska skriva ut 39 kolumner med "*"
                for (int column = 0; column < 39; column++)  // for-loop som skriver ut 39 kolumner med stjärnor.
                {

                    Console.Write("* ");
                }
            }
        }
    }
}
