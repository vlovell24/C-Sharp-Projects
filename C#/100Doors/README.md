100 Doors

Problem from Rosetta Code. You have 100 doors, that are all closed. You are going to pass the doors the first time, and open them all. The second pass will open every other door, the third will open every third. You will complete a total of 100 passes (for each of the doors). Once you have completed 100 passes, print out the state of all of the doors. 

This problem explicitly sets the door array at 100, with all of them closed (that is what the problem asks for). The final answer is a print out of the state of every single door, once the 100th pass is completed. If you check closely, the only doors that are open are square roots (1, 4, 9, 16, 25, 36, 49, 64, 81 and 100). Knowing this, there are many different ways that the program can be written out (using Math.Sqrt()), however, the problem DID NOT ask for a solution using Math.Sqrt(). Instead, it asked to literally loop through the doors and change their state, and then return that state.
