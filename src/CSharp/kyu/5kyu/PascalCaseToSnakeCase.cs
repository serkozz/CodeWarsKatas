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
    public static string ToUnderscore(string str)
    {
        string res = string.Empty;
        for (var i = 0; i < str.Length; i++)
        {
            if (i >= 1 && char.IsUpper(str[i]) && char.IsLower(str[i - 1]))
                res += "_";
            res += char.ToLower(str[i]);
            if (char.IsDigit(str[i]))
                res += "_";
        }
        return res;
    }
}