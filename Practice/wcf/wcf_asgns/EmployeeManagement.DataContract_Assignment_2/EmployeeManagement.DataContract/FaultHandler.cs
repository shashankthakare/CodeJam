using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    public class FaultHandler
    {
       [DataMember]
       public string ErrorMessage { get; set; }
    }
}
