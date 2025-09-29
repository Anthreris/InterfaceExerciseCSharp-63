namespace InterfaceExercise;

public interface IVehicle : ICompany
{
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool HasWorkingEngine { get; set; }
    
}