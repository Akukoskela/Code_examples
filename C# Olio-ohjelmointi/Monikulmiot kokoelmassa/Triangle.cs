using System;
using System.Collections.Generic;
using System.Text;

namespace Monikulmiot_kokoelmassa
{
    class Triangle:Shape
    {
        private double length;
        private double width;

        public Triangle(string typeValue, string colorValue,double lengthValue, double widthValue):base(typeValue,colorValue)
        {
            this.length = lengthValue;
            this.width = widthValue;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Tyyppi: " + this.type + " Väri: " + this.color+" Pituus: "+this.length+" Leveys: "+this.width);
            GetArea();
            Console.WriteLine("\n");
        }

        public override double GetArea()
        {
            double area = (this.length * this.width) / 2;


            return area;
        }


    }
}
