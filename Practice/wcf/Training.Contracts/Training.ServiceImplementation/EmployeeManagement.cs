using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Training.ServiceContracts;
using Training.Contracts;

namespace Training.ServiceImplementation
{
    public class EmployeeManagement: IEmployeeManagement
    {

        public CreateEmployeeRS CreateEmployee(CreateEmployeeRQ Employee)
        {
            return new CreateEmployeeRS() {Status=Status.Success} ;
        }
    }
}
