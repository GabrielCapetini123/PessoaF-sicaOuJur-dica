using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioPJ.Entities
{
    abstract class TaxPlayer
    {
        public  string Name { get; set; }
        public double anualIncome { get; set; }

        public TaxPlayer()
        {
        }

        public TaxPlayer(string name, double anualIncome)
        {
            Name = name;
            this.anualIncome = anualIncome;
        }

        public abstract double Tax();
        

        
    }
}
