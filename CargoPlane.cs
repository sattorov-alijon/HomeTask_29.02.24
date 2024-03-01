class CargoPlane : Airplane
{
    public int CargoCapacity { get; set; } // quvvai tavonoi baroi bardoshtani vazn

    public CargoPlane(string name, int capacity, int maxSpeed, int wings, int cargoCapacity):base(name, capacity, maxSpeed, wings)
    {
        CargoCapacity = cargoCapacity;
    }
}