class CargoCar : Car
{
    public int CargoCapacity { get; set; }//Moshini Borkash

    public CargoCar(string name, int capacity, int maxSpeed, string fuelType, int cargoCapacity):base(name, capacity, maxSpeed, fuelType)
    {
        CargoCapacity = cargoCapacity;
    }
}