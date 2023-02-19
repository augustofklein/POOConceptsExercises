namespace AbstractPayers.Entities
{
    public class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPayed()
        {
            double taxes;

            if (AnualIncome < 20000)
            {
                taxes = AnualIncome * 0.15;
            }
            else
            {
                taxes = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                taxes -= HealthExpenditures * 0.5;
            }

            if (taxes < 0)
            {
                taxes = 0;
            }

            return taxes;
        }
    }
}

