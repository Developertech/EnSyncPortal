using EnSyncPortal.Models;
using EnSyncPortal.Models.Context;
using EnSyncPortal.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnSyncPortal.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository<Employee>
    {
        #region Private Members
        private readonly EmployeeContext _employeeContext;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="employeeContext"></param>
        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Retrieve All Employee Records
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeContext.Employees.ToList();
        }

        /// <summary>
        /// Get Employee By Employee Id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Employee GetByEmployeeId(long employeeId)
        {
            return _employeeContext.Employees
                  .FirstOrDefault(x => x.EMPLOYEE_ID == employeeId);
        }

        /// <summary>
        /// Add Employee
        /// </summary>
        /// <param name="entity"></param>
        public void AddEmployee(Employee entity)
        {
            _employeeContext.Employees.Add(entity);
            _employeeContext.SaveChanges();
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="entity"></param>
        public void UpdateEmployee(Employee employee, Employee entity)
        {
            employee.FIRST_NAME = entity.FIRST_NAME;
            employee.LAST_NAME = entity.LAST_NAME;
            employee.DOB = entity.DOB;
            employee.GENDER = entity.GENDER;
            employee.SSN = entity.SSN;
            employee.CONTROL_ID = entity.CONTROL_ID;
            
            _employeeContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="employee"></param>
        public void DeleteEmployee(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }
        #endregion
    }
}
