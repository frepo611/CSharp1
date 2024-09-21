int boardSize = 4;

// Draw upper border
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
Console.ReadLine();

