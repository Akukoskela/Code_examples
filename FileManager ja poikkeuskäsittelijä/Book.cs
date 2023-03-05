using System;
using System.Collections.Generic;
using System.Text;
using FileManager_ja_poikkeuskäsittelijä;
using System.Collections;
using Newtonsoft.Json;

namespace FileManager_ja_poikkeuskäsittelijä

{
    class Book2 : IComparable<Book2>    //Luokan nimi:Book2 //käytetään rajapintaaIComparable<>
    {
        public string name = "";                                         //luodaan olion kenttiä ja luokan sisäisiä vakioita
        private readonly string author = "";
        public string publisher = "";
        private string isbn = "";
        private double price = 0;

        public static string theme = "";
        private const int isbnCorrectLenght = 13;
        private const string Prefix = "978";


        public Book2()           //konstruktori
        {
            this.name = "";
            this.author = "";
            this.publisher = "";
            ISBN = isbn;
            Price = price;

        }

        public Book2(string nameValue, string authorValue, string publisherValue, string isbnValue, double priceValue)           //konstruktori 
        {
            this.name = nameValue;
            this.author = authorValue;
            this.publisher = publisherValue;
            ISBN = isbnValue;
            Price = priceValue;
        }



        public void GetBookDetails(string ISBNValue)                  //metodi joka printtaa olion kentät(Tässä tapauksessa kirjan tiedot). Sulkuihin täytyy asettaa sama merkkijono kuin kirjan ISBN tunnus, jotta metodi toimii
        {
            if (this.isbn == ISBNValue)
            {
                Console.WriteLine("Kirjan " + this.name + " tiedot:\n");
                Console.WriteLine("Teema: " + theme + "\nNimi: " + this.name + "\nKirjoittaja: " + this.author + "\nJulkaisija: " + this.publisher + "\nISBN: " + this.ISBN + "\nHinta: " + this.Price + " Euroa\n\n------------------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Kirjan " + this.name + " tietoja ei voi tulostaa\n");
            }
        }

        public static void ChangeTheme(string newTheme)        //staattinen metodi, joka liittyy luokkaan eikä yksittäiseen olioon. Kutsutaan: Book2.ChangeTheme(newtheme); 
        {
            theme = newTheme;
        }

        public override string ToString()
        {
            if (this.author != null)
            {
                return $"Kirjan nimi: {this.name}\nKirjoittaja: {this.author}\nJulkaisija: {this.publisher}\nISBN: {this.isbn}\nHinta: {this.price} Euroa";
            }
            else
            {
                return $"Kirjan nimi: {this.name}\nKirjoittaja: \nJulkaisija: {this.publisher}\nISBN: {this.isbn}\nHinta: {this.price} Euroa";
            }
        }

        public double Price               //Price ominaisuus jolla tarkastetaan, onko käyttäjän syöttämä arvo kohtaan price yli 30. Jos arvo on yli 30 niin sitä vähennetään 10%. Muuten se pysyy ennallaan
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 30)
                {
                    price = value;
                }
                if (value > 30)
                {
                    price = value * 0.9;
                }
            }
        }

        public string ISBN                  //ISBN ominaisuus, jolla tarkastetaan, että käyttäjän antama arvo isbn kentälle on 13 merkkiä pitkä ja alkaa "978". Jos nämä ehdot eivät täyty, tulostetaan konsoliin "Kirjan " + this.name + " ISBN arvo: " + value + " on virheellinen.\nSyötä 13 merkkiä pitkä merkkijono, joka alkaa numeroilla: " + Prefix + "\n"
        {
            get
            {
                return isbn;
            }
            set
            {
                if (value.StartsWith(Prefix) == true)
                {
                    if (value.Length == isbnCorrectLenght)
                    {
                        isbn = value;
                    }
                    else
                    {
                        isbn = "Kirjan " + this.name + " ISBN arvo: " + value + " on virheellinen.\nSyötä 13 merkkiä pitkä merkkijono, joka alkaa numeroilla: " + Prefix + "\n";
                        Console.WriteLine(isbn);
                    }

                }

                else
                {
                    isbn = "Kirjan " + this.name + " ISBN arvo: " + value + " on virheellinen.\nSyötä 13 merkkiä pitkä merkkijono, joka alkaa numeroilla: " + Prefix + "\n";
                    Console.WriteLine(isbn);
                }
            }
        }

        public string Author   //readonly ominaisuus
        {
            get { return author; }
        }


        public int CompareTo(Book2 otherBook)    //Rajapinnan metodi
        {

            return this.price.CompareTo(otherBook.price);
        }








    }
}
