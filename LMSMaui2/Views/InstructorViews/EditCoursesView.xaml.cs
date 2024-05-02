using LMSMaui2.ViewModels;
using LMSLibrary.Models; 

namespace LMSMaui2.Views.InstructorViews;

public partial class EditCoursesView : ContentPage
{
	public EditCoursesView()
	{
		InitializeComponent();
		BindingContext = new EditViewViewModel();
	}

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Instructor");
    }
    private void AddCourseClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//AddCourse");
    }
    private void DeleteCourseClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//DeleteCourse");
    }
}