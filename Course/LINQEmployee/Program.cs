using System.Globalization;
using LINQEmployee.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            try
            {
                List<Employee> employees = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string employeeName = fields[0];
                        string employeeEmail = fields[1];
                        double employeeSalary = double.Parse(fields[2]);

                        employees.Add(new Employee(employeeName, employeeEmail, employeeSalary));
                    }
                }

                Console.Write("Enter salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture) + ":");
                var emails = employees.Where(p => p.Salary > salary).OrderBy(p => p.Name).Select(p => p.Email);

                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                var sumSalarys = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
                Console.Write("Sum of salary of people whose name starts with 'M: " + sumSalarys);
            }
            catch(IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}