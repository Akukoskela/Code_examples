using System;
using System.Collections.Generic;
using System.Text;

namespace Monikulmiot_kokoelmassa
{

    abstract class Shape:IComparable
    {
        protected string type;
        protected string color;


        public Shape(string typeValue, string colorValue)
        {
            this.type = typeValue;
            this.color = colorValue;
        }

        public abstract double GetArea();




        public abstract void GetInfo();




        public void GetColor()
        {

        }


     

        public int CompareTo(object obj)  //määritellään miten Sort() metodi toimii
        {
            Circle testiympyrä = new Circle("", "", 0);  //luodaan testi olioita jotaa voidaan varmistaa parametrina annetun olion tyyppi
            Triangle testikolmio = new Triangle("", "",0, 0);
            Rectangle kestisuorakulmio = new Rectangle("", "", 0, 0);


            if(obj.GetType()==testiympyrä.GetType())
            {
                Circle objCircle = obj as Circle;
                return this.color.CompareTo(objCircle.color);
            }
            else if(obj.GetType()==testikolmio.GetType())
            {
                Triangle objTriangle = obj as Triangle;
                return this.color.CompareTo(objTriangle.color);
            }
            else if(obj.GetType()==kestisuorakulmio.GetType())
            {
                Rectangle objRectangle = obj as Rectangle;
                return this.color.CompareTo(objRectangle.color);
            }
            else
            {
                return 0;
            }
        }
    }
}
