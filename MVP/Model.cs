using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class Model
    {
        public static int countObject { set; get; }
        double x;
        double y;

        public Model(double x, double y)
        {
            countObject++;
            this.x = x;
            this.y = y;
        } 
        ~Model()
        {
            countObject--;
        }

        
        
        public double DistancePointToPoint()
        {
            if (x>y)
            {
                return x - y;
            }
            else
            {
                return y - x;
            }
        }
    }
}
