namespace kyu.kyu6;

public static partial class kyu6
{
    /// <summary>
    /// Return the century of the input year. The input will always be a 4 digit string, so there is no need for validation.
    ///
    /// Examples
    ///     "1999" --> "20th"
    ///     "2011" --> "21st"
    ///     "2154" --> "22nd"
    ///     "2259" --> "23rd"
    ///     "1124" --> "12th"
    ///     "2000" --> "20th"
    /// 
    /// Category
    ///    STRINGS ALGORITHMS DATE TIME
    /// 
    /// Link
    ///     https://www.codewars.com/kata/52fb87703c1351ebd200081f
    /// </summary>
    public static string WhatCentury(string year)
    {
        double yearNumber = Double.Parse(year);
        double century = Math.Round(yearNumber / 100);

        if (yearNumber / 100 > century)
            century++;
        string ending = "th";

        if (century.ToString().EndsWith('1') & !century.ToString().StartsWith('1'))
            ending = "st";
        if (century.ToString().EndsWith('2') & !century.ToString().StartsWith('1'))
            ending = "nd";
        if (century.ToString().EndsWith('3') & !century.ToString().StartsWith('1'))
            ending = "rd";

        return century.ToString() + ending;
    }
}