using System;
using System.Collections.Generic;
using System.Text;
using Interface_Rajapinta_;

namespace Interface_Rajapinta_
{
    class Customer:ICustomer  //Luokka Customer joka perii rajapinnan ICustomer
    {
        public string name;
        public double purchases;

        public Customer(string nameValue,double purchasesValue)  //konstruktori
        {
            this.name = nameValue;
            this.purchases = purchasesValue;
        }

        public override string ToString()
        {
            return $"Nimi: {this.name} Ostokset: {this.purchases}";
        }
        internal void GetCustomer(string nameValue)   //Metodi jolla printataan olion Customer tiedot, jos parametrinä annetaan olion nimi. Jos parametri on väärä palautetaan null arvo
        {
            if(this.name==nameValue)
            {
                Console.WriteLine("Nimi: " + this.name + " Ostokset: " + this.purchases);
            }

        }
        public void GetBonus()   //Metodi joka laskee olion Customer bonuksen olion ostosten perusteella.
        {
            if(this.purchases<=1000)
            {
                double bonus = this.purchases * 0.02;
                Console.WriteLine("Henkilön "+this.name+" Bonus on " + bonus + " Euroa\n");
            }
            else if(this.purchases<=2000)
            {
                double bonus = this.purchases * 0.03;
                Console.WriteLine("Henkilön " + this.name + " Bonus on " + bonus + " Euroa\n");
            }
            else if(2000<this.purchases)
            {
                double bonus = this.purchases * 0.05;
                Console.WriteLine("Henkilön " + this.name + " Bonus on " + bonus + " Euroa\n");
            }
        }
    }
}
