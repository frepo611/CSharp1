using System;
using System.IO;
namespace CodeAlong_Vecka4
{
    internal class FileDemo
    {
        public static void Run()
        {
            string[] mintop10;

            if (File.Exists("top10.txt"))
            {
                mintop10 = File.ReadAllLines("top10.txt");
            }
            else
            {
                mintop10 = new string[10];
            }

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i + 1}: {mintop10[i]}");
                }
                Console.Write("Topplisteplats? ");
                string input = Console.ReadLine();
                bool validEntry;
                validEntry = int.TryParse(input, out int postIndex);
                if (validEntry)
                {
                    if ((postIndex - 1)>= 0 && (postIndex - 1) < mintop10.Length)
                    {
                        Console.Write($"Ny grej på plats nummer {postIndex}: ");
                        mintop10[postIndex - 1] = Console.ReadLine();
                    }
                }

                File.WriteAllLines("top10.txt", mintop10);
            }
        }
    }
}

