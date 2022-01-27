using System;
namespace FactoryPatternExercise
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {
        }
        public void Drive()
        {
            Console.WriteLine("BigRig is driving\n");
        }
    }
}
