using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    //public enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
    internal class Star : SpaceObject
    {
        public enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
        public Startype Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> Planets = new List<Planet>();
        public Star()
        {
            PositionNew.X = 0; PositionNew.Y = 0;
        }
    }
}
