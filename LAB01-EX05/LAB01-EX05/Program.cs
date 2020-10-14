using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the num1 :");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the num2 :");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;
            int rem = +num1 % num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
            Console.WriteLine($"The sub of {num1} and {num2} is {sub}");
            Console.WriteLine($"The mul of {num1} and {num2} is {mul}");
            Console.WriteLine($"The div of {num1} and {num2} is {div}");
            Console.WriteLine($"The rem of {num1} and {num2} is {rem}");
        }
    }
}
