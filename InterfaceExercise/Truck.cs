namespace InterfaceExercise;

public class Truck : IVehicle
{
    public bool HasTruckBed { get; set; }
    public int TruckBedSpace { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool HasWorkingEngine { get; set; }
    public string HomeCountry { get; set; }
    public string Logo { get; set; }
}