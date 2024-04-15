using System;
namespace LMSLibrary.Models
{
	public class Assignment
	{
        public string Name { get; set; }
        public string Description { get; set; }
		public int TotalAvailablePoints { get; set; }
        public DateTime DueDate { get; set; }
		public Dictionary<string, double> Grades { get; set; }

        public Assignment(string name, string description, int totalavaliablepoints, DateTime duedate)
		{
			Name = name;
			Description = description;
			TotalAvailablePoints = totalavaliablepoints;
			DueDate = duedate;
			Grades = new Dictionary<string, double>();
		}
	}
}

