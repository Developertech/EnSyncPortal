using EnSyncPortal.Controllers.Validators.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace EnSyncPortal.Controllers.Validators.Implementations
{
  public class EmployeeControllerValidator : IEmployeeControllerValidator
  {
    #region Private Members
    /// <summary>
    /// logger variable
    /// </summary>
    private readonly ILogger<EmployeeControllerValidator> _logger;
    #endregion

    #region Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    public EmployeeControllerValidator(ILogger<EmployeeControllerValidator> logger)
    {
      _logger = logger;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Validates the employee identifier passed in.
    /// </summary>
    /// <param name="employeeId"></param>
    public void ValidateEmployeeId(long employeeId)
    {
      if (employeeId == 0)
      {
        //Experimenting in the ways in which I can return an error to the user. I prefer to use logger rather than
        //an ugly exception error. I will come back to error handling in the future.
        _logger.LogError("Error: The EmployeeId {employeeId} must be 1 or greater", employeeId);
        throw new Exception(string.Format("The employee identifier of {0} must be 1 or greater", employeeId));
      }
    }
    #endregion

  }
}
