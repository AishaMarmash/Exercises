using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercise2Application
{
    class Program
    {
        public static void Main()
        {
            var words = new string[] { "he", "she", "it", "we", "you", "they" };
            string word = GetTheLastWord(words);
            Console.WriteLine(word);
        }
        public static string GetTheLastWord(IEnumerable<string> words)
        {
            var query = words.Select(word => word).Where(word => word.Contains("e"))
                            .OrderBy(word => word).LastOrDefault();
            if (!string.IsNullOrEmpty(query))
                return $"The last word is {query}";
            else
                return null;
        }
    }
}
