namespace CodeAlongForest2023;
internal class Program
{
    static void Main(string[] args)
    {
        List<Animal> forest = [new Owl(0.7, true, 90), new Horse(740, false, 25), new Dolphin(190, false, 3000)];
        foreach (Animal animal in forest)
        {
            Console.WriteLine($"{(animal.GetType().Name)} väger {animal.Weight} kg");
            Console.WriteLine($"{(animal.GetType().Name)} är{(animal.IsNocturnal ? "" : "inte")} ett nattdjur");
            string message = "";
            if (animal is Owl)
            {
                Owl owl = (Owl) animal;
                message = $"Ugglan har en vingbredden {owl.Wingspan} cm";
                }
            else if (animal is Horse)
            {
                Horse horse = (Horse) animal;
                message = $"Hästen äter {horse.HayPerDay} kg hö per dag";
            }
            else if (animal is Dolphin)
            {
                Dolphin dolphin = (Dolphin) animal;
                message = $"Delfinen simmar {dolphin.DistancePerDay} meter per dag";
            }
            Console.WriteLine(message);
            animal.Move(false);
            Console.WriteLine();

        }
    }
}
