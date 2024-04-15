using LMSMaui.ViewModels;

namespace LMSMaui.Views.InstructorViews;

public partial class EditStudentsView : ContentPage
{
	public EditStudentsView()
	{
		InitializeComponent();
		BindingContext = new EditViewViewModel();
	}

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Instructor");
    }
}