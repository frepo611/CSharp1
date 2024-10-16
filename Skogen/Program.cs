using Skogen;
using System.Net.Quic;
using static Skogen.Animal;

Animal wolf1 = new Animal(Species.Vargen);
Animal wolf2 = new Animal(Species.Vargen);
Animal bat1 = new Animal(Species.Fladdermusen);
Animal doplhin = new Animal(Species.Delfinen);
Animal eagle = new Animal(Species.Ugglan);
Animal horse = new Animal(Species.Hästen);


List<Animal> forest = new List<Animal>();
forest.Add(wolf1);
forest.Add(wolf2);
forest.Add(bat1);
forest.Add(doplhin);
forest.Add(eagle);
forest.Add(horse);

bool isNight = false;
bool loopAgain = true;


do
{
    Console.WriteLine("Vad gör djuren?\n");
    Console.WriteLine("Är det dag eller natt i skogen? (D/N)?");
    bool validKey = false;
    do
    {
        var pressedKey = Console.ReadKey(true);
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
    } while (validKey == false);
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

} while (loopAgain);