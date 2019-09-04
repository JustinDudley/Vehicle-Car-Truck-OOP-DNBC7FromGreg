using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCarTruckLibrary {

    public class Vehicle {

        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public decimal Price { get; set; }

        public virtual string Print() {
            return $"{this.GetType().Name, -8} :: {Vin, -8} {Make} {Model} {Trim} {Price.ToString("C")}";
        }

        public Vehicle(string vin, string make, string model, string trim, decimal price) {
            this.Vin = vin;
            this.Make = make;
            this.Model = model;
            this.Trim = trim;
            this.Price = price;
        }
    }
}
