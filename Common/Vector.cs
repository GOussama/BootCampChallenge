using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BotFactory.Common.Tools
{
    class Vector
    {
        public Double x;
        public Double y;

        public Vector()
        {
        }

        public Vector(Double _x, Double _y)
        {
            x = _x;
            y = _y;
        }

        public static Vector FromCoordinates(Coordinates begin, Coordinates end)
        {

            Vector v = new Vector();
            v.x = end.X - begin.X;
            v.y = end.Y - begin.Y;

            return v;
        }
       

        public int Length()
        {
            return 0;
        }


    }
}
