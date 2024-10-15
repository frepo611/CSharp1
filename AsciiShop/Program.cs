namespace AsciiShop;

internal class Program
{
    static void Main(string[] args)
    {
        char[,] drawing = new char[10, 15];
        int[] cursor = new int[2];
        string metadata = String.Empty;
        bool loopAgain = true;
        char marker = 'X';
        while (loopAgain)
        {
            Console.Clear();
            Helpers.Draw(drawing, cursor, metadata, marker);
            Helpers.DrawMenu();

            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Spacebar:
                    drawing[cursor[0], cursor[1]] = marker;
                    break;
                case ConsoleKey.E:
                    Console.Write("Ange tecken: ");
                    ConsoleKeyInfo markerKI = Console.ReadKey(true);
                    marker = markerKI.KeyChar;
                    break;
                case ConsoleKey.A: cursor[1]--; break;
                case ConsoleKey.D: cursor[1]++; break;
                case ConsoleKey.W: cursor[0]--; break;
                case ConsoleKey.S: cursor[0]++; break;
                case ConsoleKey.F:
                    string filename;
                    do
                    {
                        Console.Write("Sparar som (filnamn): ");
                        filename = Console.ReadLine();
                    } while (string.IsNullOrEmpty(filename));   
                    
                    Helpers.FileSave(drawing, filename);
                    (drawing, metadata) = Helpers.FileLoad(drawing, filename);
                    break;
                case ConsoleKey.V:
                    do
                    {
                        Console.Write("Ladda från (filnamn): ");
                        filename = Console.ReadLine(); 
                    } while (string.IsNullOrEmpty(filename));
                    
                    (drawing,metadata) = Helpers.FileLoad(drawing, filename);
                    break;
                case ConsoleKey.Q:
                    loopAgain = false;
                    break;
            }
        }
    }


}