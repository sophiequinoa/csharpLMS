using LMSMaui.ViewModels;

namespace LMSMaui.Views.InstructorViews;

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
}