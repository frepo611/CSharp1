using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotellbokningen
{
    internal class FileIO
    {
        internal static string?[,] Load(string fileName)
        {
            List<string> bookings = new List<string>();
            foreach (string line in File.ReadAllLines(fileName))
                {
                    bookings.Add(line);
                }
            int floors = bookings.Count;
            int rooms = bookings[0].Split("|").Length;
            string[,]? hotelRooms = new string[floors, rooms];
            //populera hotelRooms
            for (int i = 0; i < hotelRooms.GetLength(0); i++)
            {
                string[]? row = bookings[i].Split("|");
                for (int j = 0; j < hotelRooms.GetLength(1); j++)
                {
                    hotelRooms[i, j] = row[j] == "" ? null : row[j];
                }
            }

            return hotelRooms;
        }

        internal static void Save(string?[,] hotelRooms,string fileName)
        {
            string[] bookingsAsArray = new string[hotelRooms.GetLength(0)];
            //save each row of hotelRooms as a string seprated with a |
            for (int i = 0; i < hotelRooms.GetLength(0); i++)
            {
            StringBuilder sb = new StringBuilder();
                for (int j = 0; j < hotelRooms.GetLength(1); j++)
                {
                    if (j + 1 == hotelRooms.GetLength(1))
                        sb.Append($"{hotelRooms[i, j]}");
                    else sb.Append($"{hotelRooms[i, j]}|");
                }

                    bookingsAsArray[i] = sb.ToString();

            }
            File.WriteAllLines(fileName, bookingsAsArray);
        }
    }
}
