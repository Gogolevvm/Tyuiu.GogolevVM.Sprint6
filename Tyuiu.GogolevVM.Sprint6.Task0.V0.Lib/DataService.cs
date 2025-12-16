namespace Tyuiu.GogolevVM.Sprint6.Task0.V0.Lib
{
    public class DataService
    {
        public double Calculate(int a, int b, int c)
        {
            double res = ((double)a + (double)b) / (double)c;
            return Math.Round(res,3);
        }

    }
}
