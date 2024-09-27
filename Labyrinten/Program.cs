


Console.CursorVisible = false;

int boardSize = 3;
bool drawAgain = true;
(int,int) playerStartPosition = GenerateRandomCoord(boardSize);
(int,int) treasureStartPosition = GenerateRandomCoord(boardSize);

while (playerStartPosition == treasureStartPosition)
{
    treasureStartPosition = GenerateRandomCoord(boardSize);
}

bool firstTurn = true;
do
{
    Console.WriteLine(
    "Welcome to the grid.\nPress 'x' to increase the size\nPress 'z' to decrease the size\nPress 'q' to quit");
    Console.WriteLine();
    
    int origoY = 7;
    int origoX = 2;

    int dx = 0;
    int dy = 0;
    DrawGrid(boardSize);
    DrawAt('X', treasureStartPosition, origoX, origoY);
    if (firstTurn)
    {
        playerPosition = playerStartPosition;
        firstTurn = false;
    }


    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
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
    (int, int) playerPosition = ;
    DrawAt('P', playerPosition, origoX, origoY);
    Console.Clear();
} while (drawAgain);

void DrawAt(char thing, (int, int) coords, int origoX, int origoY)
{
    int cellCoord_x = coords.Item1;
    int cellCoord_y = coords.Item2;
    int cellSize = 4;
    Console.SetCursorPosition(origoX + cellCoord_x * cellSize, origoY + cellCoord_y*cellSize);
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

static (int,int) GenerateRandomCoord(int boardSize)
{
    var random = new Random();
    return (random.Next(0,boardSize), random.Next(0, boardSize));
}