using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCarTruckLibrary {

    public class Car : Vehicle {

        public bool Convertible { get; set; }
        public bool Hatchback { get; set; }
        public bool Hybrid { get; set; }

        public override string Print() {
            var convertible = Convertible ? "Convertible" : "";
            var hatchback = Hatchback ? "Hatchback" : "";
            var hybrid = Hybrid ? "Hybrid" : "";
            return base.Print() + $" {convertible} {hatchback} {hybrid} ";
        }

        public Car(string vin, string make, string model, string trim, decimal price, 
            bool convertible, bool hatchback, bool hybrid) : base(vin, make, model, trim, price) {
            this.Convertible = convertible;
            this.Hatchback = hatchback;
            this.Hybrid = hybrid;
        }
    }
}
