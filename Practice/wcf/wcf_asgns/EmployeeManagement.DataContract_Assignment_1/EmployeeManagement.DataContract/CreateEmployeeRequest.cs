using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    public class CreateEmployeeRequest
    {
        [DataMember]
        public Employee Employee { get; set; }

        [DataMember]
        public string Team { get; set; }
    }
}
