using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FileManager_ja_poikkeuskäsittelijä
{
    // Custom exception
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string filePath;

        // Constructor
        public FileManager()
        {
            this.filePath = "";
        }

        // Constructor
        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReadWords()
        {
            string content = String.Empty;

            try
            {
                content = ReadFile();
            }
            catch(WordListNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            

            return content;
        }

        /* Method reads file from a local 
         * directory path.
         */
        private string ReadFile()
        {
            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);

            try
            {
                string directoryName = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                string fileExtension = Path.GetExtension(filePath);


                Console.WriteLine("directoryName: " + directoryName);
                Console.WriteLine("fileName: " + fileName);
                Console.WriteLine("fileExtension: " + fileExtension);


                return fileContent;
            }
            catch (WordListNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            return fileContent;
        }    

          
            
        
    }
}