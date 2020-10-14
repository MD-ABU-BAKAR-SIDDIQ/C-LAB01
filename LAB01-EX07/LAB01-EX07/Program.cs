using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EX07
{
    class Program
    {
        static void Main(string[] args)
        {
            double heigth,width, area , perimeter ;
            Console.WriteLine("Enter heigth of rectangle : ");
            heigth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle : ");
            width = Convert.ToDouble(Console.ReadLine());
            area = heigth * width;
            perimeter = (2*( height + width ));
            Console.WriteLine("\nArea of rectangle: " + area);

            Console.WriteLine("\nperimeter of rectangle: " + perimeter);
            Console.ReadKey();
        }
    }
}
