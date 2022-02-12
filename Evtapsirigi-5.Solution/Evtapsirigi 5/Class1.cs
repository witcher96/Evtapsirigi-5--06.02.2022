using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evtapsirigi_5
{
    public class Class1
    {
        public static int ReadInteger(string mesage)
        {

        l1:
            Console.Write(mesage);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string alpha = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            int c;


            try
            {

                c = Convert.ToInt32(alpha);
                return c;

            }
            catch
            {
                PrintError("Bad data :(");
                goto l1;
            }

        }

        public static double ReadDouble(string mesage)
        {

        l1:
            Console.Write(mesage);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string alpha = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            double c;


            try
            {

                c = Convert.ToDouble(alpha);
                return c;

            }
            catch
            {
                PrintError("Bad data :(");
                goto l1;
            }

        }

        public static double Kvadrat(double c)
        {
            double cavab = c * c;
            return cavab;
        }

        public static void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
