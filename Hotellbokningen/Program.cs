


namespace Hotellbokningen
{
    internal class Program
    {
        static string[,] hotelRooms = new string[3, 4];
        static void Main(string[] args)
        {
            int room = 10;
            string name = "Andersson";
            PrintRooms();
            Console.ReadKey();
            BookRoom(room, name);
            PrintRooms();
            Console.ReadKey();

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
                Console.WriteLine();
            }
        }
    }
}
