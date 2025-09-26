using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.VostrAE.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            value = value.Replace(",", "");
            value = value.Replace("!", "");
            value = value.Replace("?", "");
            value = value.Replace(";", "");
            value = value.Replace("-", "");

            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length % 2 == 1 && word.Length > 1)
                {
                    int middle = word.Length / 2;
                    words[i] = word.Remove(middle, 1);
                }
            }
            return string.Join(" ", words);
        }
    }
}
