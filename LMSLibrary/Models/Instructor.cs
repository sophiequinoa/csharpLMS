using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class Instructor : Person
    {

        public Instructor() {
            Classification = PersonClassification.Instructor;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} - {Classification}";
        }
    }
}