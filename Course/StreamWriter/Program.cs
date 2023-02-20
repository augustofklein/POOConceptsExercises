namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/Users/augusto/Projects/POOConceptsExercises/Course/StreamWriter/file1.txt";
            string targetPath = @"/Users/augusto/Projects/POOConceptsExercises/Course/StreamWriter/file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}