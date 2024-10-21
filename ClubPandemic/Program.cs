using ClubPandemic;

var clubbers = new List<Clubber>();
for (int i = 0; i < 99; i++)
{
    clubbers.Add(new Clubber());
}
clubbers.Add(new Clubber(true));

Club clubPandemic = new Club(clubbers);

while (true)
{
    Console.WriteLine(clubPandemic);
    clubPandemic.PassTime();
    Console.ReadKey();
}
