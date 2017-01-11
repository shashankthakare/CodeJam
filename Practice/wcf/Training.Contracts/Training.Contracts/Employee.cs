using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Training.Contracts
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        Name Name { get; set; }
        [DataMember]
        public Gender Gender { get; set; }

    }
    [DataContract]
    public enum Gender
    {[EnumMember]
        Male,
        [EnumMember]
        Female
    }
}
