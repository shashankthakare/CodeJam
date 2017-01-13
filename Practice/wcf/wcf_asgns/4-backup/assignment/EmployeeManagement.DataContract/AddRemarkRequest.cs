﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmployeeManagement.DataContracts
{
    [DataContract]
    public class AddRemarkRequest
    {
        [DataMember]
        public int Id;

        [DataMember]
        public Remark Remark;
    }
}