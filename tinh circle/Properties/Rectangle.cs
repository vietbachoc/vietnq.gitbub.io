using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinh_circle.Properties
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle()
        {

        }
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public double Perimeter()
        {
           return Width *Height; 
        }
        public double Area()
        {
            return (Width + Height)*2;
        }
       
    }
}
