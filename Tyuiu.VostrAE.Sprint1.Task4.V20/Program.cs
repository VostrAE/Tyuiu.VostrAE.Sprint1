using Tyuiu.VostrAE.Sprint1.Task4.V20.Lib;
class Program{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        int x, y;
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите значение x:                                                      *");
        y = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine(" Введите значение y:                                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("1+x/|x-(2+y)^0.5| = " + ds.Calculate(x, y));
        Console.ReadKey();
    }
}
