using System.Diagnostics;
using System.Text;

namespace Hotellbokningen
{
    internal class Program
    {
        static string?[,] hotelRooms = new string[3, 4];
        static int[] priceList = {650,775,995};
        static int[] rooms = { 0, 1, 2, 3, 10, 11, 12, 13, 20, 21, 22, 23 };
        static string fileName = "bookings.txt";
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();

        }

        private static void Menu()
        {

            // ladda data
            if (File.Exists(fileName))
            {
                hotelRooms = FileIO.Load(fileName); 
            }

            bool drawAgain = true;
            do
            {
                Console.WriteLine(@"
                ╔════════════════════╗
                ║  HOTEL CALIFORNIA  ║
                ╚════════════════════╝");
                PrintRooms();
                Console.WriteLine($"Hotellet får in {GetNightlyRevenue()} kr per natt.\n");
                Console.WriteLine($"Lediga rum: {RoomsArrayToString(GetVacantRooms())}\n");
                Console.WriteLine($"Upptagna rum: {RoomsArrayToString(GetOccupiedRooms())}\n");

                Console.Write("Vilket rum vill du hantera? ");
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
                        CheckoutRoom(roomNumber);
                    }
                    else
                    {
                        string name;
                        do
                        {
                            Console.Write("Gästens namn? ");
                            name = Console.ReadLine();
                        } while (string.IsNullOrEmpty(name));
                            BookRoom(roomNumber, name); 
                    }
                }
                Console.Clear();
            }
            while (drawAgain);
        }

        private static void CheckoutRoom(int room)
        {
            Console.WriteLine($"Rum {room} är upptaget!");
            Console.WriteLine($"Vill du checka ut {GetGuest(room)} (j/n)?");
            bool loopAgain = true;
            while (loopAgain)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.J:
                        int floorNo = (int)room / 10;
                        int roomNo = room - floorNo * 10;
                        hotelRooms[floorNo, roomNo] = null;
                        loopAgain = false;
                        break;
                    case ConsoleKey.N:
                        loopAgain = false;
                        break
;                    default:
                        break;
                }
                FileIO.Save(hotelRooms, fileName);
                return;
            }
        }

        private static string RoomsArrayToString(int[] roomList)
        {
            StringBuilder sb = new();
            //var vacantRooms = GetVacantRooms();
            for (int i = 0; i < roomList.Length; i++)
            {
                if (i == roomList.Length - 1) sb.Append($"{roomList[i]:D2}");
                else sb.Append($"{roomList[i]:D2}, ");
            }
            return sb.ToString();
        }

        static string GetGuest(int room)
        {
            int floorNo = (int)room / 10;
            int roomNo = room - floorNo * 10;

            return hotelRooms[floorNo, roomNo];
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

        private static int[] GetOccupiedRooms()
        {
            //calculate how many occupied rooms
            //create an int[]
            //populate the array with vacant room numbers
            int noOfOccupied = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                if (!IsVacant(rooms[i])) noOfOccupied++;
            }
            int[] occupiedRooms = new int[noOfOccupied];

            int occupiedIndex = 0;
            for (int i = 0; i < rooms.Length; i++)  // Should iterate through all rooms
            {
                if (!IsVacant(rooms[i]))
                {
                    occupiedRooms[occupiedIndex] = rooms[i]; // Populate using correct index
                    occupiedIndex++; // Increment index only when a vacant room is found
                }
            }
            return occupiedRooms;
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
            string truncatedName = name.Substring(0, Math.Min(name.Length, 11)); // TODO PrintRooms() should truncate the output!!!
            hotelRooms[floorNo,roomNo] = truncatedName;
            FileIO.Save(hotelRooms, fileName);
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
