namespace AsciiShop;

internal class Program
{
    static void Main(string[] args)
    {
        string[,] drawing = new string[10, 15];
        int[] cursor = new int[2];
        while (true)
        {
            Console.Clear();
            Helpers.Draw(drawing, cursor);

            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.E:
                    Console.Write("Ange tecken: ");
                    ConsoleKeyInfo mark = Console.ReadKey(true);
                    drawing[cursor[0], cursor[1]] = mark.KeyChar.ToString();
                    break;
                case ConsoleKey.A: cursor[1]--; break;
                case ConsoleKey.D: cursor[1]++; break;
                case ConsoleKey.W: cursor[0]--; break;
                case ConsoleKey.S: cursor[0]++; break;
                case ConsoleKey.F:
                    Console.Write("Filnamn: ");
                    string filename = Console.ReadLine();
                    Helpers.FileSave(drawing, filename);
                    break;
                    //case 'l':
                    //    Console.Write("Filnamn: ");
                    //    string filename = Console.ReadLine();
                    //    Helpers.FileLoad(drawing, filename);
                    //    break;

            }



            // cursor = Helpers.ReadKeyboard(cursor);
        }
    }


}