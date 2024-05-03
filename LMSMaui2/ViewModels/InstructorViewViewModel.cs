using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LMSLibrary.Models;

namespace LMSMaui2.ViewModels
{
    internal class InstructorViewViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Course> Courses
        {
            get
            {
                return new ObservableCollection<Course>(Database.Courses);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Course SelectedCourse { get; set; }

        public void AddNameClicked(Shell s)
        {
            s.GoToAsync($"//EditCourses");
        }

        public void RefreshView()
        {

            NotifyPropertyChanged(nameof(Courses));
        }


    }
}


