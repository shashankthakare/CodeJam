using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Demo.EmployeeManagement.DataContracts.Messages
{
    [DataContract]
    public class CreateEmployeeRQ
    {
        [DataMember]
        public Employee Employee { get; set; }

        [DataMember]
        public string Team { get; set; }

        [DataMember]
        public decimal Salary { get; set; }
    }
}
