namespace kyu.Kyu3;

public static partial class Kyu3
{
    /// <summary>
    /// Your task, is to create a NxN spiral with a given size.
    ///
    /// Category
    ///     ALGORITHMS ARRAYS LOGIC
    /// 
    /// Link
    ///     https://www.codewars.com/kata/534e01fbbb17187c7e0000c6
    /// </summary>
    public static int[,] Spiralize(int size)
    {
        if (size < 5) throw new ArgumentOutOfRangeException(nameof(size));
        int[,] result = new int[size, size];
        (int RowIndex, int ColumnIndex) lastPaintedIndex = (0, -1);
        PaintingDirection paintingDirection = PaintingDirection.LeftToRight;
        bool reduceStroke = false;
        int drawTime = 0;
        int strokeLength = size;

        for (int i = 1; i <= size; i++)
        {
            PaintStroke(result, ref strokeLength, ref reduceStroke, ref lastPaintedIndex, ref paintingDirection);
            if (i != 1)
                drawTime++;
            if (drawTime == 2)
            {
                drawTime = 0;
                reduceStroke = true;
            }
            Visualize(result);
        }


        return result;
    }

    private static void PaintStroke(int[,] spiral, ref int strokeLength, ref bool reduceStroke, ref (int RowIndex, int ColumnIndex) lastPaintedIndex, ref PaintingDirection paintingDirection)
    {
        // Reduce Stroke Length
        if (reduceStroke)
        {
            strokeLength--;
            reduceStroke = false;
        }
        if (spiral[0,0] == 0)
            reduceStroke = true;
        /// Paint Stroke
        for (int i = 0; i < strokeLength; i++)
        {
            if (paintingDirection == PaintingDirection.LeftToRight)
                lastPaintedIndex.ColumnIndex++;
            if (paintingDirection == PaintingDirection.RightToLeft)
                lastPaintedIndex.ColumnIndex--;
            if (paintingDirection == PaintingDirection.TopToBot)
                lastPaintedIndex.RowIndex++;
            if (paintingDirection == PaintingDirection.BotToTop)
                lastPaintedIndex.RowIndex--;
            spiral[lastPaintedIndex.RowIndex, lastPaintedIndex.ColumnIndex] = 1;
        }

        // Change Painting Direction
        if (paintingDirection == PaintingDirection.LeftToRight)
        {
            paintingDirection = PaintingDirection.TopToBot;
            return;
        }
        if (paintingDirection == PaintingDirection.TopToBot)
        {
            paintingDirection = PaintingDirection.RightToLeft;
            return;
        }
        if (paintingDirection == PaintingDirection.RightToLeft)
        {
            paintingDirection = PaintingDirection.BotToTop;
            return;
        }
        if (paintingDirection == PaintingDirection.BotToTop)
        {
            paintingDirection = PaintingDirection.LeftToRight;
            return;
        }

    }

    private static void Visualize(int[,] spiral)
    {
        string rowString = "";
        Console.WriteLine("----------");
        for (int row = 0; row < spiral.GetLength(0); row++)
        {
            for (int col = 0; col < spiral.GetLength(1); col++)
            {
                rowString += spiral[row, col].ToString();
            }
            Console.WriteLine(rowString);
            rowString = "";
        }
        Console.WriteLine("----------");
    }

    private enum PaintingDirection
    {
        LeftToRight,
        TopToBot,
        RightToLeft,
        BotToTop
    }
}