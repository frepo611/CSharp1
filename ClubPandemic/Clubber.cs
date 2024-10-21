namespace ClubPandemic;

internal class Clubber
{
    public int ID { get;}
    public bool IsInfected { get; private set; }
    public bool IsImmune { get; private set; }
    public int TimeSinceInfection { get; private set; }
    public const int TIME_TO_IMMUNITY = 5;
    public Clubber(bool isInfected = false)
    {
        IsInfected = isInfected;
        IsImmune = false;
        TimeSinceInfection = 0;
        ID = int.Parse(this.GetHashCode().ToString().Substring(2,4));
    }
    public void PassTime()
    {
        if (IsInfected)
            TimeSinceInfection++;
        if (TimeSinceInfection == TIME_TO_IMMUNITY)
        {
            IsImmune = true;
            IsInfected = false;
        }
    }
    public void TryToInfect(Clubber otherClubber)
    {
        if (IsInfected && !otherClubber.IsImmune && !otherClubber.IsInfected)
        {
            otherClubber.IsInfected = true;
            Console.WriteLine($"Clubber:{this.ID} smittade Clubber:{otherClubber.ID}");
        }
    }
}