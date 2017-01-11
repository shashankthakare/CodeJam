using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    public class CreateEmployeeResponse
    {
        [DataMember]
        public Employee Employee { get; set; }

        [DataMember]
        public int Id { get; set; }


    }
}
