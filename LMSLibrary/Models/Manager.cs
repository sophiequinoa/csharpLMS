using System;
namespace LMSLibrary.Models
{
	public class Manager : Person
	{
        public List<Course> CourseList;
        public List<Person> StudentList;


        public Manager()
		{
            CourseList = new List<Course>();
            StudentList = new List<Person>();
        }


        // !!! I dont think I need to be passing in these manager Managers for all of the functions

        public void CreateCourse(Manager manager)
        {
            Console.WriteLine("Please Enter a Course Code: ");
            string code = Console.ReadLine();
            Console.WriteLine("Please Enter a Course Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter a Course Description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Please Enter the Number of Credit Hours: ");
            string credithours = Console.ReadLine();
            // !!! should maybe add checking for if they entered valid number too
            // I'm not checking course codes right now
            // also not checking if that course already exists
            var newcourse = new Course(code,name, description, Int32.Parse(credithours));
            manager.CourseList.Add(newcourse);
        }

        public void CreateStudent(Manager manager)
        {
            Console.WriteLine("Please Enter the Student's Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter the Student's Classification: ");
            string classification = Console.ReadLine();
            bool correct = false;
            while (!correct)
            {
                if ((classification == "Freshman") || (classification == "Sophmore") || (classification == "Junior") || (classification == "Senior"))
                {
                    // Fix this so it can be lowercase too
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Student's Classification must be Freshman, Sophmore, Junior, or Senior. Please Re-Enter: ");
                    classification = Console.ReadLine();

                }
            }
            // also not checking if that student already exists
            var newperson = new Person(name);
            manager.StudentList.Add(newperson);
        }

        public void AddStudent(Manager manager)
        {
            // find the correct student
            Console.WriteLine("Please Enter the Student's Name: ");
            string studentname = Console.ReadLine();
            Console.WriteLine("Please Enter the Course's Name: ");
            string coursename = Console.ReadLine();
            var student = StudentList.Find(stu => stu.Name.Equals(studentname, StringComparison.OrdinalIgnoreCase));
            var course = CourseList.Find(cou => cou.Name.Equals(coursename, StringComparison.OrdinalIgnoreCase));
            if ( student== null)
            {
                Console.WriteLine("Student Does Not Exist");

            }
            else if (course == null)
            {
                Console.WriteLine("Course Does Not Exist");

            }
            else if (course.Roster.Contains(student))
            {
                Console.WriteLine("Student is already enrolled in Course");

            }
            else
            {
                course.Roster.Add(student);
            }

        }

        public void RemoveStudent(Manager manager)
        {
            // find the correct student
            Console.WriteLine("Please Enter the Student's Name: ");
            string studentname = Console.ReadLine();
            Console.WriteLine("Please Enter the Course's Name: ");
            string coursename = Console.ReadLine();
            var course = CourseList.Find(cou => cou.Name.Equals(coursename, StringComparison.OrdinalIgnoreCase));
            if (course != null)
            {
                var student = course.Roster.Find(stu => stu.Name.Equals(studentname, StringComparison.OrdinalIgnoreCase));
                if (student != null)
                {
                    course.Roster.Remove(student);
                }
                else
                {
                    Console.WriteLine("Student is not enrolled in Course");

                }
            }
            else
            {
                Console.WriteLine("Course Does Not Exist");
            }

        }

        public void ListCourses(Manager manager)
        {
            foreach (var course in manager.CourseList)
            {
                course.PrintCourseinList(course);
            }

        }

        public void SearchCourseName(Manager manager)
        {
            Console.WriteLine("Please Enter the Course's Name that you Wish to Search for: ");
            string coursename = Console.ReadLine();
            var course = CourseList.Find(cou => cou.Name.Equals(coursename, StringComparison.OrdinalIgnoreCase));
            if (course == null)
            {
                Console.WriteLine("Course does not exist");
            }
            else
            {
                course.PrintCourse(course);
            }
        }

        public void SearchCourseDescription(Manager manager)
        {
            Console.WriteLine("Please Enter the Course's Description that you Wish to Search for: ");
            string coursedescription = Console.ReadLine();
            var course = CourseList.Find(cou => cou.Description.Equals(coursedescription, StringComparison.OrdinalIgnoreCase));
            if (course == null)
            {
                Console.WriteLine("Course does not exist");
            }
            else
            {
                course.PrintCourse(course);
            }
        }

        public void ListStudents(Manager manager)
        {
            Console.WriteLine("Students:");
            foreach (var student in StudentList)
            {
                student.ToString();
            }
        }

        public void SearchStudent(Manager manager)
        {
            Console.WriteLine("Please Enter the Student's Name that you Wish to Search for: ");
            string studentname = Console.ReadLine();
            var student = StudentList.Find(stu => stu.Name.Equals(studentname, StringComparison.OrdinalIgnoreCase));
            if (student == null)
            {
                Console.WriteLine("Student does not exist");
            }
            else
            {
                student.ToString();
            }
        }

        public void ListStudentCourses(Manager manager)
        {
            // I think this function is bad cuz it goes through two lists and I think i could do it in another way so that it only goes through one
            Console.WriteLine("Please Enter the Student's Name: ");
            string studentname = Console.ReadLine();
            var student = StudentList.Find(stu => stu.Name.Equals(studentname, StringComparison.OrdinalIgnoreCase));
            if (student == null)
            {
                Console.WriteLine("Student does not exist");
            }
            else
            {
                foreach (var course in manager.CourseList)
                {
                    if (course.Roster.Any(stu => stu.Name.Equals(studentname, StringComparison.OrdinalIgnoreCase)))
                    {
                        Console.WriteLine(course.Name);
                    }
                }
            }
        }

        public void UpdateCourseInfo(Manager manager)
        {
            // Maybe later allow for the person to enter name or blah and then check to make sure that is the course they wanna update
            // by printing out the current information
            Console.WriteLine("Please Enter the Course's Name that you Wish to Update: ");
            string coursename = Console.ReadLine();
            var course = CourseList.Find(cou => cou.Name.Equals(coursename, StringComparison.OrdinalIgnoreCase));
            if (course == null)
            {
                Console.WriteLine("Course does not exist");
            }
            else
            {
                course.UpdateCourse(course);
            }
        }

        public void UpdateStudentInfo(Manager manager)
        {
            // Maybe later allow for the person to enter name or blah and then check to make sure that is the course they wanna update
            // by printing out the current information
            Console.WriteLine("Please Enter the Student's Name that you Wish to Update: ");
            string studentname = Console.ReadLine();
            var student = StudentList.Find(stu => stu.Name.Equals(studentname, StringComparison.OrdinalIgnoreCase));
            if (student == null)
            {
                Console.WriteLine("Student does not exist");
                // Maybe put a prompt by being like if you go back you can add the student but idk
            }
            else
            {
                Console.WriteLine("The student's name is currently: ", student.Name);
                Console.WriteLine("Please enter the new name: ");
                student.Name = Console.ReadLine();
                Console.WriteLine("The student's classification is currently: ", student.Classification);
                Console.WriteLine("Please enter the new classificaiton: ");
                Enum.TryParse(Console.ReadLine(), out PersonClassification NewClass);
                student.Classification = NewClass;
            }
        }

        public void CreateAssignment(Manager manager)
        {
            // Maybe later allow for the person to enter name or blah and then check to make sure that is the course they wanna update
            // by printing out the current information
            Console.WriteLine("Please Enter the Course's Name that will be assigned this Assignment: ");
            string coursename = Console.ReadLine();
            var course = CourseList.Find(cou => cou.Name.Equals(coursename, StringComparison.OrdinalIgnoreCase));
            if (course == null)
            {
                Console.WriteLine("Course does not exist");
            }
            else
            {
                course.AddAssignment(course);
            }
        }
    }   
}

