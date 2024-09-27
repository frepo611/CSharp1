

namespace BilFabriken
{
    internal class Program
    {
        static int totalTime = 0;
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
            BuildCar();
            }
            Console.ReadLine();
        }

        private static void BuildCar()
        {
            string car = "En bil";
            car = AddChassis(car);
            car = AddWheels(car);
            car = AddEngine(car);
            car = AddInterior(car);
            car = AddBody(car);

            Console.WriteLine($"Din nya bil! {car} Den tog {totalTime} timmar att bygga.");
            ResetTime();
        }

        static string AddBody(string car)
        {
            string color = string.Empty;
            int colorNo = Random.Shared.Next(0, 6);

            switch (colorNo)
            {
                case 0:
                    color = "röd";
                    break;
                case 1:
                    color = "gul";
                    break;
                case 2:
                    color = "grön";
                    break;
                case 3:
                    color = "blå";
                    break;
                case 4:
                    color = "svart";
                    break;
                case 5:
                    color = "vit";
                    break;
                default:
                    break;
            }
            return $"{car} Den är {color}.";
        }

        static void ResetTime()
        {
            totalTime = 0;
        }

        static string AddEngine(string car)
        {
            int buildTime = 0;
            int partNo = Random.Shared.Next(0, 4);
            string engineType = "";
            switch (partNo)
            {
                case 0:
                    engineType = "en Wankelmotor på 120 hästkrafter";
                    buildTime += 1;
                    break;
                case 1:
                    engineType = "en V12-motor på 670 hästkrafter";
                    buildTime += 5;
                    break;
                case 2:
                    engineType = "en elektrisk motor på 200 hästkrafter";
                    buildTime += 3;
                    break;
                case 3:
                    engineType = "en hybridmotor på 180 hästkrafter";
                    buildTime += 8;
                    break;
                default:
                    break;
            }
            totalTime = totalTime + buildTime;
            return $"{car}, {engineType}";
        }
        static string AddInterior(string car)
        {
            int buildTime = 0;
            int partNo = Random.Shared.Next(0, 2);
            string interiorType = "";
            switch (partNo)
            {
                case 0:
                    interiorType = "tygklädsel";
                    buildTime += 1;
                    break;
                case 1:
                    interiorType = "läderklädsel";
                    buildTime += 3;
                    break;
                default:
                    break;
            }
            totalTime = totalTime + buildTime;
            return $"{car} och {interiorType}.";
        }

        private static string AddWheels(string car)
        {
            string wheelType = "";
            int buildTime = 0;
            int noOfWheels = Random.Shared.Next(3, 5);
            int partNo = Random.Shared.Next(0, 2);

            switch (noOfWheels)
            {
                case 3:
                    buildTime += 8;
                    break;
                case 4:
                    buildTime += 2;
                    break;
                default:
                    break;
            }
            switch (partNo)
            {
                case 0:
                    wheelType = "sommardäck";
                    buildTime += 1;
                    break;
                case 1:
                    wheelType = "vinterdäck";
                    buildTime += 1;
                    break;
                default:
                    break;
            }
            totalTime = totalTime + buildTime;
            return $"{car} {noOfWheels} stycken {wheelType}";
        }

        private static string AddChassis(string car)
        {
            string newPart = "";
            int buildTime = 0;
            int partNo = Random.Shared.Next(0, 2);

            switch (partNo)
            {
                case 0:
                    newPart = "rostfritt underrede";
                    buildTime = 2;
                    break;
                case 1:
                    newPart = "underrede i stål";
                    buildTime = 3;
                    break;
                default:
                    break;
            }
            totalTime = totalTime + buildTime;
            return $"{car} med {newPart},";
        }
    }
}
