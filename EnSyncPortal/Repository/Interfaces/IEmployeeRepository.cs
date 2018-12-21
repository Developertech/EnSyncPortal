using EnSyncPortal.Models;
using System.Collections.Generic;

namespace EnSyncPortal.Repository.Interfaces
{
    public interface IEmployeeRepository<TEntity>
    {
        /// <summary>
        /// Retrieve All Employee Records
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAllEmployees();

        /// <summary>
        /// Get Employee By Employee Id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        TEntity GetByEmployeeId(long employeeId);

        /// <summary>
        /// Add Employee
        /// </summary>
        /// <param name="entity"></param>
        void AddEmployee(TEntity entity);

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="entity"></param>
        void UpdateEmployee(Employee employee, TEntity entity);

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="employee"></param>
        void DeleteEmployee(Employee employee);
    }
}
