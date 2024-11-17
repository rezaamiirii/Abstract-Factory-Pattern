using Abstract_Factory_Pattern.Interfaces;

namespace Abstract_Factory_Pattern.Vehicles
{
    public class Bike : IVehicle
    {
        public string GetDescription()
        {
            return VehicleDescription.GetDescription("Harley-Davidson");
        }
    }
}
