using System;
using System.Collections.Generic;
using System.Text;

namespace Monikulmiot_kokoelmassa
{
    class Rectangle:Shape
    {
        private double length;
        private double width;

        public Rectangle(string typeValue, string colorValue,double lengthValue,double widthValue):base(typeValue,colorValue)
        {
            this.length = lengthValue;
            this.width = widthValue;
        }

   

        public override double GetArea()
        {
            double area = this.length * this.width;


            return area;

        }

        public override void GetInfo()
        {
            Console.WriteLine("Tyyppi: " + this.type + " Väri: " + this.color+" Pituus: "+this.length+" Leveys: "+this.width);
            GetArea();
            Console.WriteLine("\n");
        }
       
        
    }
}
