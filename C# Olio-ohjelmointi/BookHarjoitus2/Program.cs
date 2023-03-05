using System;
using BookHarjoitus2;
using System.Collections.Generic;
using System.Collections;

namespace BookHarjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book2 ja author harjoitus!\n");


            
            Book2.ChangeTheme("Sota");                              //muutetaan teema
            Book2 kirja1 = new Book2("Tuntematon sotilas", "Väinö Linna", "WSOY", "9784567890987", 40);   //luodaan Book2 olio
            kirja1.GetBookDetails("9784567890987");             //tulostetaan kirjan (olion) tiedot (kentät)




            Book2.ChangeTheme("Elämänkerta, Koripallo");             //muutetaan teema
            Book2 kirja2 = new Book2("Tuff Juice", "Caron Butler","abc","9784567898765",80);   //luodaan Book2 olio
            kirja2.GetBookDetails("9784567898765");         //tulostetaan kirjan (olion) tiedot (kentät)

            Book2 kirja3 = new Book2("Mein kampf", "Adolf Hitler", "??", "9781234567890", 5);

            Author author1 = new Author("Väinö Linna", "01.01.1990", kirja1);                 //Luodaan Author olio
            author1.PrintInformation();            //Käytetään Author oliolle "PrintInformation metodia" joka printtaa olion kentät

            Author author2 = new Author("Caron Butler", "01.01.1990", kirja2);
            author2.PrintInformation();

            Author author3 = new Author("Matti Meikäläinen", "01.02.2003",null);  //luodaan olio jolla ei ole kirjaa
            author3.PrintInformation();

            List<Book2> books = new List<Book2>();
            books.Add(kirja1);
            books.Add(kirja2);
            books.Add(kirja3);

            Console.WriteLine("Tulostetaan lista books\n");
            foreach(Book2 kirjaOlio in books)
            {
                Console.WriteLine(kirjaOlio.ToString());
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            }


            books.Sort();                     //järjestetään lista niin että halvin kirja tulee ensimmäisenä
            Console.WriteLine("Järjestetty hinnan mukaan\n");
            foreach (Book2 kirjaOlio in books)
            {
                Console.WriteLine(kirjaOlio.ToString());
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            }

                Console.ReadLine();

            

        } 
    }
}
