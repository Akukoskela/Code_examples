using System;
using System.Collections.Generic;
using System.Text;
using Eläinvakuutukset;


namespace Eläinvakuutukset
{
    class InsuranceManager
    {
        List<Insurance> vakuutukset;   
        public InsuranceManager()  //konstruktori joka luo tyhjän listan
        {
            this.vakuutukset = new List<Insurance> { };
        }


        public void AddInsurance(string speciesValue, string nameValue, bool isNeutered) // metodilla 3 parametria   //Metodi luo uuden Insurance olionja lisää sen listaan "vakuutukset"
        {
            Insurance vakuutusX = new Insurance(speciesValue, nameValue, isNeutered, 0);
            this.vakuutukset.Add(vakuutusX);
        }
            
            
        
        public double GetFee(string speciesValue,bool isNeutered) // metodilla 2 parametria  //Metodi laskee eläimen vakuutusmaksu nhinnan riippuen onko se koira vai kissa ja onko sitä leikattu. Eli tarkastetaan vastaako parametrin ensimmäinen arvo "koira" vai "Kissa" ja sen jälkeen parametrin toinen arvo true tai false
        {
           if(speciesValue=="koira")
            {
                if(isNeutered==true)
                {
                    return 50;
                }
                else 
                {
                    return 80;
                }
            }
           else if(speciesValue=="kissa")
            {
                if(isNeutered==true)
                {
                    return 40;
                }
                else
                {
                    return 60;
                }
            }
           else 
            {
                return 0;
            }
            
        }
        public void PrintInsurances()         //metodi tulostaa ensiksi paljonko vakuutuksia on listassa ja sen jälkeen tulostaa vakuutuksien tiedot ToString() metodilla
        {
            Console.WriteLine("vakuutuksia yhteensä "+vakuutukset.Count+"\n");
            Console.WriteLine("Vakuutukset:\n");
            foreach(Insurance x in vakuutukset)
            {
                Console.WriteLine(x.ToString());
            }
        }
        public void FindInsurances(string speciesValue,bool isNeutered ) // metodilla 2 parametria       //metodi etsii ja tulostaa vakuutukset eli Insurance oliot joidenka kentät vastaavat annettuja parametrejä.
        {
            Console.WriteLine("\nlöytyi:\n");
           foreach(Insurance x in vakuutukset)
            {
                if (x.GetSpeciesInfo() == speciesValue)
                {
                    if (x.GetNeuteredInfo2() == isNeutered)
                    {
                        Console.WriteLine(x.ToString2() + " vakuutusmaksu " + GetFee(speciesValue, isNeutered) + " €");
                    }
                    else
                    {

                    }
                }
                else
                {

                }
                
            }
        }
    }
}
