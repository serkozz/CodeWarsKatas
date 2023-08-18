namespace kyu.kyu6;

public static partial class kyu6
{
    /// <summary>
    /// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
    /// It should remove all values from list a, which are present in list b keeping their order.
    /// 
    ///     Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
    /// 
    /// If a value is present in b, all of its occurrences must be removed from the other:
    /// 
    ///     Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
    /// 
    /// Category
    ///    ARRAYS FUNDAMENTALS ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/523f5d21c841566fde000009
    /// </summary>
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        List<int> aList = a.ToList();
        foreach (var bItem in b)
        {
            if (aList.Contains(bItem))
                aList.RemoveAll(aItem => aItem == bItem);
        }
        return aList.ToArray();
    }
}