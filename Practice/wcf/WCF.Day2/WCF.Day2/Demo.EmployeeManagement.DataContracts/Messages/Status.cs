using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Demo.EmployeeManagement.DataContracts.Messages
{
    [DataContract]
    public enum Status
    {
        [EnumMember]
        Success,

        [EnumMember]
        Failure,

        [EnumMember]
        Warning

    }
}
