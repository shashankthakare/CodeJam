using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Training.Contracts
{
    [DataContract]
    public class CreateEmployeeRQ
    {
        [DataMember]
        public Employee Employee { get; set; }
        [DataMember]
        public string Team { get; set; }
    }
}
