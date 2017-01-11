using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using EmployeeManagement.DataContracts;

namespace Service
{
    public class ServiceSortingParameterInspector:IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            if (returnValue != null && returnValue is List<Employee>)
            {

                List<Employee> employeeList = returnValue as List<Employee>;
                employeeList = employeeList.OrderBy(x => x.Id).ToList();
                              
            } 
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            // No Implementation
            return null;
        }
    }
}