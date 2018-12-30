namespace EnSyncPortal.Controllers.Validators.Interfaces
{
  public interface IEmployeeControllerValidator
  {
    /// <summary>
    /// Validates the employee identifier passed in.
    /// </summary>
    /// <param name="employeeId"></param>
    void ValidateEmployeeId(long employeeId);
  }
}
