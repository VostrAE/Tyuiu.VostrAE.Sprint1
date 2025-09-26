using Tyuiu.VostrAE.Sprint1.Task6.V10.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Введите слова:");
        string text = Console.ReadLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.DeleteMiddleLetter(text));
        Console.ReadKey();
    }
}


