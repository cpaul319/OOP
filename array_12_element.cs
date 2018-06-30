using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Array12Element
    {
        static void Main(string[] args)
        {
            {
                int[] array = new int[12]; 
                {
                    String[] month = new string[array.Length];
                    month[0] = "January";
                    month[1] = "Febraury";
                    month[2] = "March";
                    month[3] = "April";
                    month[4] = "May";
                    month[5] = "June";
                    month[6] = "July";
                    month[7] = "August";
                    month[8] = "September";
                    month[9] = "October";
                    month[10] = "November";
                    month[11] = "December";
                    {
                        for (int counter = 0; counter < array.Length; ++counter)
                            
                        {
                            Console.WriteLine("{0}{1,12}", "Month " + $"{1 + counter}"+ " is ", $"{month[counter]}");
                        }
                    }
                }
            }
        }
    }    }