namespace CodeAlongForest2023;

public class Dolphin : Animal
{
    public int DistancePerDay;
    public Dolphin(double weight, bool isNocturnal, int distancePerDay) : base(weight, isNocturnal)
    {
        DistancePerDay = (distancePerDay >= 0) ? distancePerDay : 0;
    }
    public override void Move(bool isDay)
    {
        if (isDay)
        {
            Console.WriteLine("Delfinen jagar fisk i floden.");
        }
        else
        {
            Console.WriteLine("Delfinen sover.");
        }
    }
}
