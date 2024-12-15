public static class GameOfLife
{
    public static void Play()
    {
        bool[,] cur = new bool[3, 3]
        {
            {false, true, false},
            {false, true, false},
            {false, true, false}
        };

        bool[,]? next;

        while (true)
        {
            next = NextIteration(cur);
            Draw(next);
            cur = CloneField(next);
            Thread.Sleep(250);
        }

        static void Draw(bool[,] next)
        {
            for (int i = 0; i < next.GetLength(0); i++)
            {
                for (int j = 0; j < next.GetLength(1); j++)
                {
                    Console.Write(next[i, j] ? "*" : "-");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public static bool[,] NextIteration(bool[,] currentIter)
    {
        var size = currentIter.GetLength(0);

        if (size != currentIter.GetLength(1))
            throw new ArgumentException("Not square field detected");

        var nextIter = CloneField(currentIter);

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                var count = GetNeighborsCount(currentIter, row, col);

                if (count == 3 && !currentIter[row, col])
                    nextIter[row, col] = true;
                else if (count == 2 || count == 3 && currentIter[row, col])
                    continue;
                else if (count > 3 && currentIter[row, col])
                    nextIter[row, col] = false;
                else if (count < 2 && currentIter[row, col])
                    nextIter[row, col] = false;
            }
        }
        return nextIter;
    }

    public static bool[,] CloneField(bool[,] field)
    {
        var nextIter = new bool[field.GetLength(0), field.GetLength(1)];

        // Clone
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                nextIter[i, j] = field[i, j];
            }
        }
        return nextIter;
    }

    private static byte GetNeighborsCount(bool[,] field, int rowPos, int colPos)
    {
        List<(int, int)> xYOffsets = new List<(int, int)>()
        {
            (-1, -1),
            (-1, 0),
            (-1, 1),
            (0, -1),
            (0, 1),
            (1, -1),
            (1, 0),
            (1, 1),
        };
        byte neighbors = 0;

        foreach (var off in xYOffsets)
        {
            try
            {
                if (field[rowPos + off.Item1, colPos + off.Item2])
                    neighbors++;
            }
            catch { }
        }
        return neighbors;
    }
}