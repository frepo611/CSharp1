namespace MinaPrylar;

public class Program
{
    static void Main(string[] args)
    {   
        var myCars = new List<Car>();
        var myKids = new List<Kid>();
        var myPet = new Pet();

        var minApp = new App(myCars, myPet, myKids);
        minApp.Run();
    }
}
