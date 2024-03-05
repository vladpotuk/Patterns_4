using System;

class Program
{
    static void Main(string[] args)
    {
        IVehicle carPrototype = new Car("Toyota", "Camry", 2023, "Black");
        IVehicle carClone = carPrototype.Clone();

        IVehicle motorcyclePrototype = new Motorcycle("Honda", "CBR", 1000, "Red");
        IVehicle motorcycleClone = motorcyclePrototype.Clone();

        Console.WriteLine(carClone.Move());
        Console.WriteLine(carClone.GetDetails());

        Console.WriteLine(motorcycleClone.Move());
        Console.WriteLine(motorcycleClone.GetDetails());
    }
}
