namespace kyu.kyu6;

public static partial class kyu6
{
    /// <summary>
    /// Given an array of integers, find the one that appears an odd number of times.
    ///
    /// There will always be only one integer that appears an odd number of times.
    ///
    /// Examples
    ///     [7] should return 7, because it occurs 1 time (which is odd).
    ///     [0] should return 0, because it occurs 1 time (which is odd).
    ///     [1,1,2] should return 2, because it occurs 1 time (which is odd).
    ///     [0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
    ///     [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
    /// 
    /// Category
    ///    FUNDAMENTALS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/54da5a58ea159efa38000836
    /// </summary>
    public static int FindTheOddInt(int[] seq)
    {
        Dictionary<int, int> intCountDict = new Dictionary<int, int>();
        foreach (var item in seq)
        {
            if (!intCountDict.ContainsKey(item))
                intCountDict.Add(item, 1);
            else
                intCountDict[item]++;
        }
        return intCountDict.LastOrDefault(kvp => kvp.Value % 2 != 0, new KeyValuePair<int, int>(-1, 1)).Key;
    }
}