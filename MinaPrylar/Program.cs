namespace MinaPrylar;

public class Program
{
    static void Main(string[] args)
    {
        var myCars = new Cars();
        var myPets = new Pets();
        var myKids = new Kids();

        var minApp = new App(myCars, myPets, myKids);
        minApp.Run();
    }
}
