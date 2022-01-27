using System;
namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }
        public void Drive()
        {
            Console.WriteLine("Car is driving\n");
        }
    }
}
