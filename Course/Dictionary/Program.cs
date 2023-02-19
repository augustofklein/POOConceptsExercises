﻿namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> candidates = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (candidates.ContainsKey(name))
                        {
                            candidates[name] += votes;
                        }
                        else
                        {
                            candidates[name] = votes;
                        }
                    }
                    foreach (KeyValuePair<string, int> item in candidates)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}