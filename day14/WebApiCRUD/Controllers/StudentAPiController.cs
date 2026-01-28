using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApiCRUD.Models;
namespace WebApiCRUD.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentAPIController : ControllerBase
{
    private readonly StudentsContext db;
    public StudentAPIController(StudentsContext db)
    {
        this.db=db;
    }
    [HttpGet]
        public ActionResult Get()
        {
            var students = db.StudentInfos.ToList();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var student = db.StudentInfos.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpPost("{id}")]
        public ActionResult Post(int id,StudentInfo student)
        {
            if (student == null)
            {
                return BadRequest("Student data is required");
            }

            var existingStudent = db.StudentInfos.Find(student.StudentId);
            if (existingStudent != null)
            {
                db.Entry(existingStudent).CurrentValues.SetValues(student);
                db.SaveChanges();
                return Ok(existingStudent);
            }

            db.StudentInfos.Add(student);
            db.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = student.StudentId }, student);
        }
        
        //[HttpPut("{id}")]
        //public ActionResult Put(int id, StudentInfo student)
        //{
        //    if (id != student.StudentId)
        //    {
        //        return BadRequest("Route ID and body ID mismatch");
        //    }

        //    var existingStudent = db.StudentInfos.Find(id);
        //    if (existingStudent == null)
        //    {
        //        return NotFound();
        //    }
        //    db.Entry(student).State= Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    db.SaveChanges();
        //    return Ok();
        //}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingStudent = db.StudentInfos.Find(id);
            if (existingStudent == null)
            {
                return NotFound();
            }
            db.StudentInfos.Remove(existingStudent);
            db.SaveChanges();
            return NoContent();
        }
        [HttpPatch]
        public ActionResult Patch(int id,StudentInfo student)
        {
            if(id != student.StudentId)
            {
                return BadRequest("Route ID and body ID mismatch");
            }
            var existingStudent = db.StudentInfos.Find(id);
            if(existingStudent == null)
            {
                return NotFound();
            }
            db.Entry(existingStudent).CurrentValues.SetValues(student);
            db.SaveChanges();
            return Ok();
        }
}
