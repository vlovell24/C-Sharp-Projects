using System;

namespace AScoringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //bob and ericas scores. M is medium, E is easy and H is hard. These are stored as strings, and wer
            //are going to pretend that only M, E and H can be entered.
            string erica = "MEH";
            string bob = "MHM";
            //the two score initializers 
            int ericaScore = 0;
            int bobScore = 0;
            winnerWinnerChickenDinner(erica, bob);

           void winnerWinnerChickenDinner(string erica, string bob)
            {
                //turning each string into a single letter array
                char[] ericaLetter = erica.ToCharArray();
                char[] bobLetter = bob.ToCharArray();
                //erica's loop to determine what 'score' to calculate per letter
                for (int i = 0; i < ericaLetter.Length; i++)
                {
                    if (ericaLetter[i].Equals('E'))
                    {
                        ericaScore += 1;
                    }else if(ericaLetter[i].Equals('M'))
                    {
                        ericaScore += 2;
                    }else if(ericaLetter[i].Equals('H'))
                    {
                        ericaScore += 3;
                    }                
                }
                //bob's loop to determine what 'score to calculate per letter
                for (int j = 0; j < bobLetter.Length; j++)
                {
                    if (bobLetter[j].Equals('E'))
                    {
                        bobScore += 1;
                    }
                    else if (bobLetter[j].Equals('M'))
                    {
                        bobScore += 2;
                    }
                    else if (bobLetter[j].Equals('H'))
                    {
                        bobScore += 3;
                    }
                }
                //the if statement that compares the scores, and determines the winner
                if (ericaScore == bobScore)
                {
                    Console.WriteLine("Its a tie!");
                }else if (ericaScore > bobScore)
                {
                    Console.WriteLine("Erica is the winner!");
                }else if (ericaScore < bobScore)
                {
                    Console.WriteLine("Bob is the winner!");
                }
            }







        }
    }
}
