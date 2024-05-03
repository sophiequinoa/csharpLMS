using LMSLibrary.Models;
using LMSMaui2.ViewModels;

namespace LMSMaui2.Views.InstructorViews
{
    public partial class ShowStudentsView { 
        public ShowStudentsView()
        {
            InitializeComponent();
        }
        private void CancelClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Instructor");
        }
    }
}
