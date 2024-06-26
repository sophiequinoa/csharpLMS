using System;
namespace LMSLibrary.Models
{
    public class Course
    {
        public string Code
        {
            get
            {
                return $"{Prefix}{Id}";
            }
        }
        private static int lastId = 0;
        public string Prefix { get; set; }
        public int Id
        {
            get; private set;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Person> Roster { get; set; }
        public List<AssignmentGroup> AssignmentGroups { get; set; }
        public IEnumerable<Assignment> Assignments
        {
            get
            {
                return AssignmentGroups.SelectMany(ag => ag.Assignments);
            }
        }
        public List<Submission> Submissions { get; set; }
        public List<Module> Modules { get; set; }
        public List<Announcement> Announcements { get; set; }
        public int CreditHours { get; set; }

        public Course()
        {
            Name = string.Empty;
            Description = string.Empty;
            Roster = new List<Person>();
            Submissions = new List<Submission>();
            Modules = new List<Module>();
            Prefix = string.Empty;
            Id = ++lastId;
            CreditHours = 3;
        }

        public override string ToString()
        {
            return $"{Code} - {Name}";
        }

        public string DetailDisplay
        {
            get
            {
                return $"{ToString()}\n{Description}\n\n" +
                    $"Announcements:\n{string.Join("\n\t", Announcements.Select(s => s.ToString()).ToArray())}\n\n" +
                    $"Roster:\n{string.Join("\n\t", Roster.Select(s => s.ToString()).ToArray())}\n\n" +
                    $"Assignments:\n{string.Join("\n\t", AssignmentGroups.Select(a => a.ToString()).ToArray())}\n\n" +
                    $"Modules:\n{string.Join("\n\t", Modules.Select(m => m.ToString()).ToArray())}";

            }
        }
    }

}

