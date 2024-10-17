﻿// Vänj dig vid att använda engelska för *allt* som inte är den del av användarupplevelsen.
namespace Skogen;
internal class Animal
{
    // "Set" är onödigt här. Utan den så vet du att ara kontruktorn kan skapa djur.
    public Species Name { get; set; }
    bool IsNoctural { get; init; } // Felstavad
    string Movement { get; init; } // Intiera till "" så slipper du varning.

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

        // Lite överkurs, men tilldelningen kan göras riktigt snyggt med ett switch expression och tuples + tuple deconstruction:
        // (IsNoctural, Movement) = name switch
        //{
        //    Species.Vargen => (true, "jagar envist sitt byte."),
        //    Species.Fladdermusen => (true, "flyger runt bland träden i jakt på mat."),
        //    _ => (false, "")
        //};
        //
        // När du tänker använda ett switch statement, använd ett switch expression om det funkar.

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

    // En enum i bestämd form på svenska är inte det bästa för att ge djuren namn.
    // Testa en statisk klass Species med djur i formen
    // public static string Wolf => "Vargen";
    public enum Species
    {
        Vargen,
        Fladdermusen,
        Delfinen,
        Ugglan,
        Hästen
    }
}