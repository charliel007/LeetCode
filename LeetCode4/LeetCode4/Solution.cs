using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode4
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 = nums1.Concat(nums2).ToArray();

            Array.Sort(nums3);

            Array.ConvertAll<int, double>(nums3, x => x);

            var remainder = nums3.Length % 2;


            if (remainder == 0 )
            {
                int middle = nums3.Length / 2;
                double answer = (nums3[middle - 1] + nums3[middle]);
                answer = answer / 2;
                return Math.Round(answer, 6);
            }
            else
            {
                int middle = (nums3.Length + 1) / 2;
                double answer = (nums3[middle-1]);
                return Math.Round(answer, 6);
            }

        }

    }
}
