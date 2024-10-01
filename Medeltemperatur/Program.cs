
namespace Medeltemperatur
{
    internal class Program
    {
        static void Main(string[] args)

        {
            const int ARRAY_LENGTH = 2;
            double[] temperatures = new double[ARRAY_LENGTH];

            temperatures = AskForTemperatures(temperatures.Length);
            Console.WriteLine("Skriver ut i omvänd ordning:");
            PrintReverseArray(temperatures);
            double averageTemp = CalculateAverage(temperatures);
            Console.WriteLine($"Medeltemperaturen är: {averageTemp:F1} grader");
            double maxTemp = GetMax(temperatures);
            Console.WriteLine($"Maxtemperaturen är: {maxTemp:G} grader");
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey(true);
        }

        private static double GetMax(double[] temperatures)
        {
            Array.Sort(temperatures);
            return temperatures[^1];
        }

        private static double CalculateAverage(double[] temperatures)
        {
            return temperatures.Average();
        }

        private static void PrintReverseArray(double[] temperatures)
        {
            for (int i = temperatures.Length - 1; i >=0 ; i--)
            {
                Console.WriteLine($"{temperatures[i]:G}");
            }
        }

        private static double[] AskForTemperatures(int length)
        {
            bool inValidEntry = false;
            double[] temperatures = new double[length];

            do
            {
                Console.WriteLine($"Skriv {length} temperaturvärden, separerade med blanksteg (använd decimalpunkt, inte decimalkomma). Avsluta med Enter.");
                string input = Console.ReadLine();

                string[] splitInput = input.Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (splitInput.Length != 5)
                {
                    Console.WriteLine($"Skriv {length} värden. Försök igen.");
                    inValidEntry = true;
                    continue;
                }

                for (int i = 0; i < splitInput.Length; i++)
                {
                    double temp;
                    inValidEntry = !double.TryParse(splitInput[i], out temp);
                    if (inValidEntry)
                    {
                        Console.WriteLine("Kan inte läsa alla värden. Försök igen.");
                        break;
                    }
                    else
                        temperatures[i] = temp;
                }
            } while (inValidEntry);

            return temperatures;
        }
    }
}
