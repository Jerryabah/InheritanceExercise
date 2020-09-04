using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public bool AreColdBlooded { get; set; }
        public bool BreatheThroughLungs { get; set; }
        public bool AreVertebrates { get; set; }
        public bool HaveScales { get; set; }

    }
}
