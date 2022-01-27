using System;
namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string tires)
        {
            switch (int.Parse(tires))
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 6:
                    return new Dually();
                case 18:
                    return new BigRig();
                default:
                    return new Car();
            }
        }
    }
}
