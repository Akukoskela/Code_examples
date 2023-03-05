using System;
using System.Collections.Generic;
using System.Text;

namespace BookHarjoitus
{

    public class Book  // Luokka
    {
        public string title = "";                // luodaan olion muuttujat eli kentät
        public string author = "";
        public string id = "";
        public double price;

        public string idVirheellinen="Kirjan id on virheellinen";
        public string idKunnossa = "Kirjan id on kunnossa";



        public Book()   // konstruktori, toimii niin, että kerrotaan tiedot yksitellen ja järjestyksellä ei ole väliä.
        {
            this.title = "";
            this.author = "";
            this.id="";
            this.price = 0.00;
        }

        public Book(string newtitle, string newauthor, string newid, double newprice)  // toinen konstruktori, toimii niin, että kerrotaan kaikki kirjan tiedot kerralla ja oikeassa järjestyksessä. parametreinä.
        {
            this.title = newtitle;
            this.author = newauthor;
            this.id = newid;
            this.price = newprice;


        }

        public string getBookInformation()    // Metodi, jolla saadaan valitun olion (tässä tapaukessa kirjan) tiedot eli kentän arvot tulostetaan.
        {
            return this.title + " " + this.author + " " + this.id + " " + Convert.ToString(this.price);
        }    
        
        

        public void setId(string newid)     //metodi, jolla tarkistetaan, että olion kentän id arvo on asetettu oikein. Tässä tapauksessa täytyy olla tasan 5 numeroa.
        {

            if (newid.Length == 5)
            {
                this.id = newid;
            }



            else
            {
                this.id = idVirheellinen;
                //this.id = "Id virheellinen";                              //Kaksi tapaa kertoa, että  Id on virheellinen
            }
            
            
        }

        public string kirjojenHintaVertailu(Book bookx)     //metodi jolla verrataan kahden kirjan (olion) price kenttiä.
        {
            

            if(bookx.price<this.price)
            {
                return "Kirja: " + this.title + " on kalliimpi kuin kirja: "+bookx.title;
                
            }
            if(bookx.price==this.price)
            {
                return "Kirjat: " + bookx.title + " " + this.title + " ovat saman hintaiset";
            }
            else
            {
                return "Kirja: " + bookx.title + " on kalliimpi kuin kirja: " + this.title;
            }

        }

         



    }


}











    



