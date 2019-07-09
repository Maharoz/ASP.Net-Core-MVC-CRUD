using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Student Name")]
        public string StudentCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string StudentYear { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Campus Location")]
        public string CampusLocation { get; set; }

    }
}
