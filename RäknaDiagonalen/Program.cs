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
                { 21, 25, 64, 69, 39 }, // Fourth row
                { 21, 25, 71, 69, 39 }, // Fourth row
                { 19, 39, 58, 28, 83 } // Fifth row
            };

            Console.WriteLine($"Diagonalsumman är: {GetMainDiagonalSum(numbers)}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

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
