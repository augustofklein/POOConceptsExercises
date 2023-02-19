namespace Dictionary.Entities
{
	public class Candidate
	{
        public string Name { get; set; }
        public int Votes { get; set; }

        public Candidate(string name, int votes)
        {
            Name = name;
            Votes = votes;
        }
    }
}

