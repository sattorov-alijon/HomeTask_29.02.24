class PassengerPlane : Airplane
{
    public int PassengerCapacity { get; set; }// Shumorai joyi nishast baroi pasagiron

    public PassengerPlane(string name, int capacity, int maxSpeed, int wings, int passengerCapacity):base(name, capacity, maxSpeed, wings)
    {
        PassengerCapacity = passengerCapacity;
    }
}