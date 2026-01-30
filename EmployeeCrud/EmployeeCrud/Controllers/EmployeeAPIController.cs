using EmployeeCrud.Models;
using EmployeeCrud.DTO;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace EmployeeCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeAPIController : ControllerBase
    {
        public readonly DumContext db;
        public readonly IMapper mapper;
        public EmployeeAPIController(DumContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var empDto = mapper.Map<List<EmployeeRead>>(db.EmployeeInfos.Where(e => !e.Isdeleted).ToList());
            return Ok(empDto);
        }
        [HttpPost]
        public IActionResult AddEmployee(EmployeeCreate emp)
        {
            var empEntity = mapper.Map<EmployeeInfo>(emp);
            db.EmployeeInfos.Add(empEntity);
            db.SaveChanges();
            return Ok(empEntity);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(EmployeeUpdate empDto, int id)
        {
            var emp = db.EmployeeInfos.Find(id);
            if (emp == null)
            {
                return NotFound($"Employee with Id {id} does not exist");
            }
            mapper.Map(empDto, emp);
            db.SaveChanges();
            return Ok(emp);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var exists = db.EmployeeInfos.Find(id);
            if (exists == null)
            {
                return NotFound("Employee doesnot exists");
            }
            exists.Isdeleted= true;
            db.SaveChanges();
            return Ok("Employee deleted successfully");
        }
    }
}