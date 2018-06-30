using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Use an array initializer list to create a 4-element array to store the names of 4 seasons. 
//Use a while loop to display the name of each season.
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] seasons = new[] { "Winter", "Spring", "Summer", "Fall" };
            int count = 0;
            while (count < 4)
            {
                { Console.WriteLine($"{seasons[count]}"); }
                ++ count;
            }
            
        }
             
        }
    }
  
            
        
        