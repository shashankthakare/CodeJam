using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    public static class ErrorMessages
    {
        [DataMember]
        public const string EmployeeAlreadyExist = "Employee Already Exist";

        [DataMember]
        public const string EmployeeDoesntExist = "Employee Doesn't Exist ";

        [DataMember]
        public const string CreateEmployeeRequestError = "Create Employee Request Error";

        [DataMember]
        public const string MemoryFull = "Memory is Full";

    }
}
