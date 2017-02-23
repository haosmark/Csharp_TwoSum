/* 
 * Problem description: Given an array of integers, return indices of the two numbers such that 
 * they add up to a specific target.
 * 
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
*/

using System;
using System.Collections.Generic;

namespace Two_Sum
{
    class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            // solve the problem by passing through the array and saving it into the hashtable
            // as the data is saved, check for the balance to see if a solution has been found

            // numbers are keys, and their indexes are values within the hashtable
            Dictionary<int, int> bucket = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                int balance = target - nums[i];
                // if hashtable has the needed balance, then these indexes are the solution
                if (bucket.ContainsKey(balance))
                {
                    return new int[] { bucket[balance], i };
                }

                if (!bucket.ContainsKey(nums[i]))
                {
                    bucket.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
