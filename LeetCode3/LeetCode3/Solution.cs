using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {


            /*          //This solution is with a nested loop, what is called Brute Force Approach

                        if (s == "") return 0;
                        int current = 1;
                        for (int i = 0; i < s.Length; i++)
                        {

                            for (int j = i+1; j <= s.Length; j++)
                            {                    
                                string check = s.Substring(i, (j-i));

                                if (check.GroupBy(x => x).Any(g => g.Count() > 1) == false)
                                {
                                    if (check.Length > current)
                                    { 
                                        current = check.Length;
                                    }
                                }
                            }
                        }
                        return current;
            */

            //Window Sliding Technique is a computational technique that aims to reduce the use of nested loops and replace it with a single loop, thereby reducing the time complexity.

            if (s == null || s.Length == 0) return 0;
            int i = 0;
            int j = 0;
            int max = 0;
            HashSet<char> current = new HashSet<char>();

            while (i < s.Length)
            {
                while (current.Contains(s[i]))
                {
                    current.Remove(s[j]);
                    j = j + 1;   
                }

                current.Add(s[i]);
                max = Math.Max(max, i - j + 1);
                i = i + 1;
            }
            return max;
        }
    }
}
