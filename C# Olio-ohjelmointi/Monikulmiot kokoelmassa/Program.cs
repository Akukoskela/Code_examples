using System;
using System.Collections;
using System.Collections.Generic;

namespace Monikulmiot_kokoelmassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monikulmiot kokoelmassa harjoitus!\n");

            //luodaan homogeenisiä listoja jokaiselle kuviolle oma

            List<Shape> circles = new List<Shape>();
            List<Shape> triangles = new List<Shape>();
            List<Shape> rectangles = new List<Shape>();

            //luodaan olioita

            Shape ympyrä1 = new Circle("Ympyrä", "keltainen", 5);
            Shape ympyrä2 = new Circle("Ympyrä", "Sininen", 10);
            Shape ympyrä3 = new Circle("Ympyrä", "Punainen", 7);

            Shape kolmio1 = new Triangle("Kolmio", "Keltainen", 5, 6);
            Shape kolmio2 = new Triangle("Kolmio", "Sininen", 5, 10);
            Shape kolmio3 = new Triangle("Kolmio", "Violetti", 2, 4);

            Shape suorakulmio1 = new Rectangle("Suorakulmio", "Punainen", 2, 4);
            Shape suorakulmio2 = new Rectangle("Suorakulmio", "Keltainen", 5, 10);
            Shape suorakulmio3 = new Rectangle("Suorakulmio", "Vihreä", 4, 6);

            //lisätään luodut oliot listoihin

            circles.Add(ympyrä1);
            circles.Add(ympyrä2);
            circles.Add(ympyrä3);

            triangles.Add(kolmio1);
            triangles.Add(kolmio2);
            triangles.Add(kolmio3);

            rectangles.Add(suorakulmio1);
            rectangles.Add(suorakulmio2);
            rectangles.Add(suorakulmio3);

            //Luodaan sekalista "monikulmiot" ja lisätään oliot

            ArrayList monikulmiot = new ArrayList();
            monikulmiot.Add(ympyrä1);
            monikulmiot.Add(ympyrä2);
            monikulmiot.Add(ympyrä3);

            monikulmiot.Add(kolmio1);
            monikulmiot.Add(kolmio2);
            monikulmiot.Add(kolmio3);

            monikulmiot.Add(suorakulmio1);
            monikulmiot.Add(suorakulmio2);
            monikulmiot.Add(suorakulmio3);


            
            //Tulostetaan listan olioiden tiedot GetInfo() metodilla

            Console.WriteLine("monikulmiot lista:\n");
            foreach (Shape obj in monikulmiot)
            {
                
                obj.GetInfo();
               
            }

            // tulostetaan listan ympyrä oliot
            Console.WriteLine("Ympyrät listassa monikulmiot\n");
            foreach (Shape obj in monikulmiot)
            {
                if (obj is Circle)
                {
                    obj.GetInfo();
                }

            }

            //järjestetään listan oliot listaan Sort() metodin avulla siten miten CompareTo() metodissa on määritelty

            monikulmiot.Sort();

            Console.WriteLine("monikulmiot lista:\n");
            foreach (Shape obj in monikulmiot)
            {

                obj.GetInfo();

            }





        }
       
    }

         
}
