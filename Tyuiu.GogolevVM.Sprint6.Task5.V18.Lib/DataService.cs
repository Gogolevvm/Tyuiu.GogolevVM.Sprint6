using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GogolevVM.Sprint6.Task5.V18.Lib
{
    public class DataService : ISprint6Task5V18
    {
   
                    public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double element = Convert.ToDouble(line);
                    if (element % 1 != 0)
                    {
                        len++;
                    }
                }
            }
            double[] nums = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double element = Convert.ToDouble(line);
                    if (element % 1 != 0)
                    {
                        nums[index++] = element;
                    }
                }
            }

            return nums;
        }
    }
}
