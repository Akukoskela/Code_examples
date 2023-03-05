using System;
using BookHarjoitus;






    class Program
    {
        static void Main(string[] args)
        {

                 


          Console.WriteLine("This is book exercise ");  //ns ylimääräinen teksti

          Book book1 = new Book();                 //luodaan olio book1
          book1.title = "Matematiikka";            //annetaan yhdelle olion kentälle arvo "Matematiikka"
          Console.WriteLine("Ensimmäinen kirja: " + book1.title); 
          book1.author = "aku koskela";            //lisätään olion kentille author, id ja price arvot
          book1.setId("00001");
          book1.price = 10.56;

          
         


          Book book2 = new Book("Aapinen","acricola","", 5.55);    //luodaan olio book2 ja annetaan suoraan arvot parametreinä.  
          Console.WriteLine("Toinen kirja: " + book2.title);            //Tämä on nopeampi tapa, mutta arvot täytyy laittaa oikeassa järjestyksessä. esim title arvoa ei voi antaa viimeisenä ja price arvoa ensimmäisenä.
          book2.setId("00002"); 

          Book book3 = new Book("Historia 4","Väinö linna","", 3.05);  //luodaan olio book3 ja annetaan kentille arvot parametreinä
          Console.WriteLine("Kolmas kirja: " + book3.title);
          book3.setId("00003");

          Book book4 = new Book();                               //luodaan olio book4 ja annetaan kentille arvot yksitellen
          book4.title = "Lappeenrannan kukat";
          Console.WriteLine("Neljäs kirja: " + book4.title);
          book4.author = "Oskari Koskela";
          book4.setId("000059");
          book4.price = 20.95;
         

          
          string bookInformation = "";                          //luodaan muuttuja "bookInformation"
          bookInformation = book4.getBookInformation();         //annetaan muuttujalle "bookInformation" arvo käyttäen luokan "book" metodia "getBookInformation"
         // Console.WriteLine(bookInformation);                   // printataan muuttuja "bookInformation"
          //Console.ReadLine();

          string kalliimpiKirja = "";                          //luodaan muuttuja "kalliimpiKirja"
          kalliimpiKirja=book1.kirjojenHintaVertailu(book2);   //annetaan muuttujalle "kalliimpiKirja" arvo joka saadaan käyttämällä metodia "kirjojenHintaVertailu"
          Console.WriteLine(kalliimpiKirja);                   //printataan muuttuja "kalliimpikirja"
          Console.ReadLine();
          
          


        




       



        }
    }
