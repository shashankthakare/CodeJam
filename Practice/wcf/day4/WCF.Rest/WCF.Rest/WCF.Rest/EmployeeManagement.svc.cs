using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF.Rest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class EmployeeManagement: IEmployeeManagement
    {
        public Employee GetEmployee(string id)
        {
            return new Employee() { FirstName = "Ajit", LastName = "Mulani" };
        }


        public Employee CreateEmployee(Employee employee)
        {
            return employee;
        }

        public Employee UpdateEmployee(string id, Employee employee)
        {
            return employee;
        }

        public bool DeleteEmployee(string id)
        {
            return true;
        }
    }
}
