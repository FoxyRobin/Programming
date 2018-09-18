using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1st number: ");
            float nr1 = float.Parse(Console.ReadLine());

            string input2;
            float nr2;
            Console.WriteLine("Enter 2nd number: ");
            input2 = Console.ReadLine();
            nr2 = float.Parse(input2);

            string input3;
            float nr3;
            Console.WriteLine("Enter 3rd number: ");
            input3 = Console.ReadLine();
            nr3 = float.Parse(input3);


            float total = nr1 + nr2 + nr3;
            float average = total / 3;

            Console.WriteLine("The average is: {0} ", average);

            Console.WriteLine(" ");

            Console.WriteLine("Enter a key to continue...");
            Console.ReadKey();

        }
    }
}
