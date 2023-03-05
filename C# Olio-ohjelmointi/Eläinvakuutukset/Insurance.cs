using System;
using System.Collections.Generic;
using System.Text;

namespace Eläinvakuutukset
{
    public class Insurance
    {
        private string species;
        private string name;
        private bool neutered;
        private double fee;


        public Insurance(string speciesValue, string nameValue, bool isNeutered,double feevalue)
        {
            this.species = speciesValue;
            this.name = nameValue;
            this.neutered = isNeutered;
            this.fee = feevalue;
        }

        public string GetNeuteredInfo()  
        {
            if(neutered)
            {
                return "Leikattu";
            }
            else
            {
                return "Leikkaamaton";
            }
        }

        public override string ToString()
        {
            return this.species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }


        //apumetodeja joilla nähdään Insurance olion kenttiä. koska kentät ovat private tyyppisiä niitä ei saada muuten InsuranceManager luokassa
        
        public string ToString2()
        {
            return this.species + ": " + this.name+",";
        }
      
        public string GetSpeciesInfo()
        {
            return this.species;
        }

        public bool GetNeuteredInfo2()
        {
            return this.neutered;
        }


    }
}
