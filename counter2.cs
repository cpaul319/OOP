//Using the following pseudocode, use an if…else if…else statement to output a temperature description:
//Have the user enter a temperature as in integer
//If the temperature is < 32: freezing
 // < 50: cold
			  //< 70: mild
			 // < 90: warm
			  //default: hot


using System;
class Addition
{
    static void Main()
    {

     int temp; //temp variable

        // the <= need to be used otherwise,32, 50, 70 and 90 cause an error
        Console.Write("Enter the temperature: ");

        temp = int.Parse(Console.ReadLine());

        if (temp <=32) { Console.WriteLine("It's Freezing"); }

        else if ((temp <= 50) && (temp > 32)) { Console.WriteLine("It's cold"); }

        else if ((temp <= 70) && (temp > 50)) { Console.WriteLine("It's mild"); }

        else if ((temp <= 90) && (temp > 70)) { Console.WriteLine("It's warm"); }

        else if (temp > 90) { Console.WriteLine("It's hot"); }



    }
}

