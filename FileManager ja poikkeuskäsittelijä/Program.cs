using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FileManager_ja_poikkeuskäsittelijä
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.OutputEncoding = System.Text.Encoding.UTF8;


            string filePath = @"C:\Users\sk\OneDrive\Documents\Kouluhommat\OlioOhjelmoinnin perusteet\Tehtävät\FileManager ja poikkeuskäsittelijä\Book.json";

            FileManager fm = new FileManager(filePath);
           
            
            string text= fm.ReadWords();

            Console.WriteLine();

            List<Book2> books = JsonConvert.DeserializeObject<List<Book2>>(File.ReadAllText(filePath, Encoding.UTF8));
            File.WriteAllText(filePath, JsonConvert.SerializeObject(books));

            Console.WriteLine(books);

           

            Console.ReadLine();
            

            
        }
    }
}
