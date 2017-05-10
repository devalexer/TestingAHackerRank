using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAHackerRank
{
    public class Solution
    {
        public static string PangramSolution(string sentence)
        {
            var input = sentence.ToLower().Replace(" ", String.Empty);

            var characters = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (characters.ContainsKey(item))
                {
                    characters[item]++;
                }
                else
                {
                    characters.Add(item, 1);
                }
            }
            if (characters.Count() == 26)
            {
                return "pangram";
            }
            else
            {
                return "not pangram";
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}