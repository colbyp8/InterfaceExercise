using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    //In your IVehicle

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: All vehicles have a number of wheels... for now..
     */
    public interface IVehicle
    {
        public int AverageMPG { get; set; }
        public string Honk { get; set; }
        public bool CanOffRoad { get; set; }
        public int AverageCapacity { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
    }
}
