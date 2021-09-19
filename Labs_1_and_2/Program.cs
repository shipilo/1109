using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_1_and_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упаржнение 2.1");
            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, {0}!", name);

            Console.WriteLine("\nУпаржнение 2.2");
            Console.Write("Число 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} / {1} = {2}", num1, num2, Convert.ToDouble(num1) / Convert.ToDouble(num2));

            Console.WriteLine("\nДомашнее задание 2.1");
            Console.Write("Введите букву: ");
            char let = Convert.ToChar(Console.ReadLine());
            if (let == 'z' || let == 'я') Console.WriteLine("За буквой {0}, следует буква {1}", let, "a");
            else Console.WriteLine("За буквой {0}, следует буква {1}", let, ++let);
            
            Console.WriteLine("\nДомашнее задание 2.1");
            Console.Write("a = ");
            double a = Read();
            Console.Write("b = ");
            double b = Read();
            Console.Write("c = ");
            double c = Read();
            if (a != 0)
            {
                double D = b * b - 4 * a * c;
                if (D > 0) Console.WriteLine("x1 = {0}\nx2 = {1}", (-b + Math.Sqrt(D)) / 2 / a, (-b - Math.Sqrt(D)) / 2 / a);
                else if (D == 0) Console.WriteLine("x1 = x2 = {0}", -b / 2 / a);
                else Console.WriteLine("x1 = {0} + {1}i\nx2 = {0} - {1}i", -b / 2 / a, Math.Sqrt(-D) / 2 / a);
            }
            else Console.WriteLine("Это уравнение не квадратное!");

            Console.ReadLine();
        }
        static double Read()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
