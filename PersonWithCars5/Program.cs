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

            Random rnd = new Random();
            string[] names = Helpers.GetNames();
            List<Person> personList = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person();
                person.name = names[rnd.Next(names.Length)];

                person.birthYear = rnd.Next(1980, 2005);
                person.hasCar = (rnd.Next(0,2) == 0) ? true : false;
                person = Helpers.CalculateAge(person);
                personList.Add(person);
            }
            foreach (Person person in personList)
            {
                Console.WriteLine(Helpers.BuildStory(person));
            }
        }
    }
}
