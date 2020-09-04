
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandAirSea = "Air";
            Age = 0;
        }
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public bool WingColor { get; set; }
        public bool CanLayEggs { get; set; }
        public bool UseBeakToEat { get; set; }
        public bool HasFeathers { get; set; }


    }
}
