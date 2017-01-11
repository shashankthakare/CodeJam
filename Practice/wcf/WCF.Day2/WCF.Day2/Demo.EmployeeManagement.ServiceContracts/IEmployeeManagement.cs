using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Demo.EmployeeManagement.DataContracts.Messages;
using Demo.EmployeeManagement.DataContracts;

namespace Demo.EmployeeManagement.ServiceContracts
{
    [ServiceContract]
    public interface IEmployeeManagement
    {
        [OperationContract(IsOneWay=true)]
        void CreateEmployee(CreateEmployeeRQ request);

        [OperationContract]
        int GetCounter();
    }
}
