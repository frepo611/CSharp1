namespace Skogen;
internal class Animal
{
    public Species Name { get; set; }
    bool IsNoctural { get; init; }
    string Movement { get; init; }

    public Animal(Species name)
    {
        Name = name;
        switch (name)
        {
            case Species.Vargen:
                IsNoctural = true;
                Movement = "jagar envist sitt byte.";
                break;
            case Species.Fladdermusen:
                IsNoctural = true;
                Movement = "flyger runt bland träden i jakt på mat.";
                break;
            case Species.Delfinen:
                IsNoctural = false;
                Movement = "simmar i floden och letar fisk.";
                break;
            case Species.Ugglan:
                IsNoctural = true;
                Movement = "spanar på marken efter byten.";
                break;
            case Species.Hästen:
                IsNoctural = false;
                Movement = "betar gräs.";
                break;
            default:
                break;
        }
    }
    public void Activate(bool isNight)
    {
        string activity;
        if (isNight == IsNoctural)
        {
            activity = $"{Name} {Movement}";
        }
        else
        {
            activity = $"{Name} sover.";            ;
        }
        Console.WriteLine(activity);
    }
    public enum Species
    {
        Vargen,
        Fladdermusen,
        Delfinen,
        Ugglan,
        Hästen
    }
}