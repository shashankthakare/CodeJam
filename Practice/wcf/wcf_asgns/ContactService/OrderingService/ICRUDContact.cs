using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace ContactService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICRUDContact
    {
        [WebGet(UriTemplate="contact/{roll}")]
        [OperationContract]
        Contact GetContact(string roll);

        [WebInvoke(Method="POST", UriTemplate="contacts")]
        [OperationContract]
        bool SaveContact(Contact currentContact);

        [WebInvoke(Method = "DELETE", UriTemplate = "contact/{roll}")]
        [OperationContract]
        bool RemoveContact(string roll);

        [WebGet(UriTemplate = "contacts")]
        [OperationContract]
        List<Contact> GetAllContacts();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class Contact
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int Age { get; set; }
    }
}
