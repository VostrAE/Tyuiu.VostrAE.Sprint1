using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VostrAE.Sprint1.Task4.V20.Lib
{
    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            var res = (1 + x)/ Math.Abs((x-Math.Pow(2+y,0.5)));
            return res;
            
        }
    }
}
