using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            bool ConvertResult;
            do
            {
                Console.WriteLine("Введите коэффициент A");
                ConvertResult = double.TryParse(Console.ReadLine(), out a);
            } while (!ConvertResult);

            do
            {
                Console.WriteLine("Введите коэффициент B");
                ConvertResult = double.TryParse(Console.ReadLine(), out b);
            } while (!ConvertResult);


            do
            {
                Console.WriteLine("Введите коэффициент C");
                ConvertResult = double.TryParse(Console.ReadLine(), out c);
            } while (!ConvertResult);


            double d = b * b - 4 * a * c;
            Console.WriteLine("D = " + d);
            if (d < 0)
            {
                Console.WriteLine("Решений нет");
            }
            else
            {
                double sqrtD = Math.Sqrt(d);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);
            }

            Console.ReadLine(); 
        }
    }
}
