using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    public class Circle
    {
        //properties
        private double Radius { get; set; }
       
        //public Diameter {get;set;}


        //constructors
        public Circle(double radius)
        {
            Radius = radius;
            
       

        }

        //methods
        public  double CalculateDiameter()
        {
            
            double diameter = 0;
            diameter = 2 * (Radius);
            return diameter;
        }
        public double CalculateCircumfrence()
        {
           
            double circumfrence = 0;
            circumfrence = 2 * (Math.PI * Radius);
            return circumfrence;
            
        }
        public double CalculateArea()
        {
            double area = 0;
            area = Math.PI* (Math.Pow(Radius,2));
            return area;
        }
        public void Grow()// we need it to perform a function but we don't need it to display
        {
           double growradius = 0;
            growradius = 2 * (Radius);
            
            
        }

        public double GetRadius()
        {
            double finalRadius = 0;
            for (int i =0; i< Radius; i++)
            {
                finalRadius += i;
            }
            return finalRadius;
        }
    }
}
