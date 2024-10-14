using System.Text;

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
        string metaData = $"{fileName}|{DateTime.Now}";
        File.WriteAllText(fileName,metaData);
        List<string> drawingAsList = Convert2DStringArrayToList(drawing);
        File.AppendAllLines(fileName, drawingAsList);
    }
    internal static List<string> Convert2DStringArrayToList(string[,] array)
    {
        List<string> stringList = new();
        string blankSpace = " ";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            StringBuilder sb = new();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sb.Append(string.IsNullOrEmpty(array[i, j]) ? blankSpace :  array[i, j]);
            }
            stringList.Add(sb.ToString());
        }
        return stringList;
    }
    internal static string[,] FileLoad(string fileName)
    {
        // Övning: Skapa laddningsfunktion
        return null;
    }
}   
