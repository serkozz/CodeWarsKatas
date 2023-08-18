namespace kyu.kyu6;

public static partial class kyu6
{
    /// <summary>
    /// Write a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in a tuple / list (depending on your language) like so: (index1, index2).
    ///
    /// For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.
    ///
    /// The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).
    ///
    /// Based on: http://oj.leetcode.com/problems/two-sum/
    ///
    ///     two_sum([1, 2, 3], 4) == {0, 2}
    /// 
    /// Category
    ///    ARRAYS FUNDAMENTALS ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/52c31f8e6605bcc646000082
    /// </summary>
    public static int[] TwoSum(int[] numbers, int target)
    {
        int first, second;
        for (int i = 0; i < numbers.Length; i++)
        {
            first = numbers[i];
            for (int k = 0; k < numbers.Length; k++)
            {
                second = numbers[k];
                if (first + second == target && i != k)
                    return new int[2] { i, k };
            }
        }
        return new int[0];
    }
}