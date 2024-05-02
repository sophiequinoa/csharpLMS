using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSLibrary.Models;

namespace LMSMaui2.ViewModels
{
    internal class InstructorViewViewModel
    {
        public ObservableCollection<Course> Courses
        {
            get
            {
                return new ObservableCollection<Course>(Database.Courses);
            }
        }

        public Course SelectedCourse { get; set; }

        public void AddNameClicked(Shell s)
        {
            s.GoToAsync($"//EditCourses");
        }

    }
}


