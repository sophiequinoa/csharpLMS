using LMSLibrary.Models;
using LMSMaui2.ViewModels;

namespace LMSMaui2.Views.InstructorViews
{
    public partial class DeleteStudentView
    {
        public DeleteStudentView()
        {
            InitializeComponent();
        }
        private void CancelClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//EditStudents");
        }

        private void DeleteStudentClicked(object sender, EventArgs e)
        { 

            Shell.Current.GoToAsync("//EditStudents");
        }
    }
}
