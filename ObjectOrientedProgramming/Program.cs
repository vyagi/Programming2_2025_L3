var car1 = new Car("Opel", "Insignia", 55, 5.5);
car1.AddFuel(30);
car1.AddFuel(30);
Console.WriteLine(car1.FuelLevel);
car1.Drive(50);
car1.Drive(100);
Console.WriteLine(car1.FuelLevel);
Console.WriteLine(car1.Odometer);
car1.Drive(1000);
Console.WriteLine(car1.FuelLevel);
Console.WriteLine(car1.Odometer);
public class Car
{
    private readonly string _brand;
    private readonly string _model;
    private readonly int _tankCapacity;
    private readonly double _fuelConsumption;

    private double _fuelLevel;
    private double _odometer;
    public int FuelLevel => (int)_fuelLevel;
    public int Odometer => (int)_odometer;

    public Car(string brand, string model, int tankCapacity, double fuelConsumption)
    {
        if (string.IsNullOrWhiteSpace(brand))
            throw new ArgumentNullException(nameof(brand), "Brand cannot be empty");

        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentNullException(nameof(model), "Model cannot be empty");

        if(tankCapacity < 1)
            throw new ArgumentException("Tank capacity must be positive", nameof(tankCapacity));

        if (fuelConsumption <= 0)
            throw new ArgumentException("Fuel consumption must be positive", nameof(fuelConsumption));

        _brand = brand;
        _model = model;
        _tankCapacity = tankCapacity;
        _fuelConsumption = fuelConsumption;
    }

    public void AddFuel(double fuel) 
    {
        if (fuel < 0)
            throw new ArgumentException("Fuel must be positive", nameof(fuel));

        _fuelLevel += fuel;

        if (_fuelLevel > _tankCapacity)
            _fuelLevel = _tankCapacity;
    }

    public void Drive(double distance)
    {
        if (distance < 0)
            throw new ArgumentException("Distance must be positive", nameof(distance));

        var maxDistance = _fuelLevel / _fuelConsumption * 100;

        if (distance <= maxDistance)
        {
            _odometer += distance;
            _fuelLevel -= distance * _fuelConsumption / 100;
        }
        else
        {
            _odometer += maxDistance;
            _fuelLevel = 0;
        }
    }
}