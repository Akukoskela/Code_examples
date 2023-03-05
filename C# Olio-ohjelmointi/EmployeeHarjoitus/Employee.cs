using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHarjoitus
{
    class Employee                        // luokka
    {
        public string name = "";
        public string id = "";
        public string position = "";
        public double salary = 0;
        public double palkkaEro = 0;

        public Employee()         //konstruktori
        {
            this.name = "";
            this.id = "";
            this.position = "";
            this.salary = 0;
        }

        public Employee(string nameValue,string idValue, string positionValue, double salaryValue)   //konstruktori
        {
            this.name = nameValue;
            this.id = idValue;
            this.position = positionValue;
            this.salary = salaryValue;
        }

        public void CompareSalary(Employee employeeX)                             //metodi, jolla verrataan olioiden "salary" kenttää ja printataan tulos
        {
            if(this.salary<employeeX.salary)
            {
                palkkaEro = employeeX.salary - this.salary;
                Console.WriteLine("Työntekijällä " + employeeX.name + " on "+palkkaEro+" euroa korkeampi palkka, kuin työntekijällä "+this.name);
                Console.WriteLine();
            }
            if(this.salary>employeeX.salary)
            {
                palkkaEro = this.salary - employeeX.salary;
                Console.WriteLine("Työntekijällä " + this.name + " on " + palkkaEro + " euroa korkeampi palkka, kuin työntekijällä "+employeeX.name);
                Console.WriteLine();
            }
            if(this.salary==employeeX.salary)
            {
                Console.WriteLine("Työntekijöillä " + this.name + " ja " + employeeX.name + " on yhtä suuri palkka: "+this.salary+" euroa");
                Console.WriteLine();
            }
            
        }

        public void PrintEmployeeInfo()                                         //metodi, jolla printataan kutsuttavan olion kentät
        {
            Console.WriteLine("Nimi: " + this.name + "\nId: " + this.id + "\nAsema: " + this.position + "\nPalkka: " + this.salary+" euroa");
            Console.WriteLine();
        }

        public override string ToString()              //metodi, jolla ylikirjoitetaan "ToString" metodi ja muutetaan kutsuttavan olion tiedot merkkijonoksi
        {
            return $"{this.name}, {this.id}, {this.position}, {this.salary} Euroa";
        }
    }
}
