internal class Person
{
    public string Name { get; init; } 
    public int Strength { get; init; }
    public Person(string name)
    {
        Name = name;
        Strength = Random.Shared.Next(1,6);
    }
    public override string ToString()
    {
        return $"{Name} har styrka: {Strength}";
    }
}