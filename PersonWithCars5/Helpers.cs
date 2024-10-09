
using System.Text;

namespace PersonWithCars5
{
    internal class Helpers
    {
        internal static Person CalculateAge(Person person)
        {
            person.age = DateTime.Now.Year - person.birthYear;
            return person;
        }
        public static string BuildStory(Person person)
        {
            // StringBuilder är en inbyggd klass som kan användas för att modifiera strängar utan att skapa nya strängar hela tiden
            StringBuilder sb = new StringBuilder();
            sb.Append($"{person.name} är {person.age} år gammal och");
            if (person.hasCar)
            {
                sb.Append(" har en väldigt fin bil.");
            }
            else
            {
                sb.Append(" har ingen bil.");
            }
            return sb.ToString();
        }
    }
}