
namespace MinaPrylar;

class Belongings
{
    private List<Car>? _myCars;
    private List<Kid>? _myKids;
    private Pet? _myPet;

    public Belongings(List<Car> myCars, Pet myPet, List<Kid> myKids)
    {
        _myCars = myCars;
        _myPet = myPet;
        _myKids = myKids;
    }

    public Belongings()
    {
        _myCars = CarsFromConsole();
        _myPet = PetFromConsole();
        _myKids = KidsFromConsole();
    }

    private List<Kid>? KidsFromConsole()
    {
        var kids = new List<Kid>();
        int noOfKids = ConsoleUI.GetInt("Hur många barn har jag? ");
        for (int i = 0; i < noOfKids; i++)
        {
            Console.Write($"Vad är barn {i+1}:s namn? ");
            string name = StringHelpers.FirstCharCapitalized(Console.ReadLine());
            int age = ConsoleUI.GetInt($"Hur gammal är {name}? ");
            kids.Add(new Kid(name, age));
        }
        return kids;
    }

    private Pet? PetFromConsole()
    {
            Console.Write($"Vad har jag för husdjur? ");
            string petSpecies = Console.ReadLine();
            Console.Write($"Vad heter min {petSpecies}? ");
            string petName = Console.ReadLine();
            Console.Write($"Beskriv {petName}: ");
            string petDescription = Console.ReadLine();
        ;
        return new Pet(petName, petDescription, petSpecies); ;
    }

    private List<Car>? CarsFromConsole()
    {
        var cars = new List<Car>();
        int noOfCars = ConsoleUI.GetInt("Hur många bilar har jag? ");
        for (int i = 0; i < noOfCars; i++)
        {
            Console.Write($"Vad är bil {i + 1} för märke? ");
            string carBrand = Console.ReadLine();
            Console.Write($"Vilken färg har min {carBrand}? ");
            string carColor = Console.ReadLine();
            cars.Add(new Car(carBrand, carColor));
        }
        return cars;
    }


    public void Show()
    {
        Console.WriteLine("Det här är mina prylar:");
        foreach (var item in _myCars)
        {
            Console.WriteLine($"En {item.GetColor().ToLower()} {item.GetBrand()}");
        }
        foreach (Kid? item in _myKids)
        {
            Console.WriteLine($"Ett barn som heter {item.GetName()} och är {item.GetAge()} år gammal");
        }
        Console.WriteLine($"Sen har jag {_myPet.GetName()}, en {_myPet.GetSpecies()}, som är {_myPet.GetDescription()}");
    }
}
