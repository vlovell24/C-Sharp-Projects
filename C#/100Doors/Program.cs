using System;

namespace _100Doors
{
    class Program
    {
        static void Main(string[] args)
        {
            //this problem calls for 100 doors, so I set the array manually. You could change the doorState array, and 
            //make it create itself on the fly, however, the problem did not ask for that.

            //the doorState array. Initially, all 100 doors are set to closed
            String[] doorState = { "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed",
                                    "closed", "closed", "closed", "closed", "closed"};
            //calling the changeState method
            changeState();

             void changeState()
            {
                //the outside iteration; this must start at 1 rather than 0 (because we are using j in a multiplication loop
                //below; if it started at zero, then iteration one wouldn't change the door states on the first pass)
                for (int j = 1; j < doorState.Length + 1; j++)
                {
                    //the inside iteration that sees if i is divisible by j. If so, then the door state is reversed.
                    for (int i = 0; i < doorState.Length; i++)
                    {
                        if((i + 1) % j == 0)
                        {
                            if (doorState[i] == "open")
                            {
                                doorState[i] = "closed";
                            } else if (doorState[i] == "closed")
                            {
                                doorState[i] = "open";
                            }
                        }
                    }
                }
                Console.WriteLine(string.Join("\n", doorState));

            }

        }
    }
}
