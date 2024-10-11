namespace MinaPrylar
{
    public static class ConsoleUI
    {

        public static int GetInt(string message)
        {
            bool validInput = false;
            int value;
            do
            {
                Console.Write(message);
                validInput = int.TryParse(Console.ReadLine(), out value);
            }
            while (!validInput);
            return value;
        }
    }
}