using LMSLibrary.Models;
using LMSMaui2.ViewModels;

namespace LMSMaui2.Views.InstructorViews
{
    public partial class DeleteCourseView
    {
        public DeleteCourseView()
        {
            InitializeComponent();
            BindingContext = new InstructorViewViewModel();

        }
        private void CancelClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Instructor");
        }

        private void DeleteCourseClicked(object sender, EventArgs e)
        {
            // Find the course with the specified name
            var courseToDelete = Database.Courses.FirstOrDefault(course => course.Name == course.Name);

            if (courseToDelete != null)
            {
                // Remove the course from the list
                Database.Courses.Remove(courseToDelete);

                Shell.Current.GoToAsync("//Instructor");
                
            }
            else
            {
                Console.WriteLine("Course not found!");
            }

            Shell.Current.GoToAsync("//Instructor");
        }
    }
}
