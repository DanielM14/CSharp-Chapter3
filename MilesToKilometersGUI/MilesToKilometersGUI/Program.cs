using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometersGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double userInput = Convert.ToInt32(Console.ReadLine());
            double kilo;

            kilo = userInput * 1.6;

            Console.WriteLine("The amount of kilometers " + kilo);
            





        }
    }
}
