using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    public class Remark
    {
        [DataMember]
        public DateTime DateTime { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}
