using asp_web_api_2.Interfaces;
using DataContext;
using gender;
using  Student.Models;


namespace asp_web_api_2.Services;


public class StudentService : IStudentSerevice
{
    private List<StudentModel> listStudent = StudentDataContext.GetDataContextInstance().studentModel;

      public List<StudentModel> GetAll()
      {
          return listStudent;
      }
      public StudentModel GetById(Guid id)
      {
          var result = listStudent.FirstOrDefault(x=>x.Id == id);
          return result;
      }
    public StudentModel Add(StudentModel student)
    {
        listStudent.Add(student);
        return student;
    }


    public void Delete(Guid id)
    {
        if(id == null)
        {
        }
        
        StudentModel? target = listStudent.FirstOrDefault(x =>x.Id == id);
        if(target != null)
        {
            listStudent.Remove(target);
        }
    }

    public List<StudentModel> GetByBirthPlace(string location)
    {
        List<StudentModel> target = listStudent.Where(x =>x.BirthPlace == location).ToList();
        return target;
        
        
    }

    public List<StudentModel> GetByGender(Gender gender)
    {
        List<StudentModel> target = listStudent.Where(x =>x.Gender == gender).ToList();
        return target;
    }

    public List<StudentModel> GetByName(string name)
    {
           List<StudentModel> target = listStudent.Where(x =>x.FirstName.Contains(name)|| x.LastName.Contains(name)).ToList();
        return target;
    }

    public StudentModel Update(StudentModel student)
    {
        var target = listStudent.FirstOrDefault(x=>x.Id == student.Id);
        target.BirthPlace = student.BirthPlace;
        target.DateOfBirth = student.DateOfBirth;
        target.FirstName = student.FirstName;
        target.LastName = student.LastName;
        return target;
    }
}
