using Forest;

List<Animal> forest = [ new Animal(Species.Vargen),
                        new Animal(Species.Vargen),
                        new Animal(Species.Fladdermusen),
                        new Animal(Species.Delfinen),
                        new Animal(Species.Ugglan),
                        new Animal(Species.Hästen)];

bool isNight = false;
bool loopAgain = true;


while (loopAgain)
{
    Console.WriteLine("Vad gör djuren?\n");
    Console.WriteLine("Är det dag eller natt i skogen? (D/N)?");
    bool validKey = false;
    while (validKey == false)
    {
        ConsoleKeyInfo pressedKey= Console.ReadKey(true);
        switch (pressedKey.Key)
        {
            case ConsoleKey.D:
                isNight = false;
                validKey = true;
                break;
            case ConsoleKey.N:
                isNight = true;
                validKey = true;
                break;
            default:
                break;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Det är {(isNight ? "natt" : "dag")} i skogen.");
    foreach (var animal in forest)
    {
        animal.Activate(isNight);
    }
    Console.WriteLine();
    Console.WriteLine("Tryck Q för att avsluta");
    var pressedKey1 = Console.ReadKey(true);
    switch (pressedKey1.Key)
    {
        case ConsoleKey.Q:
            loopAgain = false;
            break;
        default:
            break;
    }
    Console.Clear();

}