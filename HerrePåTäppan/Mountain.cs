internal class Mountain
{
    public string Name { get; init; }

    Person? Champion { get; set; }
    int CurrentStrength { get; set; } = 0;
    public Mountain(string name)
    {
        Name = name;
    }
    internal void Challenge(Person fighter)
    {
        if (Champion == null)
        {
            Console.WriteLine($"{fighter.Name} tar plats på toppen av den tomma täppan.");
            Champion = fighter;
            CurrentStrength = fighter.Strength;
            return;
        }
        else if (Champion.Strength > fighter.Strength)
        {
            Console.WriteLine($"{Champion.Name} försvarar sin plats över {fighter.Name}.");
        }
        else if (Champion.Strength < fighter.Strength)
        {
            Console.WriteLine($"{fighter.Name} slår {Champion.Name} och tar över täppan.");
            Champion = fighter;
            CurrentStrength = fighter.Strength;
        }
        else
        {
            Console.WriteLine($"{fighter.Name} och {Champion.Name} är lika starka, men {Champion.Name} behåller sin plats.");
        }
    }
}
