namespace AbstractPayers.Entities
{
    public class Company : Payer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TaxesPayed()
        {
            double percentTaxe;

            if (NumberEmployees > 10)
            {
                percentTaxe = 14;
            }
            else
            {
                percentTaxe = 16;
            }

            return AnualIncome * (percentTaxe / 100);
        }
    }
}

