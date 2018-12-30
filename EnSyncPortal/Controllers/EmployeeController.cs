using EnSyncPortal.Controllers.Validators.Interfaces;
using EnSyncPortal.Models;
using EnSyncPortal.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace EnSyncPortal.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository<Employee> _employeeRepository;
        private readonly IEmployeeControllerValidator _validator;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeRepository<Employee> employeeRepository, IEmployeeControllerValidator validator,
          ILogger<EmployeeController> logger
          )
        {
            _employeeRepository = employeeRepository;
            _validator = validator;
            _logger = logger;
        }

        // GET: api/Employee
        [Route("~/api/GetAllEmployees")]
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            IEnumerable<Employee> employees = _employeeRepository.GetAllEmployees();
            
            return Ok(employees);
        }

        // GET: api/Employee/5
        [Route("~/api/GetByEmployeeId/{employeeId}")]
        [HttpGet]
        public IActionResult GetByEmployeeId(long employeeId)
        {
            _validator.ValidateEmployeeId(employeeId);
            Employee employee = _employeeRepository.GetByEmployeeId(employeeId);

            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(employee);
        }

        // POST: api/Employee
        [Route("~/api/AddEmployee")]
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            if (employee == null)
            {
                //TODO: Add custom validation. For now this will suffice.
                return BadRequest("Employee is null.");
            }

            _employeeRepository.AddEmployee(employee);
            //In the future I may want to return a message more descriptive than a 200 OK message.
            return Ok();
        }

        // PUT: api/Employee/5
        [Route("~/api/UpdateEmployee/{employeeId}")]
        [HttpPut]
        public IActionResult UpdateEmployee(long employeeId, [FromBody] Employee employee)
        {
            _validator.ValidateEmployeeId(employeeId);
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
            return NoContent(); //TODO: Review code to determine if a more meaningful message can be returned.
        }

        // DELETE: api/Employee/5
        [Route("~/api/DeleteEmployee/{employeeId}")]
        [HttpDelete]
        public IActionResult DeleteEmployee(long employeeId)
        {
            _validator.ValidateEmployeeId(employeeId);
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
