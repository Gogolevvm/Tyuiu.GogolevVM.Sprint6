using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GogolevVM.Sprint6.Task6.V0.Lib
{
    public class DataService 
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            return resStr;
        }
    }
}
