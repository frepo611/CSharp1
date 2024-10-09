using System.Runtime.CompilerServices;

namespace PersonWithCars5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "Nisse";
            person1.birthYear = 1990;
            person1.hasCar = true;

            Helpers.CalculateAge(person1);
            Console.WriteLine(person1.age);

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person();
                person.name = $"Anna{i}";

                person.birthYear = rnd.Next(1980, 2005);
                person.hasCar = (rnd.Next(0,2) == 0) ? true : false;
                person = Helpers.CalculateAge(person);
                Console.WriteLine(Helpers.BuildStory(person));
            }
        }
    }
}
