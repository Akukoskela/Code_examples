using System;
using System.Collections.Generic;
using System.Text;

namespace Monikulmiot_kokoelmassa
{
    class Circle : Shape
    {
        private double radious;
        

        public Circle(string typeValue, string colorValue, double radiousValue):base(typeValue,colorValue)
        {
            this.radious = radiousValue;
        }

         public override void GetInfo()
        {
            Console.WriteLine("Tyyppi: "+this.type+" Väri: "+this.color+" Säde: "+this.radious);
            GetArea();
            Console.WriteLine("\n");
        }

        public override double GetArea()
        {
            double pi = 3.14159;
            double area = 2 * pi * this.radious;


            return area;
        }


    }
}
