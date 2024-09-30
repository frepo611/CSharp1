
using System.Runtime.CompilerServices;

namespace Vilken_Dag
{
    internal class Program
    {
        static string[] months =    {"Januari","Februari","Mars","April","Maj","Juni",
                                    "Juli", "Augusti","September", "Oktober", "November", "December"};
        static string[] weekdays =  {"Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };
        static void Main(string[] args)
        {
            bool runAgain = true;
            do
            {
                Console.WriteLine("Välkommen till:\n\n--Vilken dag?--\n");
                Console.WriteLine("Välj funktion:");
                Console.WriteLine("1. Siffra till månad som sträng\n2. Dagens datum som sträng\n3. Vilken veckodag var det?");
                var userInputKey = Console.ReadKey(true);

                switch (userInputKey.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        int month = AskForMonth();
                        Console.WriteLine($"Månad {month}: {IntegerToMonth(month)}");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        month = DateTime.Now.Month;
                        int day = (int)DateTime.Now.DayOfWeek;
                        Console.WriteLine($"Idag är det {IntegerToDay(day).ToLower()} {IntegerToMonth(month).ToLower()} {DateTime.Now.Day} {DateTime.Now.Year}.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        //WhatDateAsString();
                        break;
                    default:
                        runAgain = false;
                        break;
                }
                Console.Clear();
            } while (runAgain);

        }

        private static string IntegerToDay(int day)
        {
            return weekdays[day - 1];
        }

        private static string IntegerToMonth(int month)
        {
            return months[month - 1];
        }

        private static int AskForMonth()
        {
            bool runAgain = true;
            int month = 0;
            do
            {
                Console.Write("Ange månadens nummer (1-12): ");
                string input = Console.ReadLine();
                bool validInput = int.TryParse(input, out month);
                if (validInput && month >= 1 && month <= 12)
                {
                    runAgain = false;
                }
            }       
            while (runAgain);
            return month;
        }
    }
}
