using LMSMaui2.ViewModels;

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
}