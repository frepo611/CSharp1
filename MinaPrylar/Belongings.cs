namespace MinaPrylar;

class Belongings
{
    private List<Car> _myCars;
    private List<Kid> _myKids;
    private Pet _myPet;

    public Belongings(List<Car> myCars, Pet myPet, List<Kid> myKids)
    {
        _myCars = myCars;
        _myPet = myPet;
        _myKids = myKids;
    }

    public void CreateStuff()
    {
        ;
    }
        
    public void Show()
    {
        Console.WriteLine("Det här är mina prylar:");
        foreach (var item in _myCars)
        {
            Console.WriteLine($"En {item.GetColor().ToLower()} {item.GetBrand()}");
        }
        foreach (var item in _myKids)
        {
            Console.WriteLine($"Ett barn som heter {item.GetName()} och är {item.GetAge()} år gammal");
        }
        Console.WriteLine($"Sen har jag {_myPet.GetName()}, en {_myPet.GetSpecies()}, som är {_myPet.GetDescription()}");
    }
}
