using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyExercise
{
    class Company   // luokka
    {
        public string title = "";       //luodaan oliolle kenttiä
        public string adress = "";
        public int phone = 0;
        public double outcome = 0;
        public double expense = 0;
        public double winpercentage = 0;     // luotiin muuttuja, joka ei kuulu olion kenttiin

        public Company()      //konstruktori
        {
            this.title = "";
            this.adress = "";
            this.phone = 0;
            this.outcome = 0;
            this.expense = 0;
        }

        public Company(string titleValue, string adressValue,int phoneValue,int outcomeValue,int expenseValue)  //konstruktori
        {
            this.title = titleValue;
            this.adress = adressValue;
            this.phone = phoneValue;
            this.outcome = outcomeValue;
            this.expense = expenseValue;
        }

        public Company(Company previousCompany)        //konstruktori, joka kopioi olion tiedot toisen olion kentiltä
        {
            this.title = previousCompany.title;
            this.adress = previousCompany.adress;
            this.phone = previousCompany.phone;
            this.outcome = previousCompany.phone;
            this.expense = previousCompany.expense;
        }


        public void LaskeVoitto()                 // metodi, joka laskee yrityksen voittoprosentin ja printtaa konsoliin erilaisen tekstin riippuen siitä kuinka suuri voittoprosentti on
        {
            winpercentage = (this.outcome - this.expense) / this.expense * 100;

            if(winpercentage<100)
            {
                Console.WriteLine("Yrityksellä "+this.title+ " menee kehnosti\nVoittoprosentti: "+winpercentage+" %");
                Console.ReadLine();
            }

            if (winpercentage <= 200)
            {
                Console.WriteLine("Yrityksellä " + this.title + " menee välttävästi\nVoittoprosentti: "+winpercentage+" %");
                Console.ReadLine();
            }

            if (winpercentage >= 200)
            {
                if (winpercentage >= 300)
                {
                    Console.WriteLine("Yrityksellä " + this.title + " menee hyvin\nVoittoprosentti: "+winpercentage+" %");
                    Console.ReadLine();
                }
                else

                Console.WriteLine("Yrityksellä " + this.title + " menee tyydyttävästi\nVoittoprosentti: "+winpercentage+" %");
                Console.ReadLine();


                
            }
        }





    }
}
