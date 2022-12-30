using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 AUTHOR: Gabriel Aquino
 DATE: 12/29/2022
 PURPOSE: https://leetcode.com/problems/two-sum/
 */

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int indexNum1 = 0;
            int indexNum2 = 0;

            for (int i = 0; i < nums.Length -1; i++)
            {
                indexNum1 = i;
                for (int j = i+1; j < nums.Length; j++)
                {
                    indexNum2= j;
                    if (nums[i] + nums[j] == target)
                        return new int[] { indexNum1, indexNum2 };
                }                
            }
            return new int[0];
        }
    }
}
