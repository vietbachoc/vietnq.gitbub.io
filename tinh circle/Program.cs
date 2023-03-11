using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using tinh_circle.Properties;

namespace tinh_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* circle circl1 = new circle(30);
            circl1.Radius = 13;
            circle circl2 = new circle(10);

            Console.WriteLine("ban kinh C1 =" + circl1.Radius);
            Console.WriteLine("ban kinh C2 =" + circl2.Radius);*/
            Tringle triangle1 = new Tringle(5,6,7);
            if(triangle1.CheckValidTriangle() ==0)
            {
                Console.WriteLine("S=" + triangle1.Area());
            }
            else if(triangle1.CheckValidTriangle()==1)
            {
                Console.WriteLine("A or B or C <=0  ");
                
            }
            else if (triangle1.CheckValidTriangle()==2)
            {
                Console.WriteLine("INvalid Triangle");
            }
        }
    }
}
