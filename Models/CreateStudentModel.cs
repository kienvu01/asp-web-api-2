using gender;
namespace Student.Models;

     public class StudentCreateModel
    {
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? BirthPlace { get; set; }

    }
