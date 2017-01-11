using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement.ServiceImplementation
{
    public class ValidationCriterion
    {
        public bool IsSuccessful { get; set; }

        public List<string> InvalidFields { get; set; }

        public List<string> MissingFields { get; set; }
    }
}
