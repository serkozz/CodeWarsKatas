namespace kyu.Kyu6;

public static partial class Kyu6
{
    /// <summary>
    /// Johnny is a farmer and he annually holds a beet farmers convention "Drop the beet".
    ///
    /// Every year he takes photos of farmers handshaking. Johnny knows that no two farmers handshake more than once. He also knows that some of the possible handshake combinations may not happen.
    ///
    /// However, Johnny would like to know the minimal amount of people that participated this year just by counting all the handshakes.
    ///
    /// Help Johnny by writing a function, that takes the amount of handshakes and returns the minimal amount of people needed to perform these handshakes (a pair of farmers handshake only once).
    /// 
    /// Category
    ///    ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/5574835e3e404a0bed00001b
    /// </summary>
    public static int GetParticipants(int handshakes)
    {
        if (handshakes == 0)
            return 0;
        var x1 = (1 + Math.Sqrt(1 + 8 * handshakes))/2;
        var x2 = (1 - Math.Sqrt(1 + 8 * handshakes))/2;
        return x1 > 0 ? (int)Math.Ceiling(x1) : (int)Math.Ceiling(x2); 
    }
}