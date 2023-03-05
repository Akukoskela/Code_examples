using System;
using System.Collections.Generic;
using System.Text;
using BookHarjoitus2;



namespace BookHarjoitus2
{
    class Author                         //luokka
    {
        public string name = "";          //luokan olion kenttiä
        public string birthDay = "";
        private Book2 book;

         
        public Author()            //konstruktori
        {
            this.name = "";
            this.birthDay = "";
            Book = null;
        }
        public Author(string nameValue, string birthDayValue, Book2 bookValue)          //konstruktori
        {
            this.name = nameValue;
            this.birthDay = birthDayValue;
            Book = bookValue;
        }

        internal Book2 Book                //Book ominaisuus joka tarkistaa, että kirjailijan nimi on sama kuin hänelle annetun kirjan kirjoittajan nimi
        {
            get
            {
                return book;
            }
            set
            {

                if(value==null)                    //jos Author olion kentässä "Book" on arvo "null" 
                {
                    Console.WriteLine("Kirjailija " + this.name + " ei ole kirjoittanut yhtään kirjaa");
                }
                else if (value.Author == this.name)      //jos "Author" olion kentässä "name" on sama arvo kuin "Book" olion kentässä "Author"
                {
                    book = value;
                }
                else            //jos kumpikaan ylemmästä ei pidä paikkaansa tulosteaan tämä
                {
                    Console.WriteLine(this.name+" ei ole kirjoittanut kirjaa "+value.name+". Varmista oikein kirjoitus kirjaa ja kirjailijaa luodessa.");
                    
                }
                

            }
        }
        
        
        

        public void PrintInformation()            //metodi joka printtaa Author olion kentät. (Author olioon kuuluu myös kirja olio)
        {
            if(this.name!=null)
            {
                if(this.birthDay!=null)
                {
                    if(this.book!=null)
                    {
                        Console.WriteLine("Kirjailijan " + this.name + " tiedot:\n");
                        Console.WriteLine("Kirjailijan nimi " + this.name + "\nSyntympäivä: " + this.birthDay + "\nKirjoittama kirja:\n\n" + this.Book.ToString()+"\n\n------------------------------------------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Jokin meni nyt pieleen. Varmista, että kirjailia on varmasti kirjoittanut hänelle asetetun kirjan.\n\n");
                    }
                }
                else
                {
                  Console.WriteLine("Jokin meni nyt pieleen. Varmista, että kirjailia on varmasti kirjoittanut hänelle asetetun kirjan.\\");
                }
            }
            else
            {
                Console.WriteLine("Jokin meni nyt pieleen. Varmista, että kirjailia on varmasti kirjoittanut hänelle asetetun kirjan.\\");
            }
           
        }

    }
}
