namespace kyu.Kyu5;

public static partial class Kyu5
{
    /// <summary>
    /// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet.
    /// ROT13 is an example of the Caesar cipher.
    /// Create a function that takes a string and returns the string ciphered with Rot13.
    /// If there are numbers or special characters included in the string, they should be returned as they are.
    /// Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
    /// 
    /// Category
    ///    CIPHERS FUNDAMENTALS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/530e15517bc88ac656000716
    /// </summary>
    public static string Rot13(string message)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string encoded = String.Empty;
        foreach (var ch in message)
        {
            if (!char.IsLetter(ch))
            {
                encoded += ch;
                continue;
            }
            if (char.IsUpper(ch))
                encoded += Char.ToUpper(alphabet[(alphabet.LastIndexOf(char.ToLower(ch)) + 13) % alphabet.Length]);
            else encoded += alphabet[(alphabet.LastIndexOf(ch) + 13) % alphabet.Length];
        }
        return encoded;
    }

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