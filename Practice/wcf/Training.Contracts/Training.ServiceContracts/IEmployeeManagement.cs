using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Training.Contracts;

namespace Training.ServiceContracts
{
    [ServiceContract]
    public interface IEmployeeManagement
    {
        [OperationContract(Name = "CreateEmployee")]
        CreateEmployeeRS CreateEmployee(CreateEmployeeRQ Employee);


    }
}
