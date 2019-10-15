/*Class name: Decision Maker Application
  Programmer: Ivoire Morrell
  Date: October 15th, 2019
  Description: The decison maker application takes user integer input 
  (integer between 1 and 100) and tells the user whether or not the number is even, odd, and between
  a specific range
 */

using System;

namespace DecisionMakerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables that will be used to carry out program fuctionality
            int number;
            int min = 1;
            int max = 100;
            bool ok = true;
            string name;
            string response;

            Console.WriteLine("Welcome to the decision maker app. \n");

            //ask the user for their name
            Console.WriteLine("What is your name? \n");

            //enter user name
            name = Console.ReadLine();

            Console.WriteLine();

            //use while loop to control if the user wants to continue running program
            while (ok)
            {
                //Welcome the user to the program
                Console.WriteLine("Please enter a number between 1 and 100 " + name);

                Console.WriteLine();

                //use the getIntWithinRange from the myValidation class to ensure number is between 1 and 100 
                number = myValidation.getIntWithinRange(min, max);

                response = myValidation.getResponse(number);

                //print the response
                Console.WriteLine(response);

                //use getContinue method to determine if user wants to continue
                ok = myValidation.getContinue();

                Console.WriteLine();
            }

            //if you make it here to your code, the user has decided exit the program. Close program with proper ending statement
            Console.Write("Until next time, Dueces!");
        }
    }
}
