namespace sagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string name = "";
            string species = "";
            int noOfLegs = 0;
            while (true)
            {
                Console.WriteLine("Ange en ålder:");
                string inputAge = Console.ReadLine();
                try
                {
                    age = int.Parse(inputAge);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ange ett heltal, tack!");
                    continue;
                }
                break;
            }

            Console.WriteLine("Ange ett namn:");
            name = Console.ReadLine();
            
            Console.WriteLine("Ange en djursort:");
            species = Console.ReadLine();

            while (true)
            {
                Console.WriteLine($"Hur många ben har en {species}?");
                string inputSpecies = Console.ReadLine();
                try
                {
                    noOfLegs = int.Parse(inputSpecies);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ange ett heltal, tack!");
                    continue;
                }
                break;
            }

                string sagan = $"Det var en gång en {age} år gammal {species} som hette {name}. En dag var {name} ute på en\r\npromenad i skogen, och mötte en stor varg. Vargen bet av ett ben. {name} sprang snabbt hem på sina\r\n{noOfLegs - 1}. Så var sagan slut.\r\n";
                Console.WriteLine(sagan);
                Console.WriteLine("Press Enter to exit");
                Console.ReadLine();
        }
    }
}
