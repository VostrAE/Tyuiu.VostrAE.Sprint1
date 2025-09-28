using Tyuiu.VostrAE.Sprint1.Task7.V8.Lib;
class Program
{
    static void Main(string[] args) {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("                      y                                                    ");
        Console.WriteLine("     z= x*ln(x)+------------                                               ");
        Console.WriteLine("                cos(x)-(x/3)                                               ");

        Console.WriteLine("Введите значение x:");
        double x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение y:");
        double y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadKey();



    }
}
