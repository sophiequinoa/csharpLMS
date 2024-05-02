using LMSLibrary.Models;

namespace LMSMaui2.Views.InstructorViews;

public partial class AddStudentView : ContentPage
{
	public AddStudentView()
	{
		InitializeComponent();
	}

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//EditStudents");
    }

    private void AddNameClicked(object sender, EventArgs e)
    {
        var foo = nameInput.Text;
        Course course1 = new Course();
        course1.Name = foo;
        Database.Courses.Add(course1);

        Shell.Current.GoToAsync("//EditStudents");
    }
}