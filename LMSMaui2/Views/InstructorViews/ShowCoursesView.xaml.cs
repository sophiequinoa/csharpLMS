using LMSLibrary.Models;
using LMSMaui2.ViewModels;

namespace LMSMaui2.Views.InstructorViews
{
    public partial class ShowCoursesView
    {
        public ShowCoursesView()
        {
            InitializeComponent();
            BindingContext = new InstructorViewViewModel();
        }
        private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
        {
            (BindingContext as InstructorViewViewModel).RefreshView();
        }
        private void CancelClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Instructor");
        }
    }
}
