/*
 AUTHOR: Gabriel Aquino
 DATE: 12/29/2022
 PURPOSE: https://leetcode.com/problems/two-sum/
 */
using TwoSum;

Solution mySolution= new Solution();
int[] result = mySolution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Array.ForEach(result, Console.WriteLine);
Console.WriteLine();

result = mySolution.TwoSum(new int[] { 3, 2, 4 }, 6);
Array.ForEach(result, Console.WriteLine);
Console.WriteLine();

result = mySolution.TwoSum(new int[] { 3, 3 }, 6);
Array.ForEach(result, Console.WriteLine);
Console.WriteLine();

result = mySolution.TwoSum(new int[] { 2, 5, 5, 11 }, 10);
Array.ForEach(result, Console.WriteLine);