/* 
 * Problem description: Given an array of integers, return indices of the two numbers such that 
 * they add up to a specific target.
 * 
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
*/

using System;

namespace Two_Sum
{
    class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            // solve the problem by narrowing down the solution via indexes in a nested loop

            // array must be sorted in order for this solution to work
            // a copy of the original is needed to get the correct indexes back
            int[] numsCopy = new int[nums.Length];
            Array.Copy(nums, numsCopy, nums.Length);
            Array.Sort(nums);

            int j = nums.Length - 1;
            // index from the left
            for (int i = 0; i <= j; i++)
            {
                int sum = nums[i] + nums[j];

                // keep decreasing the right index until you find a sum that's lower or equal
                while (sum > target && j > i)
                {
                    j--;
                    sum = nums[i] + nums[j];
                }

                // if the target is found, then get the original indexes and return
                if (sum == target)
                {
                    int a = Array.IndexOf(numsCopy, nums[i]);
                    int b = Array.LastIndexOf(numsCopy, nums[j]);

                    // rearrange if needed
                    if (a > b)
                    {
                        int c = a;
                        a = b;
                        b = c;
                    }

                    return new int[] { a, b };
                }
            }

            return null;
        }
    }
}
