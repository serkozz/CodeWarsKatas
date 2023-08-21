namespace kyu.Kyu5;

public static partial class Kyu5
{
    /// <summary>
    /// Complete the function/method so that it takes a PascalCase string and returns the string in snake_case notation.
    /// Lowercase characters can be numbers. If the method gets a number as input, it should return a string.
    /// 
    /// Examples
    ///    "TestController"  -->  "test_controller"
    ///    "MoviesAndBooks"  -->  "movies_and_books"
    ///    "App7Test"        -->  "app7_test"
    ///    1                 -->  "1"
    /// 
    /// Category
    ///    STRINGS ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/529b418d533b76924600085d
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