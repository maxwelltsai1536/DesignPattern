using System.Collections.Generic;

namespace Flyweight
{
    public abstract class Chess
    {
        public string Color { set; get; }
        public int[] Coordinate { set; get; }

        public abstract bool Move();
    }
}
