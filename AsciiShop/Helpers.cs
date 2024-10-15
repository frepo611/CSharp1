using System.Text;

namespace AsciiShop;

internal class Helpers
{
    internal static void Draw(char[,] drawing, int[] cursor, string metaData, char marker)
    {
        if (!string.IsNullOrEmpty(metaData))
        {
            string filename = metaData.Split("|")[0];
            DateTime saveDate = DateTime.Parse(metaData.Split("|")[1]);
            Console.WriteLine($"Sparat i {filename:28} {saveDate}\n"); 
        }
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
                    Console.Write(drawing[row, col] == '\0' ? "_" : drawing[row, col]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(drawing[row, col] == '\0' ? " " : drawing[row, col]);
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
        Console.WriteLine($"Ritar med {marker}");
    }
    internal static void FileSave(char[,] drawing, string fileName)
    {
            string metaData = $"{fileName}|{DateTime.Now}";
            File.WriteAllText(fileName, metaData);
            List<string> drawingAsList = Convert2DCharArrayToList(drawing);
            File.AppendAllLines(fileName, drawingAsList);
    }
    internal static List<string> Convert2DCharArrayToList(char[,] array)
    {
        List<string> stringList = new();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            StringBuilder sb = new();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sb.Append(array[i, j]);
            }
            stringList.Add(sb.ToString());
        }
        return stringList;
    }
    internal static (char[,], string) FileLoad(char[,] canvas, string fileName)
    {
        string[] linesFromFile;
        string metaData = string.Empty;
        if (File.Exists(fileName))
        {
            linesFromFile = File.ReadLines(fileName).ToArray();
            bool wantToReadMetadata = true;
            for (int i = 0; i < linesFromFile.Length; i++)
            {
                if (wantToReadMetadata)
                {
                    metaData = linesFromFile[i];
                    wantToReadMetadata = false;
                }
                else
                {
                    for (int j = 0; j < linesFromFile[i].Length; j++)
                    {
                        canvas[i,j] = linesFromFile[i][j];
                    }
                }
            }
        }
        return (canvas, metaData);
    }

    internal static void DrawMenu()
    {
        Console.SetCursorPosition(20, 1);
        Console.Write("Flytta kursorn med WASD");
        Console.SetCursorPosition(20, 2);
        Console.Write("Tryck SPACE för att rita.");
        Console.SetCursorPosition(20, 3);
        Console.Write("Tryck E för att byta tecken att rita med.");
        Console.SetCursorPosition(20, 4);
        Console.Write("Tryck F för att spara teckningen.");
        Console.SetCursorPosition(20, 5);
        Console.Write("Tryck V för att ladda en teckning från en fil.");
        Console.SetCursorPosition(20, 6);
        Console.Write("Tryck Q för att avsluta.");

        Console.SetCursorPosition(0, 15);




    }
}   
