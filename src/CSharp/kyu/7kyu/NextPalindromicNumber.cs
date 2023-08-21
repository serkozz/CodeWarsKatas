namespace kyu.Kyu7;

public static partial class Kyu7
{
    /// <summary>
    /// There were and still are many problem in CW about palindrome numbers and palindrome strings. We suposse that you know which kind of numbers they are. If not, you may search about them using your favourite search engine.
    ///
    /// In this kata you will be given a positive integer, val and you have to create the function next_pal()(nextPal Javascript) that will output the smallest palindrome number higher than val.
    ///
    /// Let's see:
    ///
    /// For C#
    ///     Kata.NextPal(11) == 22
    ///
    ///     Kata.NextPal(188) == 191
    ///
    ///     Kata.NextPal(191) == 202
    ///
    ///     Kata.NextPal(2541) == 2552
    /// You will be receiving values higher than 10, all valid.
    /// 
    /// Category
    ///    FUNDAMENTALS DATA STRUCTURES ALGORITHMS MATHEMATICS LOGIC STRINGS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/56a6ce697c05fb4667000029
    /// </summary>
    public static int NextPal(int val)
    {
        int num = val + 1;
        while (!IsNumberPolindrome(num))
        {
            num++;
        }
        return num;
    }

    public static bool IsNumberPolindrome(int num)
    {
        string direct = num.ToString();
        string reverse = Reverse(direct);
        return direct == reverse;
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}