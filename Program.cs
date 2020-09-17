/*
    Author: Frank Samsock
    Date: 9/16/2020
    Descrpition: Console Program with Conditional Statements that Ask the user what grade they expect 
    to get in ISM 4300 and Based on what the user has entered, have the program display their Letter 
    grade per Syllabus for this course.
*/

using System;

namespace Samsock_Tech_Proj_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            //This asks the user to input their expected grade
            Console.WriteLine("What grade do you expect to get in ISM4300? (0-100)");

            //Use try catch to validate user input
            try
            {
                //Reads user input
                string input = Console.ReadLine();
                //used to store the score after parsed into a decimal
                decimal score = decimal.Parse(input);

                //Start the If statement
                if (score < 60)
                {
                    //Feedback given based on the user input for letter grade F
                    Console.WriteLine("Your expected letter grade is: F");
                    Console.WriteLine("TRY HARDER! YOU CANNOT LET PROFESSOR TRAVIS DOWN!");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
                else if ((score >= 60) && (score <= 62))
                {
                    // D- Feedback
                    Console.WriteLine("Your expected letter grade is: D-");
                    Console.WriteLine("You can do better than that!");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
                else if ((score >= 63) && (score <= 66))
                {
                    //D feedback
                    Console.WriteLine("Your expected letter grade is: D");
                    Console.WriteLine("You can do better than that!");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
                else if ((score >= 67) && (score <= 69))
                {
                    // D+ feedback
                    Console.WriteLine("Your expected letter grade is: D+");
                    Console.WriteLine("You are so close to a C!");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
                else if ((score >= 70) && (score <= 72))
                {
                    //C- feedback
                    Console.WriteLine("Your expected letter grade is: C-");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
                else if ((score >= 73) && (score <= 76))
                {
                    // C feedback
                    Console.WriteLine("Your expected letter grade is: C");
                    Console.WriteLine("Average");
                    Console.WriteLine("Press any button to exit the program");
                    Console.ReadKey(true);
                }
                else if ((score >= 77) && (score <= 79))
                {
                    //C+ Feedback
                    Console.WriteLine("Your expected letter grade is: C+");
                    Console.WriteLine("So close to a B!");
                    Console.WriteLine("Press any button to exit the program");
                    Console.ReadKey(true);
                }
                else if ((score >= 80) && (score <= 82))
                {
                    //B- Feedback
                    Console.WriteLine("Your expected letter grade is: B-");
                    Console.WriteLine("Good job!");
                    Console.WriteLine("Press any button to exit the program");
                    Console.ReadKey(true);
                }
                else if ((score >= 83) && (score <= 86))
                {
                    //B Feedback
                    Console.WriteLine("Your expected letter grade is: B");
                    Console.WriteLine("Good Job!");
                    Console.WriteLine("Press any button to exit the program");
                    Console.ReadKey(true);
                }
                else if ((score >= 87) && (score <= 89))
                {
                    // B+ feedback
                    Console.WriteLine("Your expected letter grade is: B+");
                    Console.WriteLine("Try and get an A! You have worked so hard!");
                    Console.WriteLine("Press any button to exit the program");
                    Console.ReadKey(true);
                }
                else if ((score >= 90) && (score <= 92))
                {
                    // A- feedback
                    Console.WriteLine("Your expected letter grade is: A-");
                    Console.WriteLine("Great job!");
                    Console.WriteLine("Press any button to exit the program");
                    Console.ReadKey(true);
                }
                else if ((score >= 93) && (score <= 96))
                {
                    // A feedback
                    Console.WriteLine("Your expected letter grade is: A");
                    Console.WriteLine("Well done!");
                    Console.WriteLine("Press any button to exit the program");
                    Console.ReadKey(true);
                }
                else if ((score >= 97) && (score <= 100))
                {
                    //A+ feedback
                    Console.WriteLine("Your expected letter grade is: A+");
                    Console.WriteLine("WAY TO GO! THIS IS THE BEST POSSIBLE LETTER GRADE!");
                    Console.WriteLine("Press any button to exit the program");
                    Console.ReadKey(true);
                }
                else
                {
                    // If 1-100 is not input this message will occur
                    Console.WriteLine("This grade is not possible...");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

            }   //END TRY 
            catch
            {
                Console.WriteLine("Please use a decimal data type and try again...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // END CATCH
        } // END OF MAIN
    } // END OF CLASS
} // END OF NAMESPACE
