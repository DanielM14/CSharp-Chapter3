using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the temp in fahrenheit");
            int userTemp = Convert.ToInt32(Console.ReadLine());

            int cel = (userTemp - 32) * 5 / 9;

            Console.WriteLine("The temp in celsius is " + cel);
        }
    }
}
