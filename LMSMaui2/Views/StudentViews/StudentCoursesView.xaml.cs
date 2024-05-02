using LMSLibrary.Models;
using LMSMaui2.ViewModels;

namespace LMSMaui2.Views.StudentViews
{
    public partial class StudentCoursesView
    {
        public StudentCoursesView()
        {
        }
        private void CancelClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Student");
        }
    }
}
