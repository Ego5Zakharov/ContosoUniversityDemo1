using System.ComponentModel.DataAnnotations;

namespace ContosoUniversityDemo.Models
{
    public class OfficeAssigment
    {
        [Key]
        public int InstructorId { get; set; }
        public string Location { get; set; }
        public Instructor Instructor { get; set; }
    }
}