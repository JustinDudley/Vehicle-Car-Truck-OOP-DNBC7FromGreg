using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCarTruckLibrary {

    public class Truck : Vehicle {

        public bool Cap { get; set; }
        public bool  Diesel { get; set; }
        public string Bedsize { get; set; }

        public override string Print() {
            var cap = Cap ? "Cap" : "";
            var diesel = Diesel ? "Diesel" : "";
            return base.Print() + $" {cap} {diesel} {Bedsize} ";
        }

        public Truck(string vin, string make, string model, string trim, decimal price,
            bool cap, bool diesel, string bedsize) : base(vin, make, model, trim, price) {
            this.Cap = cap;
            this.Diesel = diesel;
            this.Bedsize = bedsize;
        }

    }
}
