// See https://aka.ms/new-console-template for more information
using System;

// Namespaces
namespace traversorypractice{
    //main class
    class Program{
        //entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run get app info
            GreetUser();// greet user
            CheckTheGame(); // checking if a user gets or not the number

        static void CheckTheGame(){
                // init correct number
                // int correctnumber = 7;
                Random random = new Random();
                int correctnumber = random.Next(1, 10);
                // init guess var
                int guess = 0;

                // tell the user to guess the number

                Console.WriteLine("Guess the number");

                // while guess is not correct
                while (guess != correctnumber)
                {
                    // Get users input
                    string input = Console.ReadLine();


                    //Make sure its input
                    if (!int.TryParse(input, out guess))
                    {


                    }

                    // cast to input
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctnumber)
                    {
                        // change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // output
                        Console.WriteLine("wrong number , please try again");

                        // reset color
                        Console.ResetColor();

                    }

                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are correct");
                Console.ResetColor();


            }
        }
        static void GetAppInfo(){
            // set app vars
            string appName = "Number Guessor";
            string appVersion = "1.0.0";
            string appAuthor = "Bruk";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // output
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            // reset color
            Console.ResetColor();
        }
        static void GreetUser(){
            // ask users name
            Console.WriteLine("Enter your name:");

            // lest get users input

            string inputName = Console.ReadLine();

            // lets return users info
            Console.WriteLine("hello {0} : lets Play a game", inputName);

        }
    }
}


