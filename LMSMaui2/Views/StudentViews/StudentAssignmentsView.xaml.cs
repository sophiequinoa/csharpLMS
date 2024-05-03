using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSMaui2.Views.StudentViews
{
    public partial class StudentAssignmentsView
    {
        public StudentAssignmentsView()
        {
            InitializeComponent();
        }
        private void CancelClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Student");
        }
    }
}
