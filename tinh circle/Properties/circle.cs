using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tinh_circle.Properties
{
    internal class circle
    {
        const float PI = 3.14f;

        public double Radius { get; set; } 
        public circle() { }
        
        public circle(double radius)
        {
            Radius = radius;
            //gan gia tri Radius( ban kinh cua duong tron` = gia tri radius truyen vao bang` Constructor)

        }

        public double Perimeter()
        {

            return 2*PI*Radius; 
        }
        public double Area() 
        {
            
            return PI*Radius*Radius;
        }
        public double Diameter() 
        { 
            return 2*Radius; 
        }

        
       



    }
}
