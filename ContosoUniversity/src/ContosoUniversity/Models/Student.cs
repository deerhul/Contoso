using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {

        [Key]
        public int StudentID { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "ERROR: Last Name can't be more than 50 characters")]
        public string LastName { get; set; }

        [Display(Name = "First / Middle Name")]
        [Column("FirstName")]
        [StringLength(50, ErrorMessage = "ERROR: First and/or Middle Name can't be more than 50 characters")]
        public string FirstMidName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

