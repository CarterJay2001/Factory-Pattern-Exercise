using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?\n");

            IVehicle vehicle1 = VehicleFactory.GetVehicle(Console.ReadLine());
            vehicle1.Drive();

            Console.WriteLine("How many wheels does your 2nd vehicle have?\n");

            IVehicle vehicle2 = VehicleFactory.GetVehicle(Console.ReadLine());
            vehicle2.Drive();

            Console.WriteLine("How many wheels does your 3rd vehicle have?\n");

            IVehicle vehicle3 = VehicleFactory.GetVehicle(Console.ReadLine());
            vehicle3.Drive();
        }
    }
}
