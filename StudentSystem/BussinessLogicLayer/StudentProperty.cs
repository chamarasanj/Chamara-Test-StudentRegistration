using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLogicLayer
{
    public class StudentProperty
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public decimal GradePointAvg { get; set; }
        public bool  Active { get; set; }
    }
}
