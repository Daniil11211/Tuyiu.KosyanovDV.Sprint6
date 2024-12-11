using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tuyiu.KosyanovDV.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (var line in File.ReadLines(path))
            {
                var words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length >= 2)
                {
                    sb.Append(words[words.Length - 2] + " ");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
