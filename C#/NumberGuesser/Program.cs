using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Valerie";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game....", input);

            //set the correct number and make it random each time
            Random randomNumber = new Random();
            int correctNumber = randomNumber.Next(1, 11);

            //Init guess counter
            int guesses = 0;

            Console.WriteLine("Guess the number from 1 to 10");
            compareGuess();


            void compareGuess()
            {
                try
                {
                    int playerGuess = Convert.ToInt32(Console.ReadLine());

                    if (guesses < 4)
                    {
                        if (playerGuess != correctNumber)
                        {
                            Console.WriteLine("try again");
                            guesses += 1;
                            compareGuess();
                        }
                        else
                        {
                            Console.WriteLine("Your Correct");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You ran out of guesses");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Must be a number, try again");
                    compareGuess();
                }
                
            }
        }
    }
}
