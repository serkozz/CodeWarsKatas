namespace kyu.Kyu4;

public static partial class Kyu4
{
    /// <summary>
    /// In this kata we want to convert a string into an integer. The strings simply represent the numbers in words.
    ///
    /// Examples:
    ///
    /// "one" => 1
    /// "twenty" => 20
    /// "two hundred forty-six" => 246
    /// "seven hundred eighty-three thousand nine hundred and nineteen" => 783919
    /// Additional Notes:
    ///
    /// The minimum number is "zero" (inclusively)
    /// The maximum number, which must be supported is 1 million (inclusively)
    /// The "and" in e.g. "one hundred and twenty-four" is optional, in some cases it's present and in others it's not
    /// All tested numbers are valid, you don't need to validate them
    ///
    /// Category
    ///    PARSING STRINGS ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/525c7c5ab6aecef16e0001a5
    /// </summary>
    public static int ParseInt_Mine(string s)
    {
        string[] words = s.Replace('-', ' ').Split(' ');
        Dictionary<string, (int Scale, int Increment)> numwords = new();
        string[] units = new string[]
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven",
            "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
            "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"
        };
        string[] tens = new string[]
        {
            "twenty", "thirty","forty","fifty","sixty",
            "seventy", "eighty", "ninety",
        };
        string[] scales = new string[]
        {
            "hundred", "thousand", "million","billion"
        };

        numwords["and"] = (1, 0);

        for (int i = 0; i < units.Length - 1; i++)
        {
            numwords[units[i]] = (1, i);
        }

        for (int i = 0; i < tens.Length; i++)
        {
            numwords[tens[i]] = (1, (i + 2) * 10);
        }

        for (int i = 0; i < scales.Length; i++)
        {
            numwords[scales[i]] = ((int)Math.Pow(10d, i == 0 ? 2 : i * 3), 0);
        }

        int current = default;
        int result = default;
        foreach (var word in words)
        {
            if (!numwords.ContainsKey(word))
                throw new ArgumentException(@$"Invalid word: {word}");
            var (scale, increment) = numwords[word];
            current = current * scale + increment;
            if (scale > 100)
            {
                result += current;
                current = 0;
            }
        }
        return result + current;
    }

    public static int ParseInt_MostPopular(string s)
    {
        Dictionary<string, int> numbers = new Dictionary<string, int> { {"zero", 0 }, { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 }, { "five", 5 },
         { "six", 6 }, { "seven", 7 }, { "eight", 8 }, { "nine", 9 }, { "ten", 10 }, { "eleven", 11 }, { "twelve", 12 }, { "thirteen", 13 }, { "fourteen", 14  }, { "fifteen", 15 },
         { "sixteen", 16}, { "seventeen", 17 }, { "eighteen", 18 }, { "nineteen", 19 }, { "twenty", 20 }, { "thirty", 30 }, { "forty", 40 }, { "fifty", 50 },
         { "sixty", 60 }, { "seventy", 70 }, { "eighty", 80 }, { "ninety", 90 } };

        Dictionary<string, int> multipliers = new Dictionary<string, int> { { "hundred", 100 }, { "thousand", 1000 }, { "million", 1000000 } };
        s = s.Replace(" and ", " ").Replace("-", " ");
        int result = 0;
        var list = s.Split(' ');
        int multiplier = 1;
        for (int i = list.Length - 1; i >= 0; i--)
        {
            if (numbers.ContainsKey(list[i]))
                result += (numbers[list[i]] * multiplier);
            else if (multipliers.ContainsKey(list[i]))
            {
                if (multiplier < multipliers[list[i]])
                    multiplier = multipliers[list[i]];
                else
                    multiplier *= multipliers[list[i]];
            }
        }
        return result;
    }
}