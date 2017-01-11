using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    
    abstract public class Person
    {
        [DataMember]
        public Name name { get; set; }
    }
}
