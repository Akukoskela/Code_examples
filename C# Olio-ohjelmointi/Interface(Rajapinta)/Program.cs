using System;
using Interface_Rajapinta_;
using System.Collections.Generic;


namespace Interface_Rajapinta_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rajapinta harjoitus!\n");

            //Luodaan Product olioita ja muodostetaan niistä taulukko/lista
            //testataan myös GetProduct ja CalculateTotal metodeja

            Product tuote1 = new Product("Maila", 10, 1);
            tuote1.GetProduct("Maila");
            tuote1.CalculateTotal();
            Product tuote2 = new Product("kiekko",5,10);
            Product tuote3 = new Product("Pallo", 8, 3);

            Product[] products = new Product[] { tuote1,tuote2,tuote3 };

            //Luodaan Customer olioita ja muodostetaan niistä taulukko/lista

            Customer asiakas1 = new Customer("Aku Koskela", 500);
            Customer asiakas2 = new Customer("Matti Meikäläinen", 1500);
            Customer asiakas3 = new Customer("Ronnie Coleman", 2500);

            Customer[] customers = new Customer[] { asiakas1, asiakas2, asiakas3 };




            foreach (Customer x in customers)
            {
                x.GetCustomer("Aku Koskela");
                x.GetBonus();
            }

            //Luodaan Store olio ja lisätään Store olio sisällä oleviin listoihin Product ja Customer olioita

            Store kauppa1 = new Store("Akun urheilu", 4500);

            kauppa1.AddProduct(tuote1);
            kauppa1.AddProduct(tuote2);
            kauppa1.AddProduct(tuote3);

            kauppa1.PrintProducts();  //Käytetään metodia joka printtaa Product oliot jotka ovat kaupan listalla ja niiden tiedot


            kauppa1.AddCustomer(asiakas1);
            kauppa1.AddCustomer(asiakas2);
            kauppa1.AddCustomer(asiakas3);

            kauppa1.PrintCustomers();  //Käytetään metodia joka printtaa Customers oliot jotka ovar Store olion sisällä olevassa listassa
        }
    }
}
