namespace CodeAlongForest2023;

public class Horse : Animal
{
    public int HayPerDay { get; set; }
    public Horse(double weight, bool isNocturnal, int hayPerDay) : base(weight, isNocturnal)
    {
        HayPerDay = (hayPerDay >= 0) ? hayPerDay : 0;
    }
    public override void Move(bool isDay)
    {
        if (isDay)
        {
            Console.WriteLine("Hästen betar gräs.");
        }
        else
        {
            Console.WriteLine("Hästen sover lätt.");
        }
    }
}
