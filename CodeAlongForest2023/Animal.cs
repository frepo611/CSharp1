namespace CodeAlongForest2023;

public class Animal
{
    public double Weight { get; set; }
    public bool IsNocturnal { get; set; }
    public Animal(double weight, bool isNocturnal)
    {
        Weight = (weight >= 0) ? weight : 0;
        IsNocturnal = isNocturnal;
    }
    public virtual void Move(bool isDay) { }
}
