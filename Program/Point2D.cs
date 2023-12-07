using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public struct Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }
    
        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }

      
    }

    public class Distance
    {
     public static float  CalculateDistance(Point2D p, Point2D b)
    {
        float deltaX=p.X-b.X;
        float deltaY=p.Y-b.Y;

        return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}
}
