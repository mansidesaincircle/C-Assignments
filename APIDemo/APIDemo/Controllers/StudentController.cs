using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    // Specifies the route template for the controller.
// [controller] is a token replaced with the controller's name (minus the "Controller" suffix).
    [Route("api/[controller]")]

    // Indicates that this class is an API controller.
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>
{
    new Student
    {
        id = 1,
        fname = "John",
        lname = "Doe",
        dept = "Engineering",
        gender = "Female",
        country = "USA",
        salary = 60000,
        dob = new DateTime(1995, 5, 15)
    },
    new Student
    {
        id = 2,
        fname = "Alice",
        lname = "Smith",
        dept = "Marketing",
        gender = "Male",
        country = "Canada",
        salary = 55000,
        dob = new DateTime(1990, 8, 22)
    },

};

        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET: api/Student/{id}
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = students.FirstOrDefault(s => s.id == id);

            if (student == null)
            {
                // If the student with the specified id is not found, return a 404 Not Found response.
                return NotFound();
            }

            // If the student is found, return a 200 OK response with the student data.
            return Ok(student);
        }


        // GET: api/Student/male
        [HttpGet("male")]
        public IEnumerable<Student> GetMaleStudents()
        {
            return students.Where(s => s.gender == "Male");
        }

        // GET: api/Student/Female
        [HttpGet("Female")]
        public IEnumerable<Student> GetFemaleStudents()
        {
            return students.Where(s => s.gender == "Female");
        }

         
        // POST: api/Student
        [HttpPost]
        public IActionResult AddStudent([FromBody] Student newStudent)
        {
            // Check if the newStudent is valid (you can add validation logic here)
            if (newStudent == null)
            {
                return BadRequest("Invalid student data");
            }

            // You can add additional validation logic here to ensure data integrity.

            // Assuming a simple scenario where you add the new student to the list:
            students.Add(newStudent);

            // Return a 201 Created response along with the added student data.
            return CreatedAtAction("GetStudentById", new { id = newStudent.id }, newStudent);
        }


        
        

        
    }
}
