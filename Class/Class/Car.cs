using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Car : Vechile
    {
        public double FuelCapacity;
        public double FuelPerKm;

        public void Drive(int km)
        {
            Console.WriteLine(FuelCapacity - FuelPerKm * km);
            FuelCapacity = FuelCapacity - FuelPerKm * km;
        }

        public void ShowFullData()
        {
            Console.WriteLine($"{WheelCount} {Color} {FuelCapacity} {FuelPerKm}");


        }

        public string GetFullData() 
        {


            return $"{WheelCount} {Color} {FuelCapacity} {FuelPerKm}";
        }





    }
}
