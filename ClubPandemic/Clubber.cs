﻿namespace ClubPandemic;

internal class Clubber
{
    public bool IsInfected { get; private set; }
    public bool IsImmune { get; private set; }
    public int TimeSinceInfection { get; private set; }
    public const int TIME_TO_IMMUNITY = 4;
    public Clubber(bool isInfected = false)
    {
        IsInfected = isInfected;
        IsImmune = false;
        TimeSinceInfection = 0;
    }
    public void PassTime()
    {
        if (IsInfected)
            TimeSinceInfection++;
        if (TimeSinceInfection == TIME_TO_IMMUNITY)
        {
            IsImmune = true;
            IsInfected = false;
        }
    }
    public void Infect(Clubber otherClubber)
    {
        if (IsInfected && !otherClubber.IsImmune && !otherClubber.IsInfected)
        {
            otherClubber.IsInfected = true;
            Console.WriteLine($"{this.GetHashCode().ToString().Substring(2,3)} smittade {otherClubber.GetHashCode().ToString().Substring(2,3)}");
        }
    }
}