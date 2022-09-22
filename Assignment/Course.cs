using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }

        public override string ToString()
        {
            return $"Course Details: {CourseId} {Name} {Fees}";

        }
    }
}
