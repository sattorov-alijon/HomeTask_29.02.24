public class Airplane : Transport
{
      public int Wings { get; set; } //Qanotho(Partho)

    public Airplane(string name, int capacity, int maxSpeed, int wings):base(name, capacity, maxSpeed)
    {
        Wings = wings;
    }
}