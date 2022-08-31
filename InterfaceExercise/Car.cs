using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : ICompany , IVehicle
    {
        public Car()
        {
        }

        public string HeadquartersLocation { get; set; } = "USA";
        public string CompanyName { get; set; } = "Ford";
        public int AverageMPG { get; set; } = 25;
        public string Honk { get; set; } = "Beep";
        public bool CanOffRoad { get; set; } = true;
        public int AverageCapacity { get; set; } = 4;
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving in reverse...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears.");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
