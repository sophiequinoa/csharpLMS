 using LMSLibrary.Models;
using LMSMaui2.ViewModels;

namespace LMSMaui2.Views.InstructorViews;

public partial class AddCourseView : ContentPage
{
    public AddCourseView()
    {
        InitializeComponent();
        BindingContext = new EditViewViewModel();
    }

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//EditCourses");
    }

    private void AddNameClicked(object sender, EventArgs e)
    {
        var foo = nameInput.Text;
        Course course1 = new Course();
        course1.Name = foo;
        Database.Courses.Add(course1);

        Shell.Current.GoToAsync("//EditCourses");
    }

}

