namespace kyu.Kyu4;

public static partial class Kyu4
{
    /// <summary>
    /// Next bigger number with the same digits
    /// Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:
    ///
    /// 12 ==> 21
    /// 513 ==> 531
    /// 2017 ==> 2071
    /// If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift, None in Rust):
    ///
    /// 9 ==> -1
    /// 111 ==> -1
    /// 531 ==> -1
    /// 
    /// Category
    ///    STRINGS REFACTORING
    /// 
    /// Link
    ///     https://www.codewars.com/kata/55983863da40caa2c900004e
    /// </summary>
    public static long NextBiggerNumber(long n)
    {
        List<string> combinations = new();
        GetAllCombinations(n.ToString().ToCharArray(), in combinations);
        if (combinations.Count == 1)
            return -1;
        return combinations.Select(long.Parse).Except(new List<long>() { n }).Where(val => val >= n).Min();
    }

    /// TIMEOUT ISSUE (More than 12s execution time in test suite on site)
    private static void GetAllCombinations<T>(IList<T> arr, in List<string> combinations, string current = "")
    {
        if (arr.Count == 0) //если все элементы использованы, выводим на консоль получившуюся строку и возвращаемся
        {
            combinations.Add(current);
            return;
        }
        for (int i = 0; i < arr.Count; i++) //в цикле для каждого элемента прибавляем его к итоговой строке, создаем новый список из оставшихся элементов, и вызываем эту же функцию рекурсивно с новыми параметрами.
        {
            List<T> lst = new List<T>(arr);
            lst.RemoveAt(i);
            GetAllCombinations(lst, in combinations, current + arr[i]!.ToString());
        }
    }
}