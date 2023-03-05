using System;
using EmployeeHarjoitus;

namespace EmployeeHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee harjoitus!\n");

            
            Employee employee1 = new Employee("Aku Koskela", "00001", "Johtaja", 2000);                         //luodaan olioita "Employee" ja annetaan nimi esim. "employee1" 
            Employee employee2 = new Employee("Eemeli Skyttä", "00002", "Hihna-mies", 1500);
            Employee employee3 = new Employee("Matti Meikäläinen", "00003", "Apulais-johtaja", 1750);
            Employee employee4 = new Employee("Timo Jutila", "00004", "Päällikkö", 3000);

            employee1.CompareSalary(employee2);            //Verrataan employee1 palkkaa employee2 palkkaan metodilla "CompareSalary"
            
           
            employee1.PrintEmployeeInfo();                  //printataan employee1 tiedot käyttämällä metodia "PrintEmployeeInfo"
            
            


            Employee[] employees= { employee1,employee2,employee3,employee4 };          //luodaan taulukko "employees" ja lisätään sinne olioita

            foreach(Employee currentEmployee in employees)                            //printataan kaikki taulukon oliot käyttämällä "foreach" looppia ja "ToString" metodia
            {
                Console.WriteLine(currentEmployee.ToString());
            }

            Console.WriteLine();

            for (int i = 0; i < employees.Length; i++)                //verrataan taulukon olioiden palkkoja käyttämällä "CompareSalary" metodia niin, että valitun olion palkkaa verrataan taulukossa seuraavana olevan olion palkkaan
            {
                if (i+1> employees.Length-1)                          //taulukon viimeisenä olevan olion palkkaa verrataan taulukon ensimmäisenä olevan olion palkkaan
                {
                    employees[i].CompareSalary(employees[0]);
                }
                else
                {
                    employees[i].CompareSalary(employees[i+1]);
                }
                
                  
                
            }
        }
    }
}
