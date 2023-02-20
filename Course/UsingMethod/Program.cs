namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/augusto/Projects/POOConceptsExercises/Course/UsingMethod/file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}