using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable12_LabAlt10_CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrCarDB = new ArrayList();
            /**************************************/
            //              Car DB                //
            /**************************************/
            arrCarDB.Add(new Car("Chevrolet", "Camaro",    2018, 57_850.78));
            arrCarDB.Add(new Car("Ford",      "Edge",      2018, 38_984.50));
            arrCarDB.Add(new Car("Tesla",     "Three",     2017, 40_000));
            arrCarDB.Add(new Car("Dodge",     "Ram 1500",  2017, 40_014.12));
            arrCarDB.Add(new Car("Chevrolet", "Corvette",  2019, 80_564.15));
            arrCarDB.Add(new Car("Toyota",    "Camry",     2018, 22_000.71));
            arrCarDB.Add(new Car("Ford",      "Exploder",  2019, 999_999.99));
            arrCarDB.Add(new Car("Misfit",    "Psycho78", 2019, 37_664.15));
        }
    }
}
