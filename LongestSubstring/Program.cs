using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(solution.LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(solution.LengthOfLongestSubstring("au"));
            Console.WriteLine(solution.LengthOfLongestSubstring("cdd"));
            Console.WriteLine(solution.LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(solution.LengthOfLongestSubstring("~!@#$%^&*()_+QWERTYUIOP{}ASDFGHJKL:ZXCVBNM<>?`1234567890-=qwertyuiop[]|asdfghjkl;'zxcvbnm,./"));
            Console.WriteLine(solution.LengthOfLongestSubstring("x"));
            Console.WriteLine(solution.LengthOfLongestSubstring("dvdf"));




        }
    }
}
