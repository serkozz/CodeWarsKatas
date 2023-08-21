namespace kyu.Kyu5;

public static partial class Kyu5
{
    /// <summary>
    /// Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
    ///
    /// Examples
    ///     Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
    ///     Kata.PigIt("Hello world !");     // elloHay orldway !
    /// 
    /// Category
    ///    REGULAR EXPRESSIONS ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/520b9d2ad5c005041100000f
    /// </summary>
    public static string PigIt_Mine(string str)
    {
        var words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length == 1 && char.IsPunctuation(words[i][0]))
                continue;
            var tempFirstChar = words[i][0];
            var tempWord = words[i][1..words[i].Length];
            words[i] = tempWord + tempFirstChar + "ay";
        }
        return string.Join(' ', words);
    }

    public static string PigIt_MostPopular(string str)
    {
        return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
    }
}