using LMSMaui2.ViewModels;

namespace LMSMaui2.Views;

public partial class StudentView : ContentPage
{
	public StudentView()
	{
		InitializeComponent();
		BindingContext = new StudentViewViewModel();
	}

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

    private void StudentCoursesClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//StudentCourses");
    }

    private void ViewAssignmentsClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//StudentAssignments");
    }

}