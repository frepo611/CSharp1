using System;
namespace MadLibs;

public class Story
{
    public List<string> Fragments { get; set; }
    public List<string> Blanks { get; set; }

    public Story(List<string> fragments, List<string> blanks)
    {
        Fragments = fragments;
        Blanks = blanks;
    }

}