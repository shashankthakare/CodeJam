using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeManagement.DataContracts;

namespace EmployeeManagement.ServiceImplementation
{
    public static class Validator
    {
        internal static ValidationResult Validate(CreateEmployeeRequest employeeRequest)
        {
            if (employeeRequest == null)
                return new ValidationResult() { IsSuccessful = false, MissingFields = new List<string>() { "CreateEmployeeRequest" } };
            return new ValidationResult() { IsSuccessful = true };
        }

        internal static ValidationResult Validate(AddRemarkRequest remarkRequest)
        {
            if (remarkRequest == null)
                return new ValidationResult() { IsSuccessful = false, MissingFields = new List<string>() { "AddRemarkRequest" } };
            return new ValidationResult() { IsSuccessful = true };
        }
    }
}
