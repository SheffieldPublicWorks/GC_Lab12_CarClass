using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable12_LabAlt10_CarClass
{
    class Car
    {
        private string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car ()
        {
            make  = "Scobie";
            model = "Hellride";
            year  = 1975;
            price = 0.01;
        }

        public Car (string make, string model, int year, double price)
        {
            this.make  = make;
            this.model = model;
            this.year  = year;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{make} {model} {year} {price, 8:C}";
        }
    }
}
