namespace Tyuiu.GogolevVM.Sprint6.Task1.V0.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int endValue)
        {
            double[] valueArray;
            int len = (endValue - startValue) +1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= endValue; x++)
            {
                y = Math.Round(Math.Sin(x), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }

    }
}
