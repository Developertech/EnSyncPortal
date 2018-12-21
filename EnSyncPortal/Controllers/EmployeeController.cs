using EnSyncPortal.Models;
using EnSyncPortal.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EnSyncPortal.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository<Employee> _employeeRepository;

        public EmployeeController(IEmployeeRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            IEnumerable<Employee> employees = _employeeRepository.GetAllEmployees();
            return Ok(employees);
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "GetByEmployeeId")]
        public IActionResult GetByEmployeeId(long employeeId)
        {
            Employee employee = _employeeRepository.GetByEmployeeId(employeeId);

            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(employee);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }

            _employeeRepository.AddEmployee(employee);
            return CreatedAtRoute(
                  "Get",
                  new { Id = employee.EMPLOYEE_ID },
                  employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{employeeId}")]
        public IActionResult Put(long employeeId, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }

            Employee employeeToUpdate = _employeeRepository.GetByEmployeeId(employeeId);
            if (employeeToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _employeeRepository.UpdateEmployee(employeeToUpdate, employee);
            return NoContent();
        }

        // DELETE: api/Employee/5
        [HttpDelete("{employeeId}")]
        public IActionResult Delete(long employeeId)
        {
            Employee employee = _employeeRepository.GetByEmployeeId(employeeId);
            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _employeeRepository.DeleteEmployee(employee);
            return NoContent();
        }
    }
}
