using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        /*
         Input: nums = [2,7,11,15], target = 9
         Output: [0,1]
         Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
         */

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return new int[]{};
        }

        public int Compress(char[] chars)
        {

        }
    }
}
