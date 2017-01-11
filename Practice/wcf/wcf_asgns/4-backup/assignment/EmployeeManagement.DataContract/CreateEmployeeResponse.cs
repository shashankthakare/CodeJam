using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    class CreateEmployeeResponse
    {
        [DataMember]
        public string Status { get; set; }

    }
}
