using System;
using Tyuiu.VostrAE.Sprint1.Task1.V16.Lib;
namespace Tyuiu.VostrAE.Sprint1.Task0.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Вострых А.Е. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                              *");
            Console.WriteLine("* Выполнил: Вострых Александр Евгеньевич | РППб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение x*5*a+2*y               *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            double x,a, y;
            Console.WriteLine("ВВедите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВВедите значение a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВВедите значение y:");
            y = Convert.ToDouble(Console.ReadLine());





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, a, y));
            Console.ReadLine();
        }
    }
}
