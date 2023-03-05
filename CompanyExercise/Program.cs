using System;
using CompanyExercise;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company exercise!\n");

            Company yritys1 = new Company();            //luodaan uusi olio ja annetaan sen kentille arvot
            yritys1.title = "Jankon Betoni";
            yritys1.adress = "Mustikkamäentie";
            yritys1.phone = 0456698300;
            yritys1.outcome = 400;
            yritys1.expense = 100;
              
            yritys1.LaskeVoitto();                   //käytetään metodia LaskeVoitto
             
            Company yritys1Kopio = new Company(yritys1);                //kopioidaan yritys1 kenttien tiedot yritys1Kopion kenttiin

            Console.WriteLine(yritys1Kopio.title);                      // testasin toimiiko kopiointi, eli onko yritys1Kopiolla sama arvo kentässä title, kuin yritys1:llä
            Console.ReadLine();
           
        }
    }
}
