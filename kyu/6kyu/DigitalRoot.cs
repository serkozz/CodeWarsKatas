namespace kyu.kyu6;

public static partial class kyu6
{
    /// <summary>
    /// Digital root is the recursive sum of all the digits in a number.
    /// 
    /// Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.
    ///
    /// Examples
    ///     16  -->  1 + 6 = 7
    ///     942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
    ///     132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
    ///     493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
    /// 
    /// Category
    ///    MATHEMATICS ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/541c8630095125aba6000c00
    /// </summary>
    public static int DigitalRoot(long n)
    {
        long remainder = n;
        long sum = 0;

        while (true)
        {
            sum += remainder % 10;
            remainder = remainder / 10;
            if (remainder == 0)
            {
                if (sum / 10 == 0)
                    break;
                remainder = sum;
                sum = 0;
            }
        }
        return (int)sum;
    }
}