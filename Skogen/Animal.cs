namespace Forest;
internal class Animal
{
    public Species Name { get; }
    bool IsNocturnal { get; init; }
    string Movement { get; init; }

    public Animal(Species name)
    {
        Movement = "";
        Name = name;
        (IsNocturnal, Movement) = name switch //used a switch expression and tuple deconstruction instead of "switch case"
        {
            Species.Vargen => (true, "jagar envist sitt byte."),
            Species.Fladdermusen => (true, "flyger runt bland träden i jakt på mat."),
            Species.Delfinen => (false, "simmar i floden och letar fisk."),
            Species.Ugglan => (true, "spanar på marken efter byten."),
            Species.Hästen => (false, "betar gräs."),
            _ => (false, "")
        };
    }
    public void Activate(bool isNight)
    {
        string activity;
        if (isNight == IsNocturnal)
        {
            activity = $"{Name} {Movement}";
        }
        else
        {
            activity = $"{Name} sover."; ;
        }
        Console.WriteLine(activity);
    }
}
