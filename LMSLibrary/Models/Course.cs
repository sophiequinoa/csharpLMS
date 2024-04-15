using System;
namespace LMSLibrary.Models
{
    public class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }
        public List<Person> Roster { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Module> Modules { get; set; }
        public List<AssignmentGroup> AssignmentGroups { get; set; }
        public List<Announcement> Announcements { get; private set; } = new List<Announcement>();

        // Should i have an default constructor

        //public Course()
        //{
        //    Roster = new List<Person>();
        //    Assignments = new List<Assignment>();
        //    Modules = new List<Module>();
        //}

        public Course(string code, string name, string description, int credithours)
        {
            Roster = new List<Person>();
            Assignments = new List<Assignment>();
            Modules = new List<Module>();
            Code = code;
            Name = name;
            Description = description;
            CreditHours = credithours;
            AssignmentGroups = new List<AssignmentGroup>();
            Announcements = new List<Announcement>();
        }

        public void PrintCourseinList(Course course)
        {
            Console.WriteLine("\nCourse Code: "+ course.Code);
            Console.WriteLine("Course Name: "+ course.Name);
        }

        public void PrintCourse(Course course)
        {
            Console.WriteLine("Course Code: " + course.Code);
            Console.WriteLine("Course Name: "+ course.Name);
            Console.WriteLine("Course Description: "+ course.Description);
            string temp = "";
            foreach (var student in course.Roster)
            {
                if (student != course.Roster[0])
                {
                    temp += " , ";

                }
                temp += student.Name;
            }

                
        
            Console.WriteLine("Course Roster: " + temp);
            temp = "";
            foreach (var assignment in course.Assignments)
            {
                if (assignment != course.Assignments[0])
                {
                    temp += " , ";

                }
                temp += assignment.Name;
            }
            Console.WriteLine("Course Assignments: " + temp);
            // Change Modules print too !!!
            Console.WriteLine("Course Modules: " + string.Join(", ", course.Modules));
        }

        public void UpdateCourse(Course course)
        {
            // Like eventually add this is the current course name would you like to change it
            // for now, make it feel like setting up fsu cs account
            // or maybe even another menu thats like what do you wanna update about the course
            Console.WriteLine("The Course's Code is currently: {0} . Please enter the new Code: ", course.Code);
            course.Code = Console.ReadLine();
            Console.WriteLine("The Course's Name is currently: {0} . Please enter the new Name: ", course.Name);
            course.Name = Console.ReadLine();
            Console.WriteLine("The Course's Description is currently: {0} . Please enter the new Description: ", course.Description);
            course.Description = Console.ReadLine();
            Console.WriteLine("The Course's Number of Credit Hours is currently: {0} ." +
                " Please enter the new Number of Credit Hours: ", course.CreditHours);
            course.CreditHours = Int32.Parse(Console.ReadLine());

        }

        public void AddAssignment(Course course)
        {
            Console.WriteLine("Please Enter an Assignment Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter an Assignment Description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Please Enter the Amount of Total Avaliable Points for this Assignment: ");
            string pointsinput = Console.ReadLine();
            bool correct = false;
            int points = 0;
            while (!correct)
            {
                if (int.TryParse(pointsinput, out points))
                {
                    // Fix this so it can be lowercase too
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Student's Classification must be Freshman, Sophmore, Junior, or Senior. Please Re-Enter: ");
                    pointsinput = Console.ReadLine();

                }
            }
            Console.WriteLine("Please Enter the Assignment's Due Date (yyyy-mm-dd): ");
            DateTime duedate = DateTime.Parse(Console.ReadLine());

            var newassignment= new Assignment(name, description, points, duedate);
            course.Assignments.Add(newassignment);
        }

        // Module functions

        // create module function
        public void CreateModule(Module module)
        {
            Modules.Add(module);
        }

        // List all modules
        public void ListModules()
        {
            foreach (var module in Modules)
            {
                Console.WriteLine($"Module: {module.Name}");
                // !!! print other module details
            }
        }

        // get module by name
        public Module GetModuleByName(string moduleName)
        {
            return Modules.Find(module => module.Name == moduleName);
        }

        // update module details
        public void UpdateModule(Module moduleToUpdate, string newName, string newDescription)
        {
            moduleToUpdate.Name = newName;
            moduleToUpdate.Description = newDescription;
            // !!! add other new properties if i need to
        }

        // delete module
        public void DeleteModule(Module moduleToDelete)
        {
            Modules.Remove(moduleToDelete);
        }

        // function to assign a grade to a student
        public void AssignGrade(string studentName, string assignmentName, double grade)
        {
            Assignment assignment = Assignments.Find(a => a.Name == assignmentName);
            if (assignment != null)
            {
                if (assignment.Grades.ContainsKey(studentName))
                {
                    assignment.Grades[studentName] = grade;
                }
                else
                {
                    assignment.Grades.Add(studentName, grade);
                }
            }
            else
            {
                Console.WriteLine("Assignment not found");
            }
        }

        // Assignment group functions

        // create an assignment group
        public void CreateAssignmentGroup(string groupName, double weight)
        {
            AssignmentGroup group = new AssignmentGroup(groupName, weight);
            AssignmentGroups.Add(group);
        }

        // add an assignment to a group
        public void AddAssignmentToGroup(Assignment assignment, string groupName)
        {
            AssignmentGroup group = AssignmentGroups.Find(g => g.Name == groupName);
            if (group != null)
            {
                group.Assignments.Add(assignment);
            }   
            else
            {
                Console.WriteLine("Assignment group not found");
            }
        }

        // remove assignment from a group
        public void RemoveAssignmentFromGroup(Assignment assignment, string groupName)
        {
            AssignmentGroup group = AssignmentGroups.Find(g => g.Name == groupName);
            if (group != null)
            {
                group.Assignments.Remove(assignment);
            }
            else
            {
                Console.WriteLine("Assignment group not found");
            }
        }

        // Functions for averages

        // calculate weighted average of a student
        public double CalculateWeightedAverage(string studentName)
        {
            double weightedAverage = 0.0;
            double totalWeight = 0.0;
            foreach (AssignmentGroup group in AssignmentGroups)
            {
                double groupWeight = group.Weight;
                totalWeight += groupWeight;
                double groupAverage = CalculateGroupAverage(group, studentName);
                weightedAverage += groupWeight * groupAverage;

            }
            if (totalWeight ==0)
            {
                Console.WriteLine("No assignment groups defined or weights not assigned");
                return 0.0;
            }
            return weightedAverage / totalWeight;
        }

        // calculate average for an assignment group
        private double CalculateGroupAverage(AssignmentGroup group, string studentName)
        {
            double totalPoints = 0.0;
            double totalGrades = 0.0;
            foreach (Assignment assignment in group.Assignments)
            {
                if (assignment.Grades.ContainsKey(studentName))
                {
                    double grade = assignment.Grades[studentName];
                    totalPoints += assignment.TotalAvailablePoints;
                    totalGrades += grade;
                }
            }
            return totalPoints > 0 ? totalGrades / totalPoints : 0.0;
        }

        // claculates the total grade points for a student
        public double CalculateTotalGradePoints(string studentName)
        {
            double totalGradePoints = 0.0;
            foreach (AssignmentGroup group in AssignmentGroups)
            {
                foreach (Assignment assignment in group.Assignments)
                {
                    if (assignment.Grades.ContainsKey(studentName))
                    {
                        double grade = assignment.Grades[studentName];
                        totalGradePoints += (grade / 100) * assignment.TotalAvailablePoints;
                    }
                }
            }
            return totalGradePoints;
        }

        // announcement fucntions

        // create a new announcement
        public void CreateAnnouncement(string title, string content, DateTime date)
        {
            Announcements.Add(new Announcement(title, content, date));
        }

        // read all annoucements
        public void ReadAnnouncements()
        {
            if (Announcements.Count == 0)
            {
                Console.WriteLine("No announcements available for this course.");
            }
            else
            {
                foreach (var announcement in Announcements)
                {
                    Console.WriteLine($"Title: {announcement.Title}");
                    Console.WriteLine($"Content: {announcement.Content}");
                    Console.WriteLine($"Date: {announcement.Date}");

                }
            }
        }

        // updates an announcement
        public void UpdateAnnouncement(int index, string title, string content, DateTime date)
        {
            if (index >= 0 && index < Announcements.Count)
            {
                Announcements[index].Title = title;
                Announcements[index].Content = content;
                Announcements[index].Date = date;

            }
            else
            {
                Console.WriteLine("Invalid announcement index.");
            }
        }

        // deletes announcement
        public void DeleteAnnouncement(int index)
        {
            if (index>= 0 && index < Announcements.Count)
            {
                Announcements.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid announcement index.");
            }
        }
    }

}

