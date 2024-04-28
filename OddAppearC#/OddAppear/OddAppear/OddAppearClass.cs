using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAppear
{
    public class OddAppearClass
    {
        public int FindOddAppear(int[] arr)
        {
            var elementCounts = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                if (elementCounts.ContainsKey(num))
                {
                    elementCounts[num]++;
                }
                else
                {
                    elementCounts.Add(num, 1);
                }
            }

            foreach (var keyValuePair in elementCounts)
            {
                if (keyValuePair.Value % 2 != 0)
                {
                    return keyValuePair.Key;
                }
            }

            return -1;
        }
    }
}
