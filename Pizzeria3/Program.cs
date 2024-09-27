


internal class Program

{
    static int price = 0;

    private static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till Gunnars Pizeria");
        MyPizzaApp();
        Console.ReadLine();

        static void MyPizzaApp()
        {
            string pizza = "";
            pizza = MakeBase(pizza);
            pizza = AddSauce(pizza);
            pizza = AddCheese(pizza);
            pizza = AddTopping(pizza);
            Console.WriteLine(pizza);

        }

        static string AddTopping(string pizza)
        {
            ;
            return pizza;
        }

        static string AddCheese(string pizza)
        {
            if (Random.Shared.Next(1, 3) == 1)
            {
                pizza += "med gräddig ost";
                price +=
            }
            return pizza;
        }

        static string AddSauce(string pizza)
        {
            pizza += "med mustig tomatsås ";
            return pizza;
        }

        static string MakeBase(string pizza)
        {
            string pizzaBase = "Härlig pizzabotten ";
            price += 25;
            return pizzaBase + pizza;
        }
    }
}