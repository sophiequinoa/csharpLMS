using LMSMaui.ViewModels;

namespace LMSMaui.Views;

public partial class InstructorView : ContentPage
{
	public InstructorView()
	{
		InitializeComponent();
		BindingContext = new InstructorViewViewModel();
	}

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
	private void EditCoursesClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//EditCourses");
    }
	private void EditStudentsClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//EditStudents");
    }
}