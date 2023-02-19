using AbstractPayers.Entities;
using AbstractPayers.Entities.Enums;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= taxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company: ");
                PayerEnum typePayer = Enum.Parse<PayerEnum>(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (typePayer == PayerEnum.Individual)
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    payers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numerEmployees = int.Parse(Console.ReadLine());

                    payers.Add(new Company(name, anualIncome, numerEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totalTax = 0;
            foreach (Payer payer in payers)
            {
                double tax = payer.TaxesPayed();
                Console.WriteLine(payer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                totalTax += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}