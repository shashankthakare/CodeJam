using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Training.Contracts
{
    [DataContract]
    public class CreateEmployeeRS
    {
        [DataMember]
        public Status Status { get; set; }
    }


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
