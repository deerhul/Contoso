using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        ICollection<Enrollment> Enrollments { get; set; }
    }
}