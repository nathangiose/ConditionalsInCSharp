using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12) //Boolean expression. 
            {
                Console.WriteLine("It's morning"); //If both conditions are met, this line will print

            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's midday");

            }
            else //This condition will always run if none of the previous conditions are met
            {
                Console.WriteLine("It is evening");

            }
        }
    }
}
