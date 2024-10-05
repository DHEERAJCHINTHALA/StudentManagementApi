using BALL.RepositoryServices;
using DALL.Models;
using DALL.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace StudentManagement.Controllers
{
    public class StudentsController : ApiController
    {

        StudentsRepository objdall = new StudentsRepository();

        StudentsRepositoryServices objball = new StudentsRepositoryServices();

        [HttpGet]
        [Route("api/students")]
        public IHttpActionResult GetAllStudents()
        {
            List<GetAll> students = objball.AllStudents();

            return Ok(students);
        }


        [HttpGet]
        [Route("api/students/{id}")]
        public IHttpActionResult GetStudentById(int id)
        {
            var student = objball.SingleStudents(id);
            if (student == null || !student.Any())
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        [Route("api/students")]
        public IHttpActionResult InsertStudent(Students student)
        {
            if (student == null)
            {
                return BadRequest("Invalid student data.");
            }

            int result = objball.InsertStudentRecord(student);
            if (result > 0)
            {
                return Ok("Student record inserted successfully.");
            }
            else
            {
                return BadRequest("Error inserting student record.");
            }
        }


        [HttpPut]
        [Route("api/students/{id}")]
        public IHttpActionResult UpdateStudent(int id, Students student)
        {
            if (student == null)
            {
                return BadRequest("Invalid student data.");
            }

            int result = objball.UpdateStudent(id, student);
            if (result > 0)
            {
                return Ok("Student record updated successfully.");
            }
            else
            {
                return BadRequest("Error updating student record.");
            }
        }


        [HttpDelete]
        [Route("api/students/{id}")]
        public IHttpActionResult DeleteStudent(int id)
        {
            int result = objball.DeleteStudent(id);
            if (result > 0)
            {
                return Ok("Student record deleted successfully.");
            }
            else
            {
                return BadRequest("Error deleting student record.");
            }
        }

    }
}
