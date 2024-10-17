using Forest;

List<Animal> forest = [ new Animal(Species.Vargen),
                        new Animal(Species.Vargen),
                        new Animal(Species.Fladdermusen),
                        new Animal(Species.Delfinen),
                        new Animal(Species.Ugglan),
                        new Animal(Species.Hästen)];

bool isNight = false;
bool loopAgain = true;

ConsoleKeyInfo pressedKey;
while (loopAgain)
{
    Console.WriteLine("Vad gör djuren?\n");
    Console.WriteLine("Är det dag eller natt i skogen? (D/N)?");
    bool validKey = false;
    while (validKey == false)
    {
        pressedKey = Console.ReadKey(true);
        (isNight, validKey) = pressedKey.Key switch //switch expression
        {
            ConsoleKey.D => (false, true),
            ConsoleKey.N => (true, true),
            _ => (isNight, false) // Keep isNight unchanged, not a valid key
        };
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
    pressedKey = Console.ReadKey(true);

    loopAgain = pressedKey.Key switch
    {
        ConsoleKey.Q => false,
        _ => loopAgain
    };

    Console.Clear();

}
    