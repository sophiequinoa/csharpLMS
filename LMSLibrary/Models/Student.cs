using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class Student : Person
    {
        public Dictionary<int, double> Grades { get; set; }


        public Student() {
            Grades = new Dictionary<int, double>();
            Classification = PersonClassification.NA;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} - {Classification}";
        }


    }


}