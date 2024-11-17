using Abstract_Factory_Pattern.Interfaces;

namespace Abstract_Factory_Pattern.Vehicles
{
    public class Car : IVehicle
    {
        public string GetDescription()
        {
            return VehicleDescription.GetDescription("Tesla");
        }
    }
}
