using System;
namespace LMSLibrary.Models
{
	public class AssignmentGroup
	{
		public string Name { get; set; }
		public List<Assignment> Assignments { get; set; }
		public double Weight { get; set; }

		public AssignmentGroup(string name, double weight)
		{
			Name = name;
			Assignments = new List<Assignment>();
			Weight = weight;
			// !!! for now im assigning the weight to 0 cuz like idk
		}
	}
}

