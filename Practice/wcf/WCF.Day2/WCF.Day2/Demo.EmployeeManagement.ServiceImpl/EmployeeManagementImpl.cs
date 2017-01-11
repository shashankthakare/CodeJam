using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.EmployeeManagement.ServiceContracts;
using Demo.EmployeeManagement.DataContracts.Messages;
using System.Threading;
using Demo.EmployeeManagement.DataContracts;
using System.ServiceModel;

namespace Demo.EmployeeManagement.ServiceImpl
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class EmployeeManagementImpl : IEmployeeManagement
    {
        int counter = 0;
        public void CreateEmployee(CreateEmployeeRQ request)
        {
            Thread.Sleep(10000);
        }


        public int GetCounter()
        {
            counter++;
            return counter;
        }
    }
}
