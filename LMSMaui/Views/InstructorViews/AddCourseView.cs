using LMSMaui.ViewModels;

namespace LMSMaui.Views.InstructorViews;

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
	
}