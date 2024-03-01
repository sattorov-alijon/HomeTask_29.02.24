public class Train : Transport
{
     public int Carriages{ get; set; }// Shumorai vagonho

    public Train(string name, int capacity, int maxSpeed,int carriages):base(name, capacity, maxSpeed)
    {
       Carriages=carriages;
    }
}