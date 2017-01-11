using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Demo.EmployeeManagement.DataContracts
{
    [DataContract]
    public class DefaultFault
    {
        [DataMember]
        public string Operation { get; set; }

        [DataMember]
        public string Error { get; set; }
    }
}
