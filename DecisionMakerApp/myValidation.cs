/*Class name: My validation
  Programmer: Ivoire Morrell
  Date: October 14th, 2019
  Description: This class is used to validate user input
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMakerApp
{
    class myValidation
    {
 
        public static int getIntWithinRange(int min, int max)
        {
            //Create variable that will return the users input if it is true
            int numberValue = 0;

            //Use boolean to control while loop
            bool isValid = false;

            //While loop
            while (isValid == false)
            {

                //Propmt user to enter a integer
                Console.WriteLine("Please enter a integer \n");

                numberValue = int.Parse(Console.ReadLine());

                Console.WriteLine();

                //use if else loop to check for the number value to see if its in 
                //correct range
                if (numberValue < min)
                {
                    Console.WriteLine("Error! Number must be greater than " + min + ". \n");
                
                }
                else if (numberValue > max)
                {
                    Console.WriteLine("Error! Number must be less than " + max + ". \n");
                }
                else
                {
                    isValid = true;
                }
            }
            return numberValue;
        }

        //this method is used to determine if the user wants to continue within a loop
        public static bool getContinue()
        {
            //create variables
            String choice;
            bool ok = true;
            bool result = true;

            //create while loop to determine if user wants to continue
            while (ok)
            {
                Console.WriteLine("Continue? (y/n): \n");

                //retrieve user input
                choice = Console.ReadLine();

                //determine the users input and return corresponding message
                if (choice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    //user wants to continue. exit the while loop and return true
                    ok = false;
                    result = true;
                }
                else if (choice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    //user does not want to continue
                    ok = false;
                    result = false;
                }
                else
                {
                    //user did not enter y or n
                    Console.WriteLine("Error! Please enter Y or N. Please enter correct input \n");

                }

            }

            return result;
        }

        //the getNumber response method is used to determine whether a number is even, odd, and prints out corresponding message
        public static string getResponse(int number)
        {
            //create variable to return
            string response;
            
            //output the number and corresponding message based off the number
            if ((number % 2 == 0) && (number >= 1 && number <= 25))
            {
                //output the number and that its less then 25
               response = "Even and less then 25 \n";
            }
            else if ((number % 2 == 0) && (number >= 26 && number <= 60))
            {
              response = "Even \n";
            }
            else if ((number % 2 == 0) && (number > 60))
            {
                response = number.ToString() + " and even \n";
            }
            else
            {
                response = number.ToString() + " and odd \n";
            }

            return response;
        }


    }
}
