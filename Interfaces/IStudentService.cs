using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Student.Models;
using gender;

namespace asp_web_api_2.Interfaces;

    public interface IStudentSerevice
    {
        public List<StudentModel> GetAll();
        public StudentModel GetById(Guid id);
        public StudentModel Add(StudentModel student);
        public void Delete(Guid id);
        public StudentModel Update(StudentModel student);
        public List<StudentModel> GetByName(string name);
        public List<StudentModel> GetByGender(Gender gender);
        public List<StudentModel> GetByBirthPlace(string location);

    }
