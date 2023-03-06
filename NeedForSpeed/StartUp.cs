using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car(300, 5);
            Console.WriteLine(car.FuelConsumption);
        }
    }
}
