using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuite
{
    public static class CreateEmployeeRequestExtension
    {
        public static void Validate(this CreateEmployeeRequest request)
        {
            if (request == null)
                return;
        }
    }
}
