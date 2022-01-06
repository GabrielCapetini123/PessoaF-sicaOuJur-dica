

namespace ExercícioPJ.Entities
{
    class Company : TaxPlayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }
        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees < 10)
            {
                return anualIncome * 0.16;
            }
            else
            {
                return anualIncome * 0.14;
            }
        }
    }
}
