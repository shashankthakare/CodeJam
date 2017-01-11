using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    public class DefaultFault
    {
       [DataMember]
       public string Error1 { get; set; }
    }
}
