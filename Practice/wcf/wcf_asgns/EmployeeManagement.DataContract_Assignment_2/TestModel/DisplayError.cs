using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TestModel
{
    [DataContract]
    public static class DisplayError
    {
        [DataMember]
        public const string EmployeeAlreadyExist = "Employee Already Exists";

        [DataMember]
        public const string EmployeeDoesntExist = "Employee Does not Exist ";

        [DataMember]
        public const string CreateEmployeeRequestError = "Create Employee Request Error";

        [DataMember]
        public const string MemoryFull = "Memory is Full";
    }
}
