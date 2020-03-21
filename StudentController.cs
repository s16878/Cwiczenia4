using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3.Controllers.Services;
using Cw3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        /*
        private IdbServices _dbServices;

        public StudentController(IdbServices service)
        {
            _dbServices = service;
        }
        */

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            //return "Kowalski, Malewski, Andrzejewski";
            var service = new MockDbServices();
            return Ok(service.GetStudents());
        }
        /*
        [HttpGet("{id}")]
        public IActionResult GetStudents(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Malewski");
            }

            return NotFound("Nie znaleziono studenta");
        }
        */
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 200)}";
            return Ok(student);
        }


        

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {

            var service = new MockDbServices();
            var stud = service.GetStudents().Where(s => s.IdStudent == id).FirstOrDefault<Student>();
            stud.IndexNumber = "2222";
            return Ok("Aktualizacja ukonczona");

        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            
        }




        private IEnumerable<int> MockDbServices()
        {
            throw new NotImplementedException();
        }
    }

}