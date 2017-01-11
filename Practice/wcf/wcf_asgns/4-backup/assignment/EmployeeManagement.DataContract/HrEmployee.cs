using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace EmployeeManagement.DataContracts
{
    [DataContract]
    class HrEmployee:Employee
    {
        [DataMember]
        public string Skills { get; set; }
    }
}
