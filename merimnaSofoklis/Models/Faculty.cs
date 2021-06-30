using System;
using System.Collections.Generic;

#nullable disable

namespace merimnaSofoklis.Models
{
    public partial class Faculty
    {
        public int FacultyId { get; set; }
        public int? SchoolId { get; set; }
        public string FacultyText { get; set; }

        public virtual School School { get; set; }
    }
}
