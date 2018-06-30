//	Create a for loop that goes from 1-10 (output both 1 and 10 as well) using a variable named i as the counter.  
//Each time through the loop, output whether or not the variable is even or odd (3 Points). 
//The output should read: 1 is odd, 2 is even, 3 is odd, etc.

// Hint: Use and if-else statement and the modulus % operator to determine whether the variable is even or odd.
// Example: if ((i % 2) == 0) // it’s even

using System;


class DoWhileCounter
{

    static void Main()
    {
        for (int i = 1; i < 11; i++)
        {
            if ((i % 2) == 0)
            {
                Console.WriteLine($"{i}" + " is even");
            }

            else if ((i % 2) != 0)
            {



                { Console.WriteLine($"{i}" + " is odd"); }

            }
        }
    }
}