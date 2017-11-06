using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable12_LabAlt10_CarClass
{
    class Validator
    {
        //Data
        private string msg;
        private string userChoice;
        public string Msg
        {
            set { msg = value; }
        }

        //Constructors
        public Validator()
        {
            msg = "";
        }

        //Methods
        public string GetUserInput ()
        {
            Console.Write(msg);
            userChoice = Console.ReadLine();

            //Validate input
            if (string.IsNullOrEmpty(userChoice) || (!int.TryParse(userChoice, out int junk) && userChoice.ToLower() != "q" && userChoice.ToLower() != "y" && userChoice.ToLower() != "n"))
            {
                Console.WriteLine("ERROR: Please make a valid entry or type 'Q' to exit.");
                GetUserInput();
            }

            if (userChoice.ToLower() == "q")
            {
                return null; //use null for quitting even though q is given
            }
            //else if (userChoice.ToLower() == "n")
            //{
            //    return "n";
            //}
            else
            {
                return userChoice;
            }
        }
    }
}
