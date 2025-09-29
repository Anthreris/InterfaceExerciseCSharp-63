using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            var carOne = new Car();
            carOne.Make = "Subaru";
            carOne.Model = "Impreza";
            carOne.Year = 2016;
            carOne.NumberOfWheels = 4;
            carOne.HomeCountry = "Japan";
            carOne.Logo = "Subaru Starry Oval";
            carOne.HasWorkingEngine = true;
            carOne.Trunk = true;
            carOne.TrunkRoom = 10;
            carOne.HomeCountry = "Japan";
            
            var truckOne = new Truck();
            truckOne.Make = "Chevrolet";
            truckOne.Model = "Silverado";
            truckOne.Year = 1992;
            truckOne.NumberOfWheels = 4;
            truckOne.HomeCountry = "America";
            truckOne.Logo = "Chevrolet Cross";
            truckOne.HasWorkingEngine = true;
            truckOne.HasTruckBed = true;
            truckOne.TruckBedSpace = 20;
            truckOne.HomeCountry = "United States of America";
            
            var suvOne = new SUV();
            suvOne.Make = "Toyota";
            suvOne.Model = "Foreunner";
            suvOne.Year = 2013;
            suvOne.NumberOfWheels = 4;
            suvOne.HomeCountry = "Japan";
            suvOne.Logo = "Toyota Tri-Circles";
            suvOne.HasWorkingEngine = true;
            suvOne.NumberOfSeats = 5;
            suvOne.CargoCapacity = 15;
            suvOne.HomeCountry = "Japan";

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
            var parkingGarage = new List<IVehicle>() {carOne,truckOne,suvOne};

            foreach (var vehicle in parkingGarage)
            {
                Console.WriteLine($"This {vehicle.Make} {vehicle.Model}, was manufactured in the year {vehicle.Year}, and it has {vehicle.NumberOfWheels} wheels. Is the vehicle currently functional: {vehicle.HasWorkingEngine}.");
                Console.WriteLine($"It's design originated in {vehicle.HomeCountry} and it's logo is the {vehicle.Logo}.\n");
            }
            
        }
    }
}
