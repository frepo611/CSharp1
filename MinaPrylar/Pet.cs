
namespace MinaPrylar;

public class Pet
{
    private string _name;
    private string _description;
    private string _species;

    public Pet(string name, string description, string species)
    {
        _name = StringHelpers.FirstCharCapitalized(name);
        _description = description;
        _species = species;
    }

    public string GetName() => _name;
    public string GetDescription() => _description;
    public string GetSpecies() => _species;
}