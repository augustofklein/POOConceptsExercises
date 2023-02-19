using Sets.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int qtdStudentsA = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdStudentsA; i++)
            {
                int number = int.Parse(Console.ReadLine());

                students.Add(new Student { Number = number });
            }

            Console.Write("How many students for course B? ");
            int qtdStudentsB = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdStudentsB; i++)
            {
                int number = int.Parse(Console.ReadLine());

                students.Add(new Student { Number = number });
            }

            Console.Write("How many students for course C? ");
            int qtdStudentsC = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdStudentsC; i++)
            {
                int number = int.Parse(Console.ReadLine());

                students.Add(new Student { Number = number });
            }

            Console.WriteLine("Total students: " + students.Count);
        }
    }
}