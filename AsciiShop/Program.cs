namespace AsciiShop;

internal class Program
{
    static void Main(string[] args)
    {
        string[,] drawing = new string[10, 15];
        // drawing[3, 3] = "Z";
        int[] cursor = new int[2];
        while (true)
        {
            Console.Clear();
            Helpers.Draw(drawing, cursor);

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.KeyChar)
            {
                //case 'x': size++; break;
                case 'e':
                    Console.Write("Ange tecken: ");
                    drawing[cursor[0], cursor[1]] = Console.ReadLine();
                    break;
                case 'a': cursor[1]--; break;
                case 'd': cursor[1]++; break;
                case 'w': cursor[0]--; break;
                case 's': cursor[0]++; break;
                case 'f':
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