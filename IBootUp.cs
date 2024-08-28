using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Conway_David
{

    // a bool to cheak if the computer is on or off
    internal interface IBootUp
    {
      
      public bool IsOn { get; set; }
        // method to power on and off the computer
        public void PowerOnOff();

    }
}
