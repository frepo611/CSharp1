
namespace DiceGame
{
    internal class Program
    {
        static int noOfDice = 3;
        static int sumOfRolls = 0;
        static int score = 0;
        static int[] rolls = new int[noOfDice];
        static int indentation = 0;
        static void Main(string[] args)
        {
            do
            {

                RollDice();
                EvaluateResult();
                Console.Clear();
            } while (true);

        }

        static void RollDice()
        {
            for (int i = 0; i < noOfDice; i++)
            {
                rolls[i] = Random.Shared.Next(1, 7);
                sumOfRolls += rolls[i];
                DrawDice(rolls[i], indentation);
                indentation += 10;
            }
            indentation = 0;
        }

        static void UpdateScore(int change)
        {
            if (score + change > 0)
                score += change;
            else score = 0;
        }
        static void EvaluateResult()
        {
            int noOfMatchingDice = 0;
            string resultMessage = string.Empty;
            string scoreCalculation = $"{score}";
            int scoreFromPreviousRoll = score;

            //check for matching dice
            if ((rolls[0] == rolls[1]) && (rolls[0] == rolls[2]))
            {
                noOfMatchingDice = 3;
            }
            else if ((rolls[0] == rolls[1]) ||
                      rolls[0] == rolls[2] ||
                      rolls[1] == rolls[2])
            {
                noOfMatchingDice = 2;
            }
            //score matching dice
            if (noOfMatchingDice > 0)
            {
                if (noOfMatchingDice == 2)
                {
                    resultMessage = "Roligt, du fick två lika. Du får tre poäng.\n";
                    scoreCalculation = $"{scoreCalculation} + 3";
                    UpdateScore(3);
                }
                else if (noOfMatchingDice == 3)
                {
                    resultMessage = "Roligt, du fick tre lika. Du får tio poäng.\n";
                    scoreCalculation = $"{scoreCalculation} + 10";
                    UpdateScore(10);
                }
            }
            else
            {
                resultMessage = "Tråkigt, du fick inga lika. Du får inga poäng.\n";
            }

            //check and score sum of rolls
            if (sumOfRolls < 9)
            {
                resultMessage = $"{resultMessage}Tråkigt, summan({sumOfRolls}) är mindre än nio. Du får fem minuspoäng.\n";
                scoreCalculation = $"{scoreCalculation} - 5";
                UpdateScore(-5);

            }
            else 
            {
                resultMessage = $"{resultMessage}Tur, summan({sumOfRolls}) är större än åtta. Du får inga minuspoäng.\n";
            }

            ResetSumOfRolls();

            Console.SetCursorPosition(0, Console.CursorTop + 2);

            if ((score == scoreFromPreviousRoll))
            {
                Console.WriteLine($"{resultMessage}Du har forfarande {score} poäng.");
            }
            else
            {
                Console.WriteLine($"{resultMessage}Du har nu {score} ({scoreCalculation}) poäng.");
            }
        }

        private static void ResetSumOfRolls()
        {
            sumOfRolls = 0;
        }

        // Draw a die. Indent cursor positions
        static void DrawDice(int roll, int indentation)
        {
            int topPosition = 0;

            string diceTop = "┌─────┐";
            string twoDots = "│ o o │";
            string noDots = "│     │";
            string middleDot = "│  o  │";
            string leftDot = "│ o   │";
            string rightDot = "│   o │";
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
