namespace CodeAlongForest2023;

public class Owl  : Animal
{
    public int Wingspan { get; set; }
    public Owl(double weight, bool isNocturnal, int wingspan) : base(weight, isNocturnal)
    {
        Wingspan = (wingspan >= 0) ? wingspan : 0;
    }
    public override void Move(bool isDay)
    {
        if (isDay)
        {
            Console.WriteLine("Ugglan sover i ett träd.");
        }
        else
        {
            Console.WriteLine("Ugglan jag efter smådjur.");
        }
    }
}
