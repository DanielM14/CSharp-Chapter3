using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            double nextYearSalary;
            double theNewSalary;

            Console.WriteLine("What is your yearly salary??");
            int userInputSalary = Convert.ToInt32(Console.ReadLine());

            nextYearSalary = userInputSalary * 0.04;

            Console.WriteLine("Your salary next year is " + nextYearSalary);

            theNewSalary = userInputSalary + nextYearSalary;

            Console.WriteLine("Your new salary for the new year is " + theNewSalary);

        }
    }
}
