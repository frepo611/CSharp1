namespace Forest;
internal class Animal
{
    public string SpeciesName { get; }
    bool IsNocturnal { get; }
    string Movement { get; }

    public Animal(string speciesName)
    {
        Movement = "";
        SpeciesName = speciesName;
        (IsNocturnal, Movement) = speciesName switch //used a switch expression and tuple deconstruction instead of "switch case"
        {
            Species.Wolf => (true, "jagar envist sitt byte."),
            Species.Bat => (true, "flyger runt bland träden i jakt på mat."),
            Species.Dolphin => (false, "simmar i floden och letar fisk."),
            Species.Owl => (true, "spanar på marken efter byten."),
            Species.Horse => (false, "betar gräs."),
            _ => (false, "")
        };
    }
    public void Activate(bool isNight)
    {
        string activity;
        if (isNight == IsNocturnal)
        {
            activity = $"{SpeciesName} {Movement}";
        }
        else
        {
            activity = $"{SpeciesName} sover."; ;
        }
        Console.WriteLine(activity);
    }
}
