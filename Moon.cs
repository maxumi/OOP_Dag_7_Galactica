using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal sealed class Moon : Planet
    {
        PlanetType Orbiting { get; set; }
        public void distance(Planet planet)
        {
            double distance;
            //Distance from planet to the moon
            distance = Math.Sqrt(Math.Pow(planet.PositionNew.X - PositionNew.X, 2) + Math.Pow(planet.PositionNew.Y - PositionNew.Y, 2));
            Console.WriteLine("Distance to Star:" + distance);
        }
    }
}
