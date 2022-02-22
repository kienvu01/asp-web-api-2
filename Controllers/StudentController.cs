using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asp_web_api_2.Interfaces;
using asp_web_api_2.Services;
using gender;
using Student.Models;


namespace asp_web_api_2.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        public IStudentSerevice _student;

        public StudentController(IStudentSerevice student)
        {
           _student = student;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _student.GetAll().AsEnumerable();;
            return new JsonResult(result);

        }
        [HttpGet("Name")]
        public IActionResult GetName(string name)
        {
            var result = _student.GetByName(name);
             return new JsonResult(result);
        }
         [HttpGet("Birth Place")]
        public IActionResult GetByBirthPlace(string location)
        {
            var result = _student.GetByBirthPlace(location);
             return new JsonResult(result);
        }
         [HttpGet("Gender")]
        public IActionResult GetByGender(Gender gender)
        {
            var result = _student.GetByGender(gender);
            return new JsonResult(result);
        }
        [HttpPost]
        public IActionResult Create(StudentCreateModel student)
        {
            var result = _student.Add(new StudentModel{
                Id = Guid.NewGuid(),
                BirthPlace = student.BirthPlace,
                DateOfBirth = student.DateOfBirth,
                Gender = student.Gender,
                FirstName = student.FirstName,
                LastName = student.LastName,
                
            });
            return new JsonResult(result);
        }
        [HttpPut]
        public IActionResult Edit(Guid id, StudentCreateModel student)
        {
            var result = _student.GetById(id);
            result.BirthPlace = student.BirthPlace;
            result.DateOfBirth = student.DateOfBirth;
            result.FirstName = student.FirstName;
            result.LastName = student.LastName;
            result.Gender = student.Gender;
            return new JsonResult(result);
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _student.Delete(id);
            return Ok();
        }
    }
}