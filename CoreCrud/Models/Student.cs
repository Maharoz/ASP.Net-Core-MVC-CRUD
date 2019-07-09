using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string StudentCode { get; set; }
        public string StudentYear { get; set; }
        public string CampusLocation { get; set; }

    }
}
