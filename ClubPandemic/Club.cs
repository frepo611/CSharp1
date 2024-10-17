namespace ClubPandemic;
internal class Club
{
    private int _passedTime = 0;
    private readonly List<Clubber> _clubbers;

    public Club(List<Clubber> clubbers)
    {
        _clubbers = clubbers;
    }
    internal void PassTime()
    {
        foreach (var clubber in _clubbers)
        {
            var otherClubber = GetRandomClubber();
            while (clubber == otherClubber)
            {
                otherClubber = GetRandomClubber();
            }
            clubber.Infect(otherClubber);
            clubber.PassTime();
        };
        _passedTime++;
    }
    private Clubber GetRandomClubber()
    {
        var random = Random.Shared.Next(0, _clubbers.Count);
        return _clubbers[random];
    }
    public override string ToString()
    {
        int infected = _clubbers.Where(clubber => clubber.IsInfected == true).Count();
        int immune = _clubbers.Where(clubber => clubber.IsImmune == true).Count();
        int healthy = _clubbers.Count - infected - immune;
        return $"Klubben har varit öppen i {_passedTime} timmar. {infected} gäster är smittade. {healthy} gäster har inte blivit smittade. {immune} gäster är immuna.";
    }
}