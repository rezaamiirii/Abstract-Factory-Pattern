using Abstract_Factory_Pattern.Interfaces;
using Abstract_Factory_Pattern.Vehicles;

namespace Abstract_Factory_Pattern.Factories
{
    public class HarleyDavidsonFactory : IAbstractFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
