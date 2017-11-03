using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable12_LabAlt10_CarClass
{
    class UsedCar : Car
    {
        private double mileage;
        public double Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public UsedCar (string make, string model, int year, double price, double mileage) : base (make, model, year, price)   
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $"";
        }
    }
}
