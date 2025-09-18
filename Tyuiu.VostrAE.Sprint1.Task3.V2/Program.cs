using Tyuiu.VostrAE.Sprint1.Task3.V2.Lib;

class Program
{static void Main(string[] args) { 
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Вострых А.Е. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Вострых Александр Евгеньевич | РППб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу,которая запрашивает у пользователя исходные данные,  *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Введите цену тетради:                                                    *");
        Console.WriteLine("***************************************************************************");
        double priceNotebook;
        priceNotebook = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите количество тетрадей:                                             *");
        Console.WriteLine("***************************************************************************");
        int amountNotebook;
        amountNotebook = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите цену карандаша:                                                  *");
        Console.WriteLine("***************************************************************************");
        double pricePencil;
        pricePencil = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите количество карандашей:                                           *");
        Console.WriteLine("***************************************************************************");
        int amountPencil;
        amountPencil = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Стоимость покуски составляет " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));
        Console.ReadLine();
    }
}
