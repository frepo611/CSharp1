

int boardSize = 3;

bool drawAgain = true;
do
{
    Console.WriteLine(
    "Welcome to the grid.\nPress 'x' to increase the size\nPress 'z' to decrease the size\nPress 'q' to quit");
    Console.WriteLine();

    DrawGrid(boardSize);

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