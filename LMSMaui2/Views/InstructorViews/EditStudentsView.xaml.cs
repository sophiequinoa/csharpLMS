using LMSMaui2.ViewModels;

namespace LMSMaui2.Views.InstructorViews;

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

    private void AddStudentClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//AddStudent");
    }

    private void DeleteStudentClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//DeleteStudent"); 
    }
}