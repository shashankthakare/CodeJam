using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using EmployeeManagement.DataContracts;


namespace EmployeeManagement.ServiceContracts
{
    [ServiceContract]
    public interface IReturnEmployees
    {
        [OperationContract]
        Employee ReturnEmployee(int id);

        [OperationContract]
        List<Employee> ReturnEmployeeList();
    }
}
