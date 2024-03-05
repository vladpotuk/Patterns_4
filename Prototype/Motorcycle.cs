public class Motorcycle : IVehicle
{
    public string Make { get; }
    public string Type { get; }
    public int EngineSize { get; }
    public string Color { get; }

    public Motorcycle(string make, string type, int engineSize, string color)
    {
        Make = make;
        Type = type;
        EngineSize = engineSize;
        Color = color;
    }

    public IVehicle Clone()
    {
        return new Motorcycle(Make, Type, EngineSize, Color);
    }

    public string Move()
    {
        return $"Motorcycle {Make} {Type} with {EngineSize}cc engine is moving on the road";
    }

    public string GetDetails()
    {
        return $"Motorcycle: {Make} {Type}, Engine Size: {EngineSize}cc, Color: {Color}";
    }
}
