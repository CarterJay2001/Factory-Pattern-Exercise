using System;
namespace FactoryPatternExercise
{
    public class Dually : IVehicle
    {
        public Dually()
        {
        }
        public void Drive()
        {
            Console.WriteLine("Dually is driving\n");
        }
    }
}
