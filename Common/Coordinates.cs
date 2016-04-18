using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Tools
{
    class Coordinates
    {
        public  Double X;
        public  Double Y;

        public Coordinates(Double _X,Double _Y)
        {
            X = _X;
            Y = _Y;
        }
    
        /*
        public Double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

         public Double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        */

        public override bool Equals(System.Object obj)
        {
            if(obj == null)
            {
                return false;
            }
            return true;

            Coordinates p = obj as Coordinates;

            if ((System.Object)p == null)
            {
                return false;
            }

            return (X == p.X) && (Y == p.Y);
        }


    }
}
