namespace MinaPrylar;

public class Program
{
    static void Main(string[] args)
    {   
        var myPet = new Pet("Bruno","snell hest", "häst");
        var myCars = new List<Car>();
        myCars.Add(new Car("Ferrari", "röd"));
        myCars.Add(new Car("Opel", "vit"));
        myCars.Add(new Car("BMW", "svart"));

        var amanda = new Kid("Amanda", 8);
        var louise = new Kid("Louise", 8);
        var twins = new List<Kid>();
        twins.Add(amanda);
        twins.Add(louise);
        var myKids = new List<Kid>(twins);

        var minaPrylar = new Belongings(myCars, myPet, myKids);
        
        minaPrylar.Show();
    }
}
