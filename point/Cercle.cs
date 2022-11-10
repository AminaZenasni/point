using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point
{
    internal class Cercle
    {
       public  class Cercle1
        {
            private Point centre;
            private int rayon;

            public int GetRayon()
            {
                return rayon;
            }
            public Point GetCentre()
            {
                return centre;
            }
            public Cercle(point centre, int rayon =0)
            {
                centre = new point(0, 0);
                this.centre = centre;
                this.rayon = rayon;
            }
           public double  circonférence (double diamètre){
           return Math.PI * diamètre;
           }
           
            public double AiR (double rayon)
    {
        return Math.PI * rayon * rayon;
    }
            
        }
    }
}
        
