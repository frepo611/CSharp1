namespace MovieDb
{
    public class Actor
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public Actor(string name, int birthYear)
        {
            Name = name;
            if (birthYear < DateTime.Now.Year && birthYear > 1800)
            {
                BirthYear = birthYear;
            }
            else
            {
                BirthYear = 0;
            }
        }
        public override string ToString() => $"{Name} (född {BirthYear})";
    }
}