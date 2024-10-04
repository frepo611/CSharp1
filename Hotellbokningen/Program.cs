using System.Text;

namespace Hotellbokningen
{
    internal class Program
    {
        static string[,] hotelRooms = new string[3, 4];
        static int[] priceList = {650,775,995};
        static int[] rooms = { 0, 1, 2, 3, 10, 11, 12, 13, 20, 21, 22, 23 };
        static void Main(string[] args)
        {
            //int room = 10;
            //string name = "Andersson";
            //PrintRooms();
            //Console.ReadKey();
            //BookRoom(room, name);
            //BookRoom(244, "Jappo");
            //BookRoom(23, "Jappo");
            //Console.ReadKey();
            //int[] vacantRooms = GetVacantRooms();
            //int nightlyRevenue = GetNightlyRevenue();
            
            Menu();

            Console.ReadKey();

        }

        private static void Menu()
        {
            bool drawAgain = true;
            do
            {
                Console.WriteLine(@"
                ╔════════════════════╗
                ║  HOTEL CALIFORNIA  ║
                ╚════════════════════╝");

                PrintRooms();
                Console.WriteLine($"Hotellet får in {GetNightlyRevenue()} kr per natt.\n");
                Console.WriteLine($"Lediga rum: {VacantRoomsToString()}\n");
                Console.Write("Vilket rum vill du boka? ");
                string input = Console.ReadLine();
                bool validInput = false;
                validInput = int.TryParse(input, out int roomNumber);
                if (validInput)
                    {
                    if (!rooms.Contains(roomNumber))
                    {
                        Console.WriteLine($"Rum {roomNumber} finns inte!");
                        Console.WriteLine("Tryck någon tangent för att fortsätta.");
                        Console.ReadKey();
                    }
                    else if (!IsVacant(roomNumber))
                    {
                        Console.WriteLine($"Rum {roomNumber} är upptaget!");
                        Console.WriteLine("Tryck någon tangent för att fortsätta.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("Vad heter ni? "); //TODO Don't accept empty string as name
                        string name = Console.ReadLine();
                        BookRoom(roomNumber, name);
                    }
                }
                Console.Clear();
            }
            while (drawAgain);
        }
        private static string VacantRoomsToString()
        {
            StringBuilder sb = new();
            var vacantRooms = GetVacantRooms();
            for (int i = 0; i < vacantRooms.Length; i++)
            {
                if (i == vacantRooms.Length - 1) sb.Append($"{vacantRooms[i]:D2}");
                else sb.Append($"{vacantRooms[i]:D2}, ");
            }
            return sb.ToString();
        }

        private static int[] GetVacantRooms()
        {
            //calculate how many vacant rooms
            //create an int[]
            //populate the array with vacant room numbers
            int noOfVacants = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                if (IsVacant(rooms[i])) noOfVacants++;
            }
            int[] vacantRooms = new int[noOfVacants];
            
            int vacantIndex = 0;
            for (int i = 0; i < rooms.Length; i++)  // Should iterate through all rooms
            {
                if (IsVacant(rooms[i]))
                {
                    vacantRooms[vacantIndex] = rooms[i]; // Populate using correct index
                    vacantIndex++; // Increment index only when a vacant room is found
                }
            }
            return vacantRooms;
        }

        private static int GetNightlyRevenue()
        {
            int sum = 0;
            for (int i = 0; i < hotelRooms.GetLength(0); i++)
                {
                    for (int j = 0; j < hotelRooms.GetLength(1); j++)
                    {
                        if (hotelRooms[i, j] != null) sum += priceList[i];
                    }
                }
            return sum;
        }

        private static void BookRoom(int room, string name)
        {   
            if (!rooms.Contains(room))
                {
                Console.WriteLine($"Rum {room} finns inte!");
                return;
                }
            int floorNo = (int)room / 10;
            int roomNo = room - floorNo * 10;
            hotelRooms[floorNo,roomNo] = name; //TODO Ensure that the name gets truncated to not break PrintRoom formatting
        }

        private static bool IsVacant(int room)
        {
            int floorNo = (int)room / 10;
            int roomNo = room - floorNo*10;
            return hotelRooms[floorNo, roomNo] == null;
        }

        private static void PrintRooms()
        {
            for (int i = hotelRooms.GetLength(0) - 1 ; i >= 0; i--)
            {
                for (int j = 0; j < hotelRooms.GetLength(1); j++)
                {
                    Console.Write($"{i}{j}:");
                    if (hotelRooms[i, j] == null)
                        Console.Write($"{"---",-12}");
                    else
                        Console.Write($"{hotelRooms[i,j],-12}");
                }
                // print prices
                Console.WriteLine();
                for (int j = 0; j < hotelRooms.GetLength(1); j++)
                    {
                    string priceString = $"{priceList[i]} kr/natt";
                    Console.Write($"{priceString,-15}");
                    }
                    Console.WriteLine("\n");
            }
        }
    }
}
