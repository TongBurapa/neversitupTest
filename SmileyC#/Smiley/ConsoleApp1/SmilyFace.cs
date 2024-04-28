using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Smileface
{
    public class SmilyFaceFunction
    {
        public int SmileyCheck(string[] input)
        {
            int output = 0;
            foreach (string str in input)
            {
                if (str.Length > 2)
                {
                    string pattern = @"^[:;]\s*(.*?[-~]\s*.*?)\s*[D)]$";
                    Regex reg = new Regex(pattern);
                    Match match = reg.Match(str);
                    if (match.Success)
                    {
                        output++;
                    }
                }
                else
                {
                    string pattern = @"^[:;]\s*(.*?)\s*[D)]$";
                    Regex reg = new Regex(pattern);
                    Match match = reg.Match(str);
                    if (match.Success)
                    {
                        output++;
                    }
                }
            }
            return output;
        }
    }
}
