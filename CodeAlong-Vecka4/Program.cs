namespace CodeAlong_Vecka4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileDemo.Run();
        }
    }
    internal class TernaryDemo
        {
        public static void Demo()
        {
            int x = 15;
            int y = 5;

            string result = (x > y) ? "x är större än y" : "y är mindre eller lika med x";
            Console.WriteLine(result);

            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();

            string result2 = $"{((name == "Fredrik") ? "Hej" : "Stick!")}";
            Console.WriteLine(result2);


            Console.ReadKey();
        }
    }
}
