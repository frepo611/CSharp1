namespace EnDagILivet
{
    internal class Program
    {
        
        enum Activities
        {
            Wakeup,
            EatBreakfast,
            DropOffKids,
            Lecture,
            EatLunch,
            DoExercises,
            EatDinner,
            DoWork,
            PickUpKids,
            DrinkCoffee,
            TakeAWalk

        }
        static void Main(string[] args)
        {
            int energyLevel = 0;
            Console.WriteLine($"{"Aktivitet",-26} Energinivå");
            for (int i = 0; i < 41; i++)
            {
                Console.Write("=");
                if (i == 40)
                {
                    Console.WriteLine();
                }
            }
            energyLevel = DoActivity(Activities.Wakeup, energyLevel);
            energyLevel = DoActivity(Activities.EatBreakfast, energyLevel);
            energyLevel = DoActivity(Activities.DropOffKids, energyLevel);
            energyLevel = DoActivity(Activities.Lecture, energyLevel);
            energyLevel = DoActivity(Activities.DrinkCoffee, energyLevel);
            energyLevel = DoActivity(Activities.DoExercises, energyLevel);
            energyLevel = DoActivity(Activities.DoWork, energyLevel);
            energyLevel = DoActivity(Activities.EatLunch, energyLevel);
            energyLevel = DoActivity(Activities.DoExercises, energyLevel);
            energyLevel = DoActivity(Activities.PickUpKids, energyLevel);

            Console.ReadKey();
        }

        static int DoActivity(Activities activity, int energyLevelBefore)
        {
            int energyLevelAfter = 0;
            switch (activity)
            {
                case Activities.Wakeup:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore,70);
                    Console.WriteLine($"{"Vaknade:",-30} {energyLevelAfter}%");
                    break;
                case Activities.EatBreakfast:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore,10); ;
                    Console.WriteLine($"{"Åt frukost:",-30} {energyLevelAfter}%");
                    break;
                case Activities.DropOffKids:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore,-30); ;
                    Console.WriteLine($"{"Lämnade barnen:",-30} {energyLevelAfter}%");
                    break;
                case Activities.Lecture:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore, -30);
                    Console.WriteLine($"{"Lyssnade på föreläsning:",-30} {energyLevelAfter}%");
                    break;
                case Activities.EatLunch:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore, 10);
                    Console.WriteLine($"{"Åt lunch:",-30} {energyLevelAfter}%");
                    break;
                case Activities.DoExercises:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore, 20);
                    Console.WriteLine($"{"Gjorde övningar:",-30} {energyLevelAfter}%");
                    break;
                case Activities.DoWork:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore, -30);
                    Console.WriteLine($"{"Jobbade:",-30} {energyLevelAfter}%");
                    break;
                case Activities.PickUpKids:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore, -30);
                    Console.WriteLine($"{"Hämtade barnen:",-30} {energyLevelAfter}%");
                    break;
                case Activities.DrinkCoffee:
                    energyLevelAfter = UpdateEnergyLevel(energyLevelBefore, 10);
                    Console.WriteLine($"{"Drack kaffe:",-30} {energyLevelAfter}%");
                    break;
                default:
                break;
            };
            return energyLevelAfter;
        }

        static int UpdateEnergyLevel(int currentEnergyLevel, int energyChange)
        {
            if (currentEnergyLevel + energyChange >= 100)
            {
                Console.WriteLine("\nEnergin är på max!\n");
                return 100;
            }
            else if (currentEnergyLevel + energyChange <= 0)
            {
                Console.WriteLine("\nEnergin är nollad!\n");
                return 0;
            }
            else
            {
                return currentEnergyLevel + energyChange;
            }
        }
    }
}
