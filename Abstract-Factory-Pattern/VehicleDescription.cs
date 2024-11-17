namespace Abstract_Factory_Pattern;
public static class VehicleDescription
{
    public static string GetDescription(string vehicleType)
    {
        return vehicleType switch
        {
            "Tesla" => "Tesla is known for its electric vehicles and advanced technology.",
            "Harley-Davidson" => "Harley-Davidson is a legendary motorcycle manufacturer known for its cruiser bikes.",
            _ => "Unknown vehicle type."
        };
    }
}