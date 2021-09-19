using System;

namespace Lesson1
{
    class Program
    {        
        static void Main(string[] args)
        {            
            Random rnd = new Random();
            double r = Convert.ToDouble(rnd.Next(0, 1000)) / Convert.ToDouble(rnd.Next(0, 1000));
            int k = 1;

            double base1, base2, heigh, x1, x2, y1, y2, x3, y3, x4, y4, v1, v2, s;
            
            Console.WriteLine("s1.{0}", k++);
            Console.WriteLine("Точность до 2: {0:F2}, без сокращений: {0}", r);

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("Точность до 1: {0:F2}", Math.Exp(1));

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("Вы ввели число: {0}", Console.ReadLine());

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("{0} - вот такое число вы ввели", Console.ReadLine());

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("{0} {1} {2}", 1, 13, 19);

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("{0}  {1}  {2}", 7, 15, 100);

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("{0}  {1}  {2}", rnd.Next(0, 11), rnd.Next(0, 11), rnd.Next(0, 11));

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("{0} {1} {2} {3}", rnd.Next(0, 11), rnd.Next(0, 11), rnd.Next(0, 11), rnd.Next(0, 11));

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("15\n10");

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("5\n10\n21");

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", rnd.Next(0, 11), rnd.Next(0, 11), rnd.Next(0, 11), rnd.Next(0, 11));

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("5 10\n7 см");

            Console.WriteLine("\r\ns1.{0}", k++);
            Console.WriteLine("2 кг\n13 17");

            k = 1;

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("x = ");            
            double x_1 = Read();
            Console.WriteLine("y = {0}", 7 * x_1 * x_1 + 3 * x_1 + 6);
            Console.Write("a = ");
            double a_1 = Read();
            Console.WriteLine("x = {0}", 12 * a_1 * a_1 + 7 * a_1 + 12);

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Сторона квадрата: ");
            Console.WriteLine("Периметр = {0}", Read() * 4);

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Радиус: ");
            Console.WriteLine("Диаметр = {0}", Read() * 2);

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("h = ");
            Console.WriteLine("Расстояние GB = {0:F1}", 
                Math.Sqrt(Math.Pow(Read() + 6350.0, 2) - 6350*6350));

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Длина ребра куба: ");
            double len = Read();
            Console.WriteLine("Объём = {0:F1}", Math.Pow(len, 3));
            Console.WriteLine("Площадь боковой поверхности = {0:F1}", Math.Pow(len, 2) * 4);

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Радиус = ");
            double radius = Read();
            Console.WriteLine("Длина окружности = {0:F1}\n" + "Площадь кргуга = {1:F1}", radius * Math.PI, Math.Pow(radius, 2)*Math.PI);

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Введите 2 числа: ");
            double num1_1 = Read(), num2_1 = Read();
            Console.WriteLine("Среднее арифметическое = {0}\nСреднее геометрическое = {1:F2}", (num1_1 + num2_1) / 2, Math.Sqrt(num1_1 * num2_1));

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Объём: ");
            double volume = Read();
            Console.Write("Масса: ");
            double weight = Read();
            Console.WriteLine("Плотность = {0:F2}", volume / weight);

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Количество жителей: ");
            double number = Read();
            Console.Write("Площадь территории: ");
            double area = Read();
            Console.WriteLine("Плотность населения = {0:F2}", number / area);

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("а: ");
            double a_factor = Read();
            Console.Write("b: ");
            double b_factor = Read();
            Console.WriteLine("x = {0}", -b_factor / a_factor);
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Введите катеты: ");
            double cath1 = Read(), cath2 = Read();
            Console.WriteLine("Гиптотенуза = {0:F2}", Math.Sqrt(Math.Pow(cath1, 2) + Math.Pow(cath2, 2)));

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Радиус 1 = ");
            double r1 = Read();
            Console.Write("Радиус 2 = ");
            double r2 = Read();
            Console.WriteLine("Площадь кольца = {0:F2}", (r1 * r1 - r2 * r2) * Math.PI);


            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Введите катеты: ");
            cath1 = Read();
            cath2 = Read();
            Console.WriteLine("Периметр = {0:F2}", Math.Sqrt(Math.Pow(cath1, 2) + Math.Pow(cath2, 2)) + cath1 + cath2);

            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Введите 2 числа: ");
            double num1_2 = Math.Abs(Read()), num2_2 = Math.Abs(Read());
            Console.WriteLine("Среднее арифметическое их модулей = {0}\nСреднее геометрическое их модулей = {1:F2}", (num1_2 + num2_2) / 2, Math.Sqrt(num1_2 * num2_2));
                   
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Основания трапеции: ");
            base1 = Read();
            base2 = Read();
            Console.Write("Высота трапеции: ");
            heigh = Read();
            Console.WriteLine("Периметр трапеции = {0:F2}", Math.Sqrt(Math.Pow(Math.Abs(base1 - base2) / 2, 2) + heigh * heigh)*2 + base1 + base2);
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Введите стороны: ");
            double side1 = Read(), side2 = Read();
            Console.WriteLine("Периметр = {0}\nДлина диагонали = {1:F2}", (side1 + side2) * 2, Math.Sqrt(side1 * side1 + side2 * side2));
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Введите 2 числа: ");
            double num1_3 = Read(), num2_3 = Read();
            Console.WriteLine("Сумма = {0}\nРазность = {1}\nПроизведение = {2}\nЧастное = {3}", num1_3 + num2_3, num1_3 - num2_3, num1_3 * num2_3, num1_3 / num2_3);
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Длины сторон параллелепипеда: ");
            double a_3 = Read(), b_3 = Read(), c_3 = Read();
            Console.WriteLine("Объём = {0}\nПлощадь боковой поверхности = {1}", a_3 * b_3 * c_3, (a_3 * b_3 + a_3 * c_3) * 2);
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Координаты точек (в форме х1 у1 х2 y2): ");
            x1 = Read();
            y1 = Read();
            x2 = Read();
            y2 = Read();
            Console.WriteLine("Расстояние между точками = {0:F2}", Distance(x1, y1, x2, y2));
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.WriteLine("Дублирует S2.14., но я вычислю площадь");
            Console.Write("Основания трапеции: ");
            base1 = Read();
            base2 = Read();
            Console.Write("Высота трапеции: ");
            heigh = Read();
            Console.WriteLine("Площадь трапеции = " + ((base1 + base2) / 2 * heigh).ToString());
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Основания трапеции: ");
            base1 = Read();
            base2 = Read();
            Console.Write("Угол при большем основании: ");
            double deg = Read();
            Console.WriteLine("Площадь трапеции = {0:F2}", (base1 + base2) / 2 * Math.Abs(base1 - base2) / 2 * Math.Tan(deg / 180 * Math.PI));
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.WriteLine("Вершины треугольника: ");
            x1 = Read();
            y1 = Read();
            x2 = Read();
            y2 = Read();
            x3 = Read();
            y3 = Read();
            Console.WriteLine("Периметр треугольника = {0:F2}\nПлощадь треугольника = {1:F2}", Distance(x1, y1, x2, y2) + Distance(x2, y2, x3, y3) + Distance(x1, y1, x3, y3), AreaTreg(x1, y1, x2, y2, x3, y3));
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.WriteLine("Вершины четырёхугольника (вводить строго по порядку!): ");
            x1 = Read();
            y1 = Read();
            x2 = Read();
            y2 = Read();
            x3 = Read();
            y3 = Read();
            x4 = Read();
            y4 = Read();
            Console.WriteLine("Площадь = {0:F2}", AreaTreg(x1, y1, x2, y2, x4, y4) + AreaTreg(x2, y2, x3, y3, x4, y4));
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Количество конфет: ");
            double sweets_x = Read();
            Console.Write("Количество печенья: ");
            double cookies_y = Read();
            Console.Write("Количество яблок: ");
            double apples_z = Read();
            int sweets = rnd.Next(11), cookies = rnd.Next(11), apples = rnd.Next(11);
            Console.WriteLine("Общая стоимость покупки = {0}", sweets * sweets_x + cookies * cookies_y + apples * apples_z);
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Введите N - число компьютеров: ");
            double n = Read();
            int monitor = rnd.Next(11), sys = rnd.Next(11), key = rnd.Next(11), mouse = rnd.Next(11);
            Console.WriteLine("Стоимость 3 компьютеров = {0}\nСтоимость n компьютеров = {1}", 3 * (monitor + sys + key + mouse), n * (monitor + sys + key + mouse));
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("Возраст Тани: ");
            double age_t = Read();
            Console.Write("Возраст Мити: ");
            double age_m = Read();
            Console.WriteLine("Средний возраст = {0}\nОтклонение Тани = {1}\nОтклонение Мити = {1}", (age_t + age_m) / 2, Math.Abs(age_t - (age_t + age_m) / 2));
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.Write("V1 = ");
            v1 = Read();
            Console.Write("V2 = ");
            v2 = Read();
            Console.Write("S = ");
            s = Read();
            Console.WriteLine("Время встречи = {0} ч", s / (v1 + v2));
            
            Console.WriteLine("\r\ns2.{0}", k++);
            v1 = rnd.Next(50, 101);
            v2 = v1 - rnd.Next(1, 50);
            s = rnd.Next(200, 1000);
            Console.WriteLine("Расстояние между автомобилями через 30 мин = {0}, если S = {1}, V1 = {2}, V2 = {3}", s + (v1 - v2) * 0.5, s, v1, v2);
            
            Console.WriteLine("\r\ns2.{0}", k++);
            int cel = rnd.Next(-500, 500);
            Console.WriteLine("По шкале Цельсия: {0}\nПо шкале Фаренгейта: {1}\nПо шкале Кельвина: {2}", cel, 1.8 * cel + 32, cel + 273.15);
            
            Console.WriteLine("\r\ns2.{0}", k++);
            Console.WriteLine("450 по Фаренгейту - это {0:F2} по цельскию", (450-32)/1.8);
            
            //s3.1
            int value1 = rnd.Next(100);
            int value2 = rnd.Next(100);
            int inter_value = value1;
            value1 = value2;
            value2 = inter_value;

            //s3.2 а)
            int value_a = rnd.Next(100);
            int value_b = rnd.Next(100);
            int value_c = rnd.Next(100);
            int inter_value1 = value_b;
            int inter_value2 = value_a;
            value_b = value_c;
            value_a = inter_value1;
            value_c = inter_value2;
            //s3.2 б)
            value_a = rnd.Next(100);
            value_b = rnd.Next(100);
            value_c = rnd.Next(100);
            inter_value1 = value_b;
            inter_value2 = value_c;
            value_b = value_a;
            value_c = inter_value1;
            value_a = inter_value2;

            //s3.3
            int a = rnd.Next(1, 50);
            int a2, a3, a4, a5, a6, a7, a8, a9, a10, a12, a13, a16, a20, a17, a19, a28;
            Console.WriteLine("\na = {0}", a);
            //а
            a2 = a * a;
            a4 = a2 * a2; 
            //б
            a2 = a * a;
            a6 = a2 * a2 * a2;
            //в
            a2 = a * a;
            a7 = a2 * a2 * a2 * a;
            //г
            a2 = a * a; 
            a4 = a2 * a2;
            a8 = a4 * a4;
            //д
            a4 = a * a * a;
            a9 = a4 * a4 * a4;
            //е
            a2 = a * a; 
            a4 = a2 * a2;
            a10 = a4 * a4 * a2;

            //s3.4
            //а
            a = 2;
            a2 = a * a;
            a3 = a2 * a;
            a5 = a3 * a2;
            a10 = a5 * a5;
            //б
            a2 = a * a;
            a4 = a2 * a2;
            a8 = a4 * a4;
            a16 = a8 * a8;
            a20 = a16 * a4;
            //в
            a2 = a * a;
            a3 = a2 * a;
            a5 = a2 * a3;
            a13 = a5 * a5 * a3;
            //г (разве можно получить а19 за 5 операций?)
            a2 = a * a;
            a4 = a2 * a2;
            a5 = a4 * a;
            a19 = a5 * a5 * a5 * a4;
            //д
            a2 = a * a;
            a3 = a2 * a;
            a5 = a3 * a2;
            a17 = a5 * a5 * a5 * a2;
            //е
            a2 = a * a;
            a4 = a2 * a2;
            a8 = a4 * a4;
            a12 = a8 * a4;
            a28 = a12 * a12 * a4;

            //s3.5
            double ten = 10;
            double ten2 = ten * ten;
            double ten4 = ten2 * ten2;
            Console.WriteLine("\n10^10 = {0}", ten4 * ten4 * ten2);


            Console.ReadLine();
        }

        static double Read()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        static double AreaTreg(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) / 2;
        }        
    }
}
