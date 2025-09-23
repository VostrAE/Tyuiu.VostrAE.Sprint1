using Tyuiu.VostrAE.Sprint1.Task5.V6.Lib;
class Progaram
{
    static void Main(string[] args)
    { DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" Введите значение от 1 до 365:");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* В неделе этот день занимает место под номером:                          *");
        Console.WriteLine("***************************************************************************");

        int res = Convert.ToInt32(ds.Calculate(k));
        Console.WriteLine(res);
        

        Console.ReadKey();
    }
}