using System;
using CarHarjoitus;

namespace CarHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on autoharjoitus");
            Console.ReadLine();

            Car auto1 = new Car();              // luodaan kaksi oliota nimeltä "auto1" ja "auto2"
            Car auto2 = new Car();

            auto1.AskData();                   //käytetään metodia "AskData()" ja täytetään olion kentät
            auto1.ShowCarInfo();    
            auto1.Accelerate(10);
            auto1.ShowCarInfo();
            auto1.Brake();
            auto1.ShowCarInfo();
            

            auto2.AskData();
            auto2.ShowCarInfo();
            auto2.Accelerate(20);
            auto2.ShowCarInfo();
            auto2.Brake();
            auto2.ShowCarInfo();
        }

           


            
        
    }
}
