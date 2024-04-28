using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutate
{
    public class PermutateClass
    {
        public List<string> AllPermutations(string str)
        {
            var results = new List<string>();
            PermuteHelper(str, 0, results);
            return results.Distinct().ToList();
        }

        private static void PermuteHelper(string str, int index, List<string> results)
        {
            if (index >= str.Length)
            {
                results.Add(str);
                return;
            }

            for (int i = index; i < str.Length; i++)
            {
                char[] chars = str.ToCharArray();
                Swap(ref chars, index, i);
                PermuteHelper(new string(chars), index + 1, results); 
                Swap(ref chars, index, i);
            }
        }

        private static void Swap(ref char[] chars, int i, int j)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
    }
}
