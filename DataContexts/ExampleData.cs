using Student.Models;
using gender;

namespace DataContext
{
    public class StudentDataContext
    {
        private static StudentDataContext dataContext;
        public List<StudentModel> studentModel;
        public static StudentDataContext GetDataContextInstance()
        {
            if(dataContext is null) dataContext = new StudentDataContext();
            return dataContext;
        }
        private StudentDataContext()
        {
            studentModel = new List<StudentModel>();
            
            var initialListStudent = new List<StudentModel>()
            {
                new StudentModel()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John", 
                    LastName = "Doe", 
                    Gender = Gender.Male, 
                    DateOfBirth = new DateTime(1996,10,07), 
               
                    BirthPlace = "Hai Duong", 
         
                }
            ,
                new StudentModel()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Kristen", 
                    LastName = "Jackson", 
                    Gender = Gender.Female, 
                    DateOfBirth = new DateTime(2002,08,01), 
         
                    BirthPlace = "Hai Duong", 
       
                }
            ,
                new StudentModel()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Donald", 
                    LastName = "Trump", 
                    Gender = Gender.Male, 
                    DateOfBirth = new DateTime(2000,02,17), 
                
                    BirthPlace = "Ha Noi", 
                 
                }
            ,
                new StudentModel()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Steve", 
                    LastName = "Jobs", 
                    Gender = Gender.Male, 
                    DateOfBirth = new DateTime(1988,04,16), 
            
                    BirthPlace = "Ha Noi", 
         
                }
            ,
                new StudentModel()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Kate", 
                    LastName = "Lawson", 
                    Gender = Gender.Female, 
                    DateOfBirth = new DateTime(1999,06,21), 
           
                    BirthPlace = "Ha Noi", 
  
                }
            };
            studentModel.AddRange(initialListStudent);
        }
    }
}