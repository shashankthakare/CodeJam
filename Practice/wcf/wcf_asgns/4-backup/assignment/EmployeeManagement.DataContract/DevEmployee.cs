using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace EmployeeManagement.DataContracts
{
    [DataContract]
    class DevEmployee:Employee
    {
        [DataMember]
        public string Technology { get; set; }
    }
}
