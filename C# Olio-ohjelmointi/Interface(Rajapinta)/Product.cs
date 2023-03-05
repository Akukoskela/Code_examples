using System;
using System.Collections.Generic;
using System.Text;
using Interface_Rajapinta_;


namespace Interface_Rajapinta_
{
    class Product:IProduct           //Luokka Product joka perii rajapinnan IProduct
    {
        public string name;
        public double price;
        public int count;  


        public Product(string nameValue,double priceValue,int countValue)  //konstruktori
        {
            this.name = nameValue;
            this.price = priceValue;
            this.count = countValue;
        }

        public override string ToString()
        {
            return $"Nimi: {this.name} Hinta: {this.price} Lukumäärä: {this.count}";
        }
           
        public void GetProduct(string nameValue)  //metodi joka printtaa olion Product tiedot jos parametrina on annettu kyseisen olion nimi. Jos nimeä ei anneta tai se kirjoiotetaan väärin metodi palauttaa null arvon
        {
            if(nameValue==this.name)
            {
               Console.WriteLine("Nimi: " + this.name + " Hinta: " + this.price + "Euroa Lukumäärä: " + this.count);
            }
            

        }

        public string CalculateTotal()  //metodi joka laskee tuotteiden hinnan ja palauttaa strin pätkän mutta ei tulosta konsoliin mitään.
        {
            double totalCost = this.price * this.count;
            return this.count + "kpl tuotetta "+this.name+" maksaa " + totalCost + " Euroa\n";
        }
    }
}
