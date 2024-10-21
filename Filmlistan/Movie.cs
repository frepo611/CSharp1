namespace MovieDb;
public class Movie
{
    public string Title { get; init; }
    public int RunningTime { get; set; }
    public List<Actor> Stars { get; init; }
    public Movie(string title, int runningTime, List<Actor> stars)
    {
        Title = title;
        RunningTime = runningTime;
        Stars = stars;
    }
    public override string ToString()
    {
        return $" Filmen {Title} är {RunningTime} minuter lång och har följande skådespelare: {StarsToString()}.";
    }
    public string StarsToString()
    {
        var sb = new System.Text.StringBuilder();
        int index = 1;
        foreach (var actor in Stars)
        {
            if (index == Stars.Count)
            {
                sb.Append($"{actor.ToString()}");
            }
            else
            {
                sb.Append($"{actor.ToString()}, ");
            }
            index++;
        }
        return sb.ToString();
    }
}
public class Comedy : Movie
{
    public int NumberOfFunnyScenes { get; set; }
    public Comedy(string title, int runningTime, List<Actor> stars, int funnyScenes) : base(title, runningTime, stars)
    {
        NumberOfFunnyScenes = (funnyScenes > 0) ? funnyScenes : 1;
    }
    public override string ToString()
    {
        return $"{base.ToString()} Filmen innehåller {NumberOfFunnyScenes} roliga scener.";
    }
}
public class Action : Movie
{
    public int NumberOfShotsFired { get; set; }
    public Action(string title, int runningTime, List<Actor> stars, int shotsFired) : base(title, runningTime, stars)
    {
        NumberOfShotsFired = (shotsFired > 0) ? shotsFired : 1;
    }
    public override string ToString()
    {
        return $"{base.ToString()} I filmen skjuts det {NumberOfShotsFired} gånger.";
    }
}
public class SciFi : Movie
{
    public int NumberOfSpaceships { get; set; }
    public SciFi(string title, int runningTime, List<Actor> stars, int spaceships) : base(title, runningTime, stars)
    {
        NumberOfSpaceships = (spaceships > 0) ? spaceships : 1;
    }
    public override string ToString()
    {
        return $"{base.ToString()} Filmen innehåller minst {NumberOfSpaceships} rymdskepp.";
    }
}