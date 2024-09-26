
namespace DiceGame
{
    internal class Program
    {
        static int noOfDice = 3;
        static int sumOfRolls = 0;
        static int score = 0;
        static int[] rolls = new int[noOfDice];
        static void Main(string[] args)
        {
            int intendation = 0;
            for (int i = 0; i < noOfDice; i++)
            {
                rolls[i] = Random.Shared.Next(1,7);
                sumOfRolls += rolls[i];
                DrawDice(rolls[i], intendation);
                intendation += 10;
            }
            Console.ReadKey();

            //EvaluateResult(sumOfRolls);
        }

        //static void EvaluateResult(int sumOfRolls)
        //{
        //    Console.SetCursorPosition(0, Console.CursorTop - 2);
        //    Console.WriteLine(
        //}

        // Draw a die. Indent cursor positions
        static void DrawDice(int roll, int indentation)
        {
            int topPosition = 0;

            string diceTop =    "┌─────┐";
            string twoDots =    "│ o o │";
            string noDots =     "│     │";
            string middleDot =  "│  o  │";
            string leftDot =    "│ o   │";
            string rightDot =   "│   o │";
            string diceBottom = "└─────┘";
            string row1 = string.Empty;
            string row2 = string.Empty;
            string row3 = string.Empty;

            //create die

            switch (roll)
            {
                case 1:
                    row1 = noDots;
                    row2 = middleDot;
                    row3 = noDots;
                    break;
                case 2:
                    row1 = leftDot;
                    row2 = noDots;
                    row3 = rightDot;
                    break;
                case 3:
                    row1 = leftDot;
                    row2 = middleDot;
                    row3 = rightDot;
                    break;
                case 4:
                    row1 = twoDots;
                    row2 = noDots;
                    row3 = twoDots;
                    break;
                case 5:
                    row1 = twoDots;
                    row2 = middleDot;
                    row3 = twoDots;
                    break;
                case 6:
                    row1 = twoDots;
                    row2 = twoDots;
                    row3 = twoDots;
                    break;  
                default:
                    break;
            }
            //draw die
            Console.SetCursorPosition(indentation, topPosition);
            Console.Write(diceTop);
            Console.SetCursorPosition(indentation, topPosition += +1);
            Console.Write(row1);
            Console.SetCursorPosition(indentation, topPosition += +1);
            Console.Write(row2);
            Console.SetCursorPosition(indentation, topPosition += +1);
            Console.Write(row3);
            Console.SetCursorPosition(indentation, topPosition += +1);
            Console.Write(diceBottom);

        }
    }
}
