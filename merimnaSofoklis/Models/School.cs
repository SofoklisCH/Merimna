using System;
using System.Collections.Generic;

#nullable disable

namespace merimnaSofoklis.Models
{
    public partial class School
    {
        public School()
        {
            Faculties = new HashSet<Faculty>();
        }

        public int SchoolId { get; set; }
        public string ScoolText { get; set; }

        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
