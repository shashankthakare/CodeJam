using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeManagement.DataContracts;

namespace EmployeeManagement.ServiceImplementation
{
    public static class ValidationLogic
    {
        internal static ValidationCriterion Validate(CreateEmployeeRequest createEmployeeRequest)
        {
            if (createEmployeeRequest == null)
                return new ValidationCriterion() { IsSuccessful = false, MissingFields = new List<string>() { "CreateEmployeeRequest" } };
            return new ValidationCriterion() { IsSuccessful = true };
        }

        internal static ValidationCriterion Validate(AddRemarkRequest addRemarkRequest)
        {
            if (addRemarkRequest == null)
                return new ValidationCriterion() { IsSuccessful = false, MissingFields = new List<string>() { "AddRemarkRequest" } };
            return new ValidationCriterion() { IsSuccessful = true };
        }
    }
}
