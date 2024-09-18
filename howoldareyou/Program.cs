DateOnly userBirthdate;
while (true)
{
    Console.WriteLine("What is your birthdate");
    string userInput = Console.ReadLine();
    bool validBirthdate = DateOnly.TryParse(userInput, out userBirthdate);
    if (validBirthdate) break;
}
Console.WriteLine($"Your year of birth is {userBirthdate.Year}");
Console.WriteLine($"You are {HowOld(userBirthdate)} years old");

int HowOld(DateOnly userBirthdate)
{   DateTime date = new DateTime(userBirthdate.Year,userBirthdate.Month,userBirthdate.Day);
    if (DateTime.Compare(DateTime.Today, date) < 0)
        {
        throw new ArgumentException("The date cannot be in the future.");
        }
    return (DateTime.Today.Year - userBirthdate.Year);
}

Console.WriteLine("Press Enter to continue");
Console.ReadLine();
