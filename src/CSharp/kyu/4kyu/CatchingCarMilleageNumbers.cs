namespace kyu.Kyu4;

public static partial class Kyu4
{
    /// <summary>
    /// "Interesting" Numbers
    /// Interesting numbers are 3-or-more digit numbers that meet one or more of the following criteria:
    ///
    /// Any digit followed by all zeros: 100, 90000
    /// Every digit is the same number: 1111
    /// The digits are sequential, incementing†: 1234
    /// The digits are sequential, decrementing‡: 4321
    /// The digits are a palindrome: 1221 or 73837
    /// The digits match one of the values in the awesomePhrases array
    /// † For incrementing sequences, 0 should come after 9, and not before 1, as in 7890.
    /// ‡ For decrementing sequences, 0 should come after 1, and not before 9, as in 3210.
    ///
    /// So, you should expect these inputs and outputs:
    ///
    /// "boring" numbers
    ///     Kata.IsInteresting(3, new List<int>() { 1337, 256 });    // 0
    ///     Kata.IsInteresting(3236, new List<int>() { 1337, 256 }); // 0
    ///
    /// progress as we near an "interesting" number
    ///     Kata.IsInteresting(11207, new List<int>() { });   // 0
    ///     Kata.IsInteresting(11208, new List<int>() { });   // 0
    ///     Kata.IsInteresting(11209, new List<int>() { });   // 1
    ///     Kata.IsInteresting(11210, new List<int>() { });   // 1
    ///     Kata.IsInteresting(11211, new List<int>() { });   // 2
    ///
    /// nearing a provided "awesome phrase"
    ///     Kata.IsInteresting(1335, new List<int>() { 1337, 256 });   // 1
    ///     Kata.IsInteresting(1336, new List<int>() { 1337, 256 });   // 1
    ///     Kata.IsInteresting(1337, new List<int>() { 1337, 256 });   // 2
    ///
    /// Error Checking
    /// A number is only interesting if it is greater than 99!
    /// Input will always be an integer greater than 0, and less than 1,000,000,000.
    /// The awesomePhrases array will always be provided, and will always be an array, but may be empty. (Not everyone thinks numbers spell funny words...)
    /// You should only ever output 0, 1, or 2.
    /// 
    /// Category
    ///    ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/52c4dd683bfd3b434c000292
    /// </summary>
    public static int IsInteresting_Mine(int number, List<int> awesomePhrases)
    {
        if (number < 0 || number > 1_000_000_000)
            throw new ArgumentOutOfRangeException(nameof(number));
        if (number < 98)
            return 0;

        for (int i = 0; i < 3; i++)
        {
            if (awesomePhrases.Contains(number))
                return i == 0 ? 2 : 1;
            else if (AnyDigitFollowedByAllZeros(number))
                return i == 0 ? 2 : 1;
            else if (DigitsSequentialIncrementingOrDecrementing(number))
                return i == 0 ? 2 : 1;
            else if (IsNumberPalindrome(number))
                return i == 0 ? 2 : 1;
            number++;
        }
        return 0;
    }

    private static bool AnyDigitFollowedByAllZeros(int number)
    {
        string numberString = number.ToString();
        return numberString.Length >= 3 && numberString[0] != '0' && numberString[1..numberString.Length].All(c => c == '0');
    }

    private static bool DigitsSequentialIncrementingOrDecrementing(int number)
    {
        string sequentialIncrementing = "1234567890";
        string sequentialDecrementing = "9876543210";
        string numberString = number.ToString();
        return numberString.Length >= 3 && sequentialDecrementing.Contains(numberString) || sequentialIncrementing.Contains(numberString);
    }

    private static bool IsNumberPalindrome(int number)
    {
        string numberString = number.ToString();
        return numberString.Length >= 3 && numberString == string.Concat(numberString.Reverse());
    }

    public static int IsInteresting_MostPopular(int number, List<int> awesomePhrases)
    {
        return Enumerable.Range(number, 3)
          .Where(x => Interesting(x, awesomePhrases))
          .Select(x => (number - x + 4) / 2)
          .FirstOrDefault();
    }

    private static bool Interesting(int num, List<int> awesome)
    {
        if (num < 100) return false;
        var s = num.ToString();
        return awesome.Contains(num)
          || s.Skip(1).All(c => c == '0')
          || s.Skip(1).All(c => c == s[0])
          || "1234567890".Contains(s)
          || "9876543210".Contains(s)
          || s.SequenceEqual(s.Reverse());
    }
}