namespace MinaPrylar
{
    public class StringHelpers
    {

        public static string? FirstCharCapitalized(string input)
        {
            return $"{input[0].ToString().ToUpper()}{input.Substring(1)}";
        }
    }
}