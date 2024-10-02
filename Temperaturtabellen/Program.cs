namespace Temperaturtabellen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // write the header row
            for (int i = 0; i < TemperatureTable.months.Length; i++)
            {
                if (i == 0) Console.Write($"{TemperatureTable.months[i],14}");
                else Console.Write($"{TemperatureTable.months[i],4}");
            }
            Console.WriteLine();
            // write the rest including the cities array
            {
                for (int i = 0; i < TemperatureTable.tempTable.GetLength(0); i++)
                {
                    Console.Write($"{TemperatureTable.cities[i],10}");
                    for (int j = 0; j < TemperatureTable.tempTable.GetLength(1); j++)
                    {
                        Console.Write($"{TemperatureTable.tempTable[i,j],4}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
        public class TemperatureTable()
        {
            public static int[,] tempTable = {
            // Eskilstuna average monthly temperatures
            { -2, 0, 4, 10, 15, 19, 21, 20, 16, 10, 4, 0 },
            
            // Stockholm average monthly temperatures
            { -1, 0, 3, 8, 14, 18, 20, 19, 15, 9, 4, 1 },
            
            // Nyköping average monthly temperatures
            { -1, 1, 4, 9, 14, 18, 21, 20, 16, 10, 5, 2 },
            
            // Ronneby average monthly temperatures
            { -1, 1, 4, 10, 15, 19, 22, 21, 17, 11, 6, 2 }
        };
            public static string[] cities = { "Eskilstuna", "Stockholm", "Nyköping", "Ronneby" };

            public static string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        }
    }
}