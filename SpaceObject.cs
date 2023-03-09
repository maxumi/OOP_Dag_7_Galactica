using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal abstract class SpaceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position PositionNew { get; set; }
        public SpaceObject()
        {
            Position positionNew = new Position();
            PositionNew = positionNew;
        }

        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Position() { X = 0; Y = 0; }
            public Position(int x, int y) { X = x; Y = y; }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

    }
}
