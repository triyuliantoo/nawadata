using System;
using System.Text.RegularExpressions;

namespace nawadata2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of families: ");
            int fams = Int32.Parse(Console.ReadLine());

            Console.Write("Input the number of members in the family: ");
            string members = Console.ReadLine().ToLower();
            string trimmed = Regex.Replace(members, @"^[A-Za-z]+", "");
            string[] CountPassangers = trimmed.Split(' ');

            if(fams != CountPassangers.Length)
                Console.WriteLine("Input must be equal with count of family");
            else
            {
                decimal total = 0;
                foreach(var data in CountPassangers)
                {
                    total += Convert.ToInt32(data);
                }

                total /= 4;

                total = Math.Ceiling(total);

                Console.WriteLine(total);
            }
        }
    }
}
