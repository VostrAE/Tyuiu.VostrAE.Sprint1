using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VostrAE.Sprint1.Task7.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            double numerator = y;
            double denominator = Math.Cos(x) - x / 3.0;
            double z = x * Math.Log(x) + numerator / denominator;
            double res = x * Math.Log(x)+y/Math.Cos(x)-x/3;
            return Math.Round(z,3);
        }
    }
}
