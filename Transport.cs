public class   Transport
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public int MaxSpeed { get; set; }
    
    public Transport(string name, int capacity, int maxSpeed)
    {
        Name = name;
        Capacity = capacity;
        MaxSpeed = maxSpeed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Transport Type: {Name}");
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine($"Max Speed: {MaxSpeed}");
    }
}
