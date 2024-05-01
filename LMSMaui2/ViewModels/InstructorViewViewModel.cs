using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSLibrary.Models;

namespace LMSMaui2.ViewModels
{
    internal class InstructorViewViewModel
    {
        void onAddStudent()
        {
            var student = new Student();
            FakeDatabase.Student.Add(student);
        }

    }
}


