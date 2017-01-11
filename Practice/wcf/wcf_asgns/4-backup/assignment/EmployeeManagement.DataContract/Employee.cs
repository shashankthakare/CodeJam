using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    public abstract class Employee:Person
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Name Name { get; set; }

        [DataMember]
        public Gender Gender { get; set; }

        [DataMember]
        public List<Remark> Remarks { get; set; }

    }
    [DataContract]
    public enum Gender
    {
        [EnumMember]
        Male,

        [EnumMember]
        Female
    
    }
}
