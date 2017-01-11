using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Demo.EmployeeManagement.DataContracts.Messages
{
    [DataContract]
    public class CreateEmployeeRS
    {
        [DataMember]
        public Status ServiceStatus { get; set; }
    }
}
