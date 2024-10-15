using System;

Person p1 = new Person("Anna");
Person p2 = new Person("Johan");
Person p3 = new Person("Nisse");
Person p4 = new Person("Kalle");
Person p5 = new Person("Runar");

List<Person> fighters = new List<Person>();
fighters.Add(p1);
fighters.Add(p2);
fighters.Add(p3);
fighters.Add(p4);
fighters.Add(p5);

foreach (var person in fighters)
{
    Console.WriteLine(person);
}

Console.WriteLine();
Mountain mountain = new Mountain("Ryssbacken");

Console.WriteLine($"Kampen om {mountain.Name}");

foreach (var person in fighters)
{ mountain.Challenge(person); }