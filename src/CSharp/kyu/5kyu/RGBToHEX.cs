namespace kyu.Kyu5;

public static partial class Kyu5
{
    /// <summary>
    /// The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.
    ///
    /// Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
    ///
    /// Examples (input --> output):
    ///     255, 255, 255 --> "FFFFFF"
    ///     255, 255, 300 --> "FFFFFF"
    ///     0, 0, 0       --> "000000"
    ///     148, 0, 211   --> "9400D3"
    /// 
    /// Category
    ///    ALGORITHMS
    /// 
    /// Link
    ///     https://www.codewars.com/kata/513e08acc600c94f01000001
    /// </summary>
    public static string Rgb(int r, int g, int b)
    {
        int[] colorComponents = new int[3] { r, g, b };
        string redHexValue = string.Empty;
        string greenHexValue = string.Empty;
        string blueHexValue = string.Empty;

        for (int i = 0; i < colorComponents.Length; i++)
        {
            if (colorComponents[i] > 255)
                colorComponents[i] = 255;
            if (colorComponents[i] < 16)
            {
                if (colorComponents[i] < 0)
                    colorComponents[i] = 0;
                switch (i)
                {
                    case 0:
                        redHexValue += "0";
                        break;
                    case 1:
                        greenHexValue += "0";
                        break;
                    case 2:
                        blueHexValue += "0";
                        break;
                }
            }
        }
        redHexValue += colorComponents[0].ToString("X");
        greenHexValue += colorComponents[1].ToString("X");
        blueHexValue += colorComponents[2].ToString("X");
        return redHexValue + greenHexValue + blueHexValue;
    }
}