


int boardSize = 3;

bool drawAgain = true;
do
{
    Console.WriteLine(
    "Welcome to the grid.\nPress 'x' to increase the size\nPress 'z' to decrease the size\nPress 'q' to quit");
    Console.WriteLine();
    
    int origoY = 7;
    int origoX = 2;

    DrawGrid(boardSize);
    DrawAt('P', 1, 1, origoX, origoY);
    ConsoleKeyInfo pressedKey = Console.ReadKey();
    switch (pressedKey.KeyChar)
    {
        case 'x':
        case 'X':
            boardSize++;
            break;
        case 'z':
        case 'Z':
            boardSize--;
            break;
        case 'q':
        case 'Q':
            drawAgain = false;
            break;
        default:
            break;
    }
    Console.Clear();
} while (drawAgain);

void DrawAt(char thing, int x, int y, int origoX, int origoY)
{
    Console.SetCursorPosition(origoX + x*4, origoY + y*4);
    Console.Write(thing);
}

Console.WriteLine("Goodbye. Press Enter.");
Console.ReadLine();

static void DrawGrid(int boardSize)
{
    for (int i = 0; i < boardSize; i++)
    {

        for (int j = 0; j <= 4 * boardSize; j++)
        {
            Console.Write('x');
        }
        Console.WriteLine();

        for (int k = 0; k < 3; k++)
        {
            for (int l = 0; l <= boardSize; l++)
            {
                Console.Write("x   ");
            }
            Console.WriteLine();
        }
    }
    for (int j = 0; j <= 4 * boardSize; j++)
    {
        Console.Write('x');
    }
}