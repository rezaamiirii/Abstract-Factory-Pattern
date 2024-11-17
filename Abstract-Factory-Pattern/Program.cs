using Abstract_Factory_Pattern.Interfaces;
using Abstract_Factory_Pattern.Factories;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Vehicle Factory!");

        while (true)
        {
            Console.WriteLine("\nSelect a vehicle type (Tesla or Harley-Davidson) or type 'exit' to quit: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "exit")
            {
                break;
            }

            IAbstractFactory factory = input switch
            {
                "tesla" => new TeslaFactory(),
                "harley-davidson" => new HarleyDavidsonFactory(),
                _ => throw new NotSupportedException("Vehicle type not supported.")
            };

            IVehicle vehicle = factory.CreateVehicle();
            Console.WriteLine(vehicle.GetDescription());
        }

        Console.WriteLine("Thank you for using the Vehicle Factory! Goodbye.");
    }
}