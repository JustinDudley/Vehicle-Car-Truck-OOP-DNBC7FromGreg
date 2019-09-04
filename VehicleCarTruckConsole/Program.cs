using VehicleCarTruckLibrary;
using System;
using System.Collections.Generic;

namespace VehicleCarTruckConsole {

    class Program {

        void Run() {
            var vehicles = new List<Vehicle>();
            vehicles.Add(new Car("ABC123", "Honda", "Accord", "LX-E v6", 25000, false, false, false));
            vehicles.Add(new Car("DEF456", "Chevrolet", "Impala", "SE", 18000, false, false, false));
            vehicles.Add(new Car("GHI789", "Toyota", "Prius", "S", 19000, false, true, true));
            vehicles.Add(new Truck("987ZYX", "Ford", "F-150", "Lariat", 38000, true, false, "7ft"));
            vehicles.Add(new Truck("654WVU", "Chevrolet", "1500", "Silverado", 43000, false, false, "8ft"));
            vehicles.Add(new Truck("321SRQ", "Honda", "Ridgeline", "S", 44000, false, false, "8ft"));

            foreach(var vehicle in vehicles) {
                Console.WriteLine(vehicle.Print());
            }
        }


        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
        }
    }
}
