namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/Users/augusto/Projects/POOConceptsExercises/Course/FileInfo/file1.txt";
            string targetPath = @"/Users/augusto/Projects/POOConceptsExercises/Course/FileInfo/file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accuurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}