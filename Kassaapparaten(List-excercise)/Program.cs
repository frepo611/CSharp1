﻿
using System.Globalization;

namespace Kassaapparaten_List_excercise_
{
    internal class Program
    {
        static List<double> invoice = new List<double>();
        static void Main(string[] args)
        {
            CultureInfo swedishCulture = new CultureInfo("sv-SE");
            CultureInfo.CurrentCulture = swedishCulture;

            bool loopAgain = true;
            do
            {
                PrintInvoice();
                Console.WriteLine();
                Console.WriteLine("Vad vill du göra?\n");
                Console.WriteLine("[A]ddera post(er)");
                Console.WriteLine("[R]adera post(er)");
                Console.WriteLine("A[v]sluta programmet");

                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.A:
                        AddToInvoice();
                        break;
                    case ConsoleKey.R:
                        RemoveFromInvoice();
                        break;
                    case ConsoleKey.V:
                        loopAgain = false;
                        break;
                    default:
                        break;
                }
            }
            while (loopAgain);



        }

        private static void PrintInvoice()
        {
            Console.Clear();
            if (invoice.Count == 0)
            {
                Console.WriteLine("Fakturan är tom.");
                return;
            }
            double sum = 0;
            int index = 0;
            foreach (var item in invoice)
            {
                Console.WriteLine($"{index+1}: {item:C2}");
                index++;
                sum += item;
            }
            Console.WriteLine($"Summa: {sum:C2}");   
        }

        private static void RemoveFromInvoice()
        {
            while (true)
            {
                Console.Write("Ange en post att ta bort. (Tom post för att gå till menyn): ");
                string input = Console.ReadLine();
                if (input == string.Empty)
                {
                    Console.Clear();
                    return;
                }
                bool validEntry = int.TryParse(input, out int postIndex);
                if (postIndex < 1 || postIndex > invoice.Count)
                {
                    Console.WriteLine($"Post {postIndex} finns inte. Tryck någon tangent för att fortsätta.");
                    Console.ReadKey();
                    PrintInvoice();
                    continue;
                }
                if (validEntry)
                {
                    double removedPost = invoice[postIndex - 1];
                    invoice.RemoveAt(postIndex - 1);
                    Console.WriteLine($"{postIndex}: {removedPost:C2} borttagen. Tryck någon tangent för att fortsätta.");
                    Console.ReadKey();
                    PrintInvoice();
                    if (invoice.Count == 0) 
                    {
                        Console.ReadKey();
                    }
                }
            }

        }

        private static void AddToInvoice()
        {
            while (true)
            {
                Console.Write("Ange ett belopp (tomt belopp för att gå till menyn): ");
                string input = Console.ReadLine();
                if (input == string.Empty)
                {
                    Console.Clear();
                    return;
                }
                bool validEntry = double.TryParse(input, out double amount);
                if (validEntry)
                {
                    invoice.Add(amount);
                    Console.WriteLine($"{invoice.Count}: {amount:C2} tillagd");
                } 
            }
        }

        private static void PrintReceipt()
        {
            throw new NotImplementedException();
        }
    }
}
