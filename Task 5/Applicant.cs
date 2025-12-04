namespace Workshop6
{
    public class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Applicant(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}