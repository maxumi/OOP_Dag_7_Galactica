using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    //public enum PlanetType { Terrestrial, Giant, Dwarf, Gas_Giant }
    internal class Planet : SpaceObject
    {
        public enum PlanetType { Terrestrial, Giant, Dwarf, Gas_Giant }
        public PlanetType planetType { get; set; }
        public int Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public List<Moon> Moons = new List<Moon>();
        public Planet()
        {
            PositionNew.X = 0; PositionNew.Y = 0;
        }
        public void distance(Star star)
        {
            //distance=√((x_2-x_1)²+(y_2-y_1)²)
            double distance = Math.Sqrt(Math.Pow(star.PositionNew.X - PositionNew.X, 2) + Math.Pow(star.PositionNew.Y - PositionNew.Y, 2));

            Console.WriteLine("Distance to Star: " + distance);
        

        }
    }
}
