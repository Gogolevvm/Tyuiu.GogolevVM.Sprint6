using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GogolevVM.Sprint6.Task0.V22.Lib
{
    public class DataService : ISprint6Task0V22
    {
        public double Calculate(int x)
        {
            double res = 0.7 * x * x * x + 1.52 * x * x;
            return Math.Round(res,3);
        }
    }
}
