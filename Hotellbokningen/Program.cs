﻿




namespace Hotellbokningen
{
    internal class Program
    {
        static string[,] hotelRooms = new string[3, 4];
        static int[] priceList = {650,775,995};
        static int[] rooms = { 0, 1, 2, 3, 10, 11, 12, 13, 20, 21, 22, 23 };
        static void Main(string[] args)
        {
            int room = 10;
            string name = "Andersson";
            //PrintRooms();
            //Console.ReadKey();
            BookRoom(room, name);
            BookRoom(12, "Jappo");
            PrintRooms();
            //Console.ReadKey();
            int nightlyRevenue = GetNightlyRevenue();
            int[] vacantRooms = GetVacantRooms();
            foreach (var item in vacantRooms)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

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
            int floorNo = (int)room / 10;
            int roomNo = room - floorNo * 10;
            hotelRooms[floorNo,roomNo] = name;
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
