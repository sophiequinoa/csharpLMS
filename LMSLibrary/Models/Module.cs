using System;
namespace LMSLibrary.Models
{
	public class Module
	{
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ContentItem> Content { get; set; }

        public Module(string name, string description)
		{
			Name = name;
			Description = description;
			Content = new List<ContentItem>();
		}
	}
}

