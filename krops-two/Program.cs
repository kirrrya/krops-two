using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krops_two
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int p = 3;
                Console.WriteLine("Решите уравнение");
                Console.WriteLine("Найдем число K: введите число t");
                double t = double.Parse(Console.ReadLine());
                Console.WriteLine("Число p равно");
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту (H):");
                double H = double.Parse(Console.ReadLine());
                double S = t * p;
                Console.WriteLine("Площадь трапеции:{0:F2}", S);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
