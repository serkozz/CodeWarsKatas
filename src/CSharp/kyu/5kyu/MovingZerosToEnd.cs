namespace kyu.Kyu5;

public static partial class Kyu5
{
    /// <summary>
    /// Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
    ///
    ///     Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
    ///
    /// Category
    ///    ARRAYS SORTING ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/52597aa56021e91c93000cb0
    /// </summary>
    public static int[] MoveZeroes_Mine(int[] arr)
    {
        int zerosCount = default;
        List<int> result = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
                result.Add(arr[i]);
            else
                zerosCount++;
        }
        for (int i = 0; i < zerosCount; i++)
        {
            result.Add(0);
        }
        return result.ToArray();
    }

    public static int[] MoveZeroes_MostPopular(int[] arr)
    {
        return arr.OrderBy(x => x == 0).ToArray();
    }
}