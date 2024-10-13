ulong[,] chessboard = new ulong[8,8];
ulong grains = 1;
const ulong SWEDISHPOPULATION = 10_000_000;
const ulong GOOGLEWORTH = 1_340_000_000_000;
bool hasHitPopulation = false;
bool hasHitGoogleGrowth = false;


for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        chessboard[i, j] = grains;
        if (grains > SWEDISHPOPULATION && hasHitPopulation==false)
        {
            Console.WriteLine($"({i}+{j}={i+j}): {grains:E2}");
            hasHitPopulation = true;
        }
        if (grains > GOOGLEWORTH && hasHitGoogleGrowth==false)
        {
            Console.WriteLine($"({i}+{j}={i + j}): {grains:E2}");
            hasHitGoogleGrowth = true;
        }
        grains = 2 * grains;
    }
};
