using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeManagement.DataContracts;
using System.ServiceModel;

namespace EmployeeManagement.ServiceContracts
{
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        [FaultContract(typeof(DefaultFault))]
        Employee CreateEmployee(CreateEmployeeRequest employee);

        [OperationContract(IsOneWay = true)]
        void AddRemark(AddRemarkRequest remark);
    }
}