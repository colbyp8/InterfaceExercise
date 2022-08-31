using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car = new Car();

            var truck = new Truck();
            var vehicles = new List<IVehicle>() { car, truck};

            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }

        }
    }
}
