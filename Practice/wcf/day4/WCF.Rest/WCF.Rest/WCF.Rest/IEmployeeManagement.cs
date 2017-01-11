using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF.Rest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeManagement
    {
        [OperationContract]
        [WebGet(UriTemplate = "employee/{id}")]
        Employee GetEmployee(string id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "employee", RequestFormat = WebMessageFormat.Xml)]
        Employee CreateEmployee(Employee employee);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "employee/{id}")]
        Employee UpdateEmployee(string id, Employee employee);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "employee/{id}")]
        bool DeleteEmployee(string id);
    }
}