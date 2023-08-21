namespace kyu.Kyu6;

public static partial class Kyu6
{
    /// <summary>
    /// A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
    ///
    /// Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
    /// 
    /// Category
    ///    STRINGS DATA STRUCTURES FUNDAMENTALS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/545cedaa9943f7fe7b000048
    /// </summary>
    public static bool IsPangram(string str)
    {
        str = str.ToUpper();
        List<char> alphabet = new List<char>() {'A', 'B', 'C', 'D', 'E', 'F',
            'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
            'V', 'W', 'X', 'Y', 'Z'};
        List<char> meetedChars = new List<char>();

        foreach (var ch in str)
        {
            if (Char.IsLetter(ch) && !meetedChars.Contains(ch))
                meetedChars.Add(ch);
        }

        if (meetedChars.Count() == alphabet.Count())
            return true;

        return false;
    }
}