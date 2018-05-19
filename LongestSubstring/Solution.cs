using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstring
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            
            // checking for null input
            if (s.Length == 0)
            {
                max = 0;
            }

            //checking for one letter input
            if (s.Length == 1)
            {
                max = 1;
            }

            string temp = "";
            int[] output = new int[s.Length];
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //if the letter is a repeat, delete up to repeat and then add it to temp, increase index
                if (temp.Contains(s[i]))
                {
                    index++;
                    int deleteIndex = temp.IndexOf(s[i])+1;
                    temp = temp.Remove(0,deleteIndex);
                }

                temp += s[i];
                output[index] = temp.Length;
            }

            if (s.Length > 1)
                max = output.Max();

            return max;
        }
    }
}
