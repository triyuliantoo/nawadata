using System;

namespace nawadata1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input one of line words: ");
            string words = Console.ReadLine().ToLower();
            var charsToRemove = new string[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            foreach (var c in charsToRemove)
            {
                words = words.Replace(c, string.Empty);
            }
            char[] sortedT = words.ToCharArray();
            Array.Sort(sortedT);
            Console.WriteLine(sortedT);
        }
    }
}
