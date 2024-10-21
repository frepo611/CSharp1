using System;
using System.Threading;

class Program
{
    static int gridSize = 5; // Storleken på spelplanen
    static char[,] grid = new char[gridSize, gridSize];
    static Random random = new Random();
    static int thiefX, thiefY, policeX, policeY, citizenX, citizenY;
    static bool hasStolenItem = false;

    static void Main(string[] args)
    {
        InitializeGame();
        Console.WriteLine("Välkommen till Tjuv, Polis och Medborgare!");

        while (true)
        {
            PrintGrid();
            MoveCharacters();
            CheckForActions();

            Thread.Sleep(1000); // Vänta 1 sekund innan nästa rörelse
        }
    }

    static void InitializeGame()
    {
        // Initiera spelplanen och placera tjuven, polisen och medborgaren
        thiefX = random.Next(gridSize);
        thiefY = random.Next(gridSize);
        policeX = random.Next(gridSize);
        policeY = random.Next(gridSize);
        citizenX = random.Next(gridSize);
        citizenY = random.Next(gridSize);

        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                grid[i, j] = '.';
            }
        }

        grid[thiefX, thiefY] = 'T'; // Tjuv
        grid[policeX, policeY] = 'P'; // Polis
        grid[citizenX, citizenY] = 'C'; // Medborgare
    }

    static void PrintGrid()
    {
        Console.Clear();
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tjuv (T), Polis (P), Medborgare (C)");
    }

    static void MoveCharacters()
    {
        MoveCharacter(ref thiefX, ref thiefY, 'T');
        MoveCharacter(ref policeX, ref policeY, 'P');
    }

    static void MoveCharacter(ref int x, ref int y, char character)
    {
        grid[x, y] = '.'; // Ta bort karaktären från sin nuvarande position
        int direction = random.Next(4); // 0: upp, 1: ner, 2: vänster, 3: höger

        switch (direction)
        {
            case 0: // Upp
                if (x > 0) x--;
                break;
            case 1: // Ner
                if (x < gridSize - 1) x++;
                break;
            case 2: // Vänster
                if (y > 0) y--;
                break;
            case 3: // Höger
                if (y < gridSize - 1) y++;
                break;
        }

        grid[x, y] = character; // Placera karaktären på sin nya position
    }

    static void CheckForActions()
    {
        // Kolla om tjuven är på samma plats som medborgaren
        if (thiefX == citizenX && thiefY == citizenY && !hasStolenItem)
        {
            hasStolenItem = true; // Tjuven stjäl från medborgaren
            Console.WriteLine("Tjuven har stulit från medborgaren!");
        }

        // Kolla om polisen är på samma plats som tjuven
        if (policeX == thiefX && policeY == thiefY && hasStolenItem)
        {
            Console.WriteLine("Polisen har arresterat tjuven!");
            hasStolenItem = false; // Tjuven blir arresterad
            InitializeGame(); // Starta om spelet
        }
    }
}