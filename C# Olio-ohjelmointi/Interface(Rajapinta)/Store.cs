using System;
using System.Collections.Generic;
using System.Text;
using Interface_Rajapinta_;




namespace Interface_Rajapinta_
{
    class Store : IProducts, ICustomers   //luokka Store joka perii rajapinnat IProducts ja ICustomers
    {
        protected string name;
        protected double turnover;

        List<Product> Products;
        List<Customer> Customers;

        public Store(string nameValue,double turnoverValue)    //konstruktori
        {
            this.name = nameValue;
            this.turnover = turnoverValue;
            this.Products = new List<Product> { };
            this.Customers = new List<Customer> { };
           
        }
        
        

        public override string ToString()     
        {
            return $"Nimi: {this.name} Liikevaihto: {this.turnover} Asiakkaiden määrä: {Customers.Count} Tuotteiden määrä: {Products.Count}";
        }

        public void AddProduct(Product productx)   //metodi, jolla lisätään Product olio listaan Products
        {
            Products.Add(productx);
        }

        public void PrintProducts()   //metodi jolla printataan listan Products alkioiden määrä, sekä jokaisen alkion tiedot. Metodi käyttää metodia CalculateTotal joka laskee ostosten hinnan.
        {
            Console.WriteLine("Tuoteartikkeleiden lukumäärä: " + Products.Count + "\n");

            foreach(Product productX in Products)
            {
                Console.WriteLine("Tuotteen nimi: " + productX.name + " Hinta: " + productX.price + " Euroa Lukumäärä: " + productX.count+"\n"+productX.CalculateTotal());
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
        }

        public void AddCustomer(Customer customerX)
        {
            Customers.Add(customerX);
        }

        public void PrintCustomers()
        {
            Console.WriteLine("Asiakkaiden lukumäärä: " + Customers.Count);

            foreach(Customer customerX in Customers)
            {
                Console.WriteLine("Asiakkaan nimi: " + customerX.name + " Ostokset: " + customerX.purchases);
                customerX.GetBonus();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
