using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathproblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Matek game";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            int answer1;
            int answer2;
            int answer3;

            Console.WriteLine("Üdv!");
            Console.WriteLine("");
            Console.WriteLine("23 * 4 + 7 =");
            answer1 = Convert.ToInt32( Console.ReadLine() );
            if (answer1 == 99)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("helyes!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("helytelen!");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            Console.WriteLine("43 + 9 * 11 =");
            answer2 = Convert.ToInt32( Console.ReadLine() );
            if (answer2 == 142)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("helyes!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("helytelen!");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            Console.WriteLine("15 * 8 + 63 =");
            answer3 = Convert.ToInt32( Console.ReadLine() );
            if (answer3 == 183)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("helyes!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("helytelen!");
            }
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Végeztél a játékkal!");
            Console.WriteLine("Nyomd le az enter-t a kilépéshez");

            Console.ReadLine();
        }
    }
}
