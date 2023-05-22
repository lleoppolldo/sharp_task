using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace spacelib
{
    public interface ICelestialObject { string Name { get; set; } string GetInfo(); string Explode(); }
    public abstract class Star : ICelestialObject
    {
        public string Name { get; set; }
        public int Mass { get; set; }
        public int Age { get; set; }
        public abstract string GetInfo();
        public abstract string Explode();
    }

    public class RedGiant : Star
    {
        public int Radius { get; set; }
        public override string GetInfo()
        {
            return $"Red giant star {Name} has a mass of {Mass} and a radius of {Radius}.";
        }
        public override string Explode()
        {
            return $"Red giant star {Name} has exploded!";
        }
    }

    public class DwarfStar : Star
    {
        public int Temperature { get; set; }
        public override string GetInfo()
        {
            return $"Dwarf star {Name} has a mass of {Mass} and a temperature of {Temperature} K.";
        }
        public override string Explode()
        {
            return $"Dwarf star {Name} is not massive enough to explode.";
        }
    }

    public class SuperGiantStar : Star
    {
        public int Lumiosity { get; set; }
        public override string GetInfo()
        {
            return $"Supergiant star {Name} has a mass of {Mass} and a lumiosity of {Lumiosity}.";
        }
        public override string Explode()
        {
            return $"Supergiant star {Name} has exploded in a supernova!";
        }
        public string GoHypernova()
        {
            return $"Supergiant star {Name} has gone hypernova!!";
        }
    }
}