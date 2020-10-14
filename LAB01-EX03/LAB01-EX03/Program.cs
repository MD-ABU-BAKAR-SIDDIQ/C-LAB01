using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB01_EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numbers: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            double num2 = double.Parse(Console.ReadLine());
            double div = num1 / num2;
            Console.WriteLine($"The division of {num1} and {num2} is: {div}");
        }
    }
}
