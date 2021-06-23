using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    public class Taco_Bell : ITrackable 
    {
        //created a taco bell class that inherits from Itrackable, Then made a parameterized constructor of it, then had to creat a Point struct to instantiate it.
        public string Name { get; set; }
        public Point Location { get; set; }

        public Taco_Bell(string name, double latitude, double longitude) 
        {
            Name = name;
            Location = new Point(latitude, longitude);
        }
    }
}
