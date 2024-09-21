namespace MadLibs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var story = new Story(CreateStoryFragments(), CreateStoryBlanks());
            Print(story);

            void Print(Story story)
            {
                int noOfBlanks = story.Blanks.Count;
                int noOfFragments =  story.Fragments.Count;

                for (int i = 0; i < noOfBlanks; i++)
                Console.WriteLine();
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
            List<string> CreateStoryFragments()
            {
                List<string> storyFragments = new List<string>();
                storyFragments.Add("Yesterday I went to ");
                storyFragments.Add("'s birthday party. I got him/her a ");
                storyFragments.Add("\r\n. The party was");
                storyFragments.Add(". We started by playing ");
                storyFragments.Add(". and then there was a ");
                storyFragments.Add(" party.Lots of my friends were there but I mostly hung out with ");
                storyFragments.Add(". We talked about ");
                storyFragments.Add(" and how our friend ");
                storyFragments.Add(" is a ");
                storyFragments.Add(". During cake everyone ");
                storyFragments.Add(" and sang ");
                storyFragments.Add(". I had a ");
                storyFragments.Add(" time at the party and enjoyed celebrating ");
                storyFragments.Add("\r\n. He/she is such a ");
                storyFragments.Add(" friend.");
                return storyFragments;
            }
            List<string> CreateStoryBlanks()
            {
                List<string> blanks = new List<string>();

                blanks.Add("Fredrik");
                blanks.Add("lawsuit");
                blanks.Add("lavish");
                blanks.Add("spelunking");
                blanks.Add("wave");
                blanks.Add("Fredrik");
                blanks.Add("cave");
                blanks.Add("nondisclosure");
                blanks.Add("tell");
                blanks.Add("Poison");
                blanks.Add("holistic");
                blanks.Add("Fredrik");
                blanks.Add("fascinated");

                return blanks;

            }

            //show story
            //
        }
    }
}
