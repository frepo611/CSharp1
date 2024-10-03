using System.Text;

namespace RäknaDiagonalen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5]
            {
                { 22, 50, 11, 2, 49 },   // First row
                { 92, 63, 12, 64, 37 },  // Second row
                { 21, 25, 64, 69, 39 }, // Third row
                { 21, 25, 71, 69, 39 }, // Fourth row
                { 19, 39, 58, 28, 83 } // Fifth row
            };

            Console.WriteLine("Hårdkodad matris:");
            Console.Write(MatrixToString(numbers));
            Console.WriteLine($"Diagonalsumman är: {GetMainDiagonalSum(numbers)}");
            Console.WriteLine();

            Console.WriteLine("Slumpad matris:");
            int matrixSize = 6;
            int[,] otherNumbers = GetRandomMatrix(matrixSize, -100, 100);
            Console.Write(MatrixToString(otherNumbers));
            Console.WriteLine($"Diagonalsumman är: {GetMainDiagonalSum(otherNumbers)}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            static string MatrixToString(int[,] array)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sb.Append($"{array[i, j],4}");
                    }
                    sb.AppendLine(); // New line for each row
                }

                return sb.ToString();
            }

            static int[,] GetRandomMatrix(int size, int minLimit, int maxLimit)
            {
                int[,] matrix = new int[size, size];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        matrix[i, j] = Random.Shared.Next(minLimit, maxLimit);
                    }
                }
                return matrix;
            }

            static int GetMainDiagonalSum(int[,] matrix)
            {
                int mainDiagonalSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            mainDiagonalSum += matrix[i, j];
                        }
                    }
                }
                return mainDiagonalSum;
            }
        }

    }
}
