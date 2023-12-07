using System;
using System.Reflection.Metadata.Ecma335;

namespace Program
{
    internal class Rectangle
    {
        private float length, width;

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;

        }
        public float CalculateArea()
        {
            return this.length * this.width;
        }

    }
}
