using System;
using System.Collections.Generic;
using System.Text;

namespace CarHarjoitus
{
    class Car               //luokka
    {
        public string brand = "";
        public double speed = 0;
        public string color = "";


        public Car(string brandValue, double speedValue, string colorValue)      //Konstruktori jolla voidaan määrittää kaikki olion kentät parametrillä yhdellä kerralla 
        {
            this.brand = brandValue;
            this.speed = speedValue;
            this.color = colorValue;
        }

        public Car()               //konstruktori jolla määritetään olio, mutta annetaan olion kentille arvot yksitellen
        {
            this.brand = "";
            this.color = "";
            this.speed = 0;
        }
        public void AskVäriData()     //metodi, joka kysyy käyttäjältä auton väriä ja määrittää olion "color" kentän käyttäjän vastauksella
        {
            Console.Write("Anna auton väri: ");
            this.color = Console.ReadLine();
        }

        public void AskData()  //metodi, joka kysyy auton merkkiä ja nopeutta ja määrittää olion kentät "brand" ja "speed" käyttäjän vastauksilla. 
        {
            Console.Write("Anna auton merkki ja nopeus");  //Käyttäjän täytyy asettaa ensin brand, painaa enteriä ja sitten asettaa nopeus ja jälleen enteriä 
            Console.WriteLine();
            this.brand = Console.ReadLine();
            this.speed = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowCarInfo()    //metodi, joka printtaa konsolille auton tiedot
        {
            Console.WriteLine("Auton merkki on " + this.brand + " ja auton nopeus on " + this.speed + " km/h");
            Console.ReadLine();
        }

        public void Accelerate(double kiihdytyksenSuuruus)   //metodi, joka lisää auton nopeuteen käyttäjän asettaman luvun ja printtaa kiihdytyksen suuruuden. 
        {
            if (kiihdytyksenSuuruus < 0)                      // jos kiihdytyksen suuruus on negatiivinen metodi printtaa konsolille "kiihdytyksen arvo ei voi olla negatiivinen"
            {
                Console.WriteLine("Kiihdytyksen arvo ei voi olla negatiivinen");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Kiihdytyksen suuruus on " + kiihdytyksenSuuruus + " km/h");
                this.speed = this.speed + kiihdytyksenSuuruus;
            }
        }

        public void Brake()   // metodi joka printtaa konsolille "Jarrutetaan ja vauhti hiljenee 10%" ja vähentää vauhdista 10%
        {
            Console.WriteLine("Jarrutetaan ja vauhti hiljenee 10%");
            this.speed = this.speed - (this.speed * 0.1);
        }


    }

}
        
        

        
          
        
    

