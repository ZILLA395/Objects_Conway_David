using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Conway_David
{
    internal class Computer : IBootUp
    {
        // automatic properties to tell if the computer is on of what brand and what type
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }
        //constructer that inisilieses values on object creation
        public Computer( string brand, string type, bool isOn)
        {
            IsOn = isOn;
            Brand = brand;
            Type = type;
        } 
        // powesr on and off the computer and prints to console
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
             Console.WriteLine("The computer is shutting down!");
            }

        }
        // returns a string that decribes the computer
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a {Type} computer it is {IsOn}!";
        }
    }
}
