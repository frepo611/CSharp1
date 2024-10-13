namespace AsciiShop;

internal class Helpers
{
    internal static void Draw(string[,] drawing, int[] cursor)
    {
        string frame = "#";

        for (int top = 0; top < drawing.GetLength(1) + 2; top++)
        {
            Console.Write(frame);
        }
        Console.WriteLine();


        for (int row = 0; row < drawing.GetLength(0); row++)
        {
            Console.Write(frame);
            for (int col = 0; col < drawing.GetLength(1); col++)
            {
                if (row == cursor[0] && col == cursor[1])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drawing[row, col] == null ? "_" : drawing[row, col]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(drawing[row, col] == null ? " " : drawing[row, col]);
                }

            }
            Console.Write(frame);
            Console.WriteLine();


        }

        for (int bottom = 0; bottom < drawing.GetLength(1) + 2; bottom++)
        {
            Console.Write(frame);
        }
        Console.WriteLine();
    }
    internal static void FileSave(string[,] drawing, string fileName)
    {
        // Övning Skapa filsparning

    }
    internal static string[,] FileLoad(string fileName)
    {
        // Övning: Skapa laddningsfunktion
        return null;
    }
}
