namespace MinaPrylar
{
    public class Kid
    {
        private string _name;
        private int _age;
        public Kid(string name, int age)
        {
            _name = StringHelpers.FirstCharCapitalized(name);
            _age = age;
        }
        public string GetName() => _name;
        public int GetAge() => _age;
    }
}