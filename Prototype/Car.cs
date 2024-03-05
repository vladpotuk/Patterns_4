public class Car : IVehicle
{
    public string Brand { get; }
    public string Model { get; }
    public int Year { get; }
    public string Color { get; }

    public Car(string brand, string model, int year, string color)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
    }

    public IVehicle Clone()
    {
        return new Car(Brand, Model, Year, Color);
    }

    public string Move()
    {
        return $"{Year} {Brand} {Model} is moving on the road";
    }

    public string GetDetails()
    {
        return $"Car: {Year} {Brand} {Model}, Color: {Color}";
    }
}
