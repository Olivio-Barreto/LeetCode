using System.Collections.Generic;

namespace LeetCode.TwoSum;

public class Program
{
  static void Main(string[] args)
  {
    int[] nums = new int[] { 2, 7, 11, 15 };
    int target = 9;
    var array = TwoSum(nums, target);

    foreach (var item in array)
    {
      System.Console.WriteLine(item);
    }
  }


  static int[] TwoSum(int[] nums, int target)
  {
    var dict = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
      int complement = target - nums[i];

      if (dict.ContainsKey(complement))
      {
        return [dict[complement], i];
      }

      dict[nums[i]] = i; // valor -> índice
    }

    return new int[] { -1, -1 };
  }
}