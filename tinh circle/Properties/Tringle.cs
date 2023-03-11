using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tinh_circle.Properties
{
    internal class Tringle
    {
       public Tringle() { }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public Tringle(double A, double B, double C)
        {
            this.A = A;
            this.B = B;         
            this.C = C;
        
        }
        public String Desc()// ham tra ve loai tam giac 
            /* 1 tam giac thuong
               2 tam giac vuong
               3 tam giac can
               4 tam giac deu
               5 tam giac vuong + can */
        {
            // if else hoac switch - case .
            return "tam giac vuong";

        }
        public int CheckValidTriangle()
        {
            
            int ErrorCode  = 0;
            if (A <= 0 || B <= 0 || C <= 0)
            {
                ErrorCode = 1;
            }
            if ((A + B <= C) || (B + C <= A) || (C + A <= B))
            {
                ErrorCode = 2;

            }
            return ErrorCode;
        }
        public double Perimeter()
        {
            return A* B * C;
        }
        public double Area()
        {
            double P = (A+B+C)/2;
            return Math.Sqrt(P * (P - A) * (P-B)*(P-C));
        }

    }
}
