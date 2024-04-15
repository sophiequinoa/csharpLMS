namespace LMSLibrary.Models
{
    public class Person
    {
        private static int lastId = 0;

        public PersonClassification Classification { get; set; }
        public int Id
        {
            get; private set;
        }

        public string Name { get; set; }

        public Person()
        {
            Name = string.Empty;
            Id = ++lastId;
            Classification = PersonClassification.NA;
        }

        public Person(string name)
        {
            Name = name;
            Id = ++lastId;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} - {Classification}";
        }

            public enum PersonClassification
        {
            Freshman, Sophomore, Junior, Senior, TA, Instructor, NA
        }
    }
}