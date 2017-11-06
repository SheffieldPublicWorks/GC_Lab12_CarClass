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
            arrCarDB.Add(new Car("Ford",      "Edge",     2018, 38_984.50));
            arrCarDB.Add(new Car("Tesla",     "Three",    2017, 40_000));
            arrCarDB.Add(new Car("Dodge",     "Ram 1500", 2017, 40_014.12));
            arrCarDB.Add(new Car("Chevrolet", "Corvette", 2019, 80_564.15));
            arrCarDB.Add(new Car("Ford",      "Exploder", 2019, 999_999.99));
            arrCarDB.Add(new UsedCar("Toyota",    "Camry",    2008, 8_000.71, 154_500));
            arrCarDB.Add(new UsedCar("Chevrolet", "Camaro",   1968, 57_850.78, 65_555));
            arrCarDB.Add(new UsedCar("Misfit",    "Psycho78", 1978, 37_664.15, 666_666));

            //initialize unique record id's to run parallel with table of Cars
            ArrayList arrRecIDs = new ArrayList();
            for (int i = 0; i < arrCarDB.Count; i++)
            {
                arrRecIDs.Add(i + 1); //display record #'s start at 1
            }
            /**************************************/

            Console.WriteLine("/***************************/");
            Console.WriteLine("/* Chirpus' Chill Chassis' */");
            Console.WriteLine("/***************************/");
            Console.WriteLine();

            // 1) open a transaction 2) validate input as program interacts with the user
            bool openTransaction = true;
            Validator validInput = new Validator();
            string userChoice;
            while (openTransaction)
            {
                if (arrCarDB.Count == 0)
                {
                    Console.WriteLine("You bought the whole lot!!!");
                    break;
                }
                else
                {
                    DisplayDb(arrRecIDs, arrCarDB);
                    validInput.Msg = "Please enter the vehicle # of the vehicle would you like to consider? ('Q' to exit) ";
                    userChoice = validInput.GetUserInput();

                    if (string.IsNullOrEmpty(userChoice))
                    {

                        openTransaction = false;  //this outcome means the user has elected to quit the program
                    }
                    else if (!int.TryParse(userChoice, out int junk) || int.Parse(userChoice) < 1 || int.Parse(userChoice) > arrRecIDs.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("THAT IS NOT A CHOICE AT THIS TIME.");
                        Console.WriteLine();
                    }
                    else  //at this point the user's input is a valid entry
                    {
                        DisplayDb((Car)arrCarDB[int.Parse(userChoice) - 1]);
                        validInput.Msg = "Would you like to purchase this fine vehicle? ('Y/N', or 'Q' to exit) ";
                        userChoice += validInput.GetUserInput();

                        if (string.IsNullOrEmpty(userChoice.Substring(1)))
                        {
                            openTransaction = false;
                        }
                        else if (userChoice.Substring(1).ToLower() == "y")
                        {
                            Console.WriteLine("\r\nThank you so much for your purchase! A finance representative will be in touch soon.\r\n");
                            UpdateDb(int.Parse(userChoice.Substring(0, 1)), arrCarDB, arrRecIDs);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for your patronage! Hope to see you soon.");
        }
        
        public static void DisplayDb (ArrayList arrLst1, ArrayList arrLst2)
        {
            Console.WriteLine("Veh# Make       Model      Year        Price    Status Mileage");
            Console.WriteLine(new string('=', 62));
            for (int i = 0; i < arrLst1.Count; i++)
            {
                Console.Write($"{arrLst1[i]}:   ");
                Console.WriteLine(arrLst2[i]);
            }
        }

        public static void DisplayDb (Car car)
        {
            Console.WriteLine($"Thank you:");
            Console.WriteLine(car.ToString());
        }

        public static void UpdateDb (int purchase, ArrayList arrLst1, ArrayList arrLst2)
        {
            arrLst1.RemoveAt(purchase - 1);

            //regenerate the record id's
            arrLst2.Clear();
            for (int i = 0; i < arrLst1.Count; i++)
            {
                arrLst2.Add(i + 1);
            }
        }
    }
}
