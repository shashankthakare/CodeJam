using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

namespace ContactService
{
    [ServiceBehavior(InstanceContextMode= InstanceContextMode.Single)]
    public class CRUDContact : ICRUDContact
    {
        private List<Contact> _store;
        internal List<Contact> Store
        {
            get
            {
                this._store = this._store ?? this.LoadList();
                return this._store;
            }
        }

        private List<Contact> LoadList()
        {
            List<Contact> mylist = new List<Contact>();
            mylist.Add(new Contact { Id = 1, Name = "Abhishek", Address = "Kolkata", Age = 27 });
            mylist.Add(new Contact { Id = 2, Name = "Abhijit", Address = "Hyderbad", Age = 26 });
            mylist.Add(new Contact { Id = 3, Name = "Kunal", Address = "Pune", Age = 25 });
            mylist.Add(new Contact { Id = 4, Name = "Chris", Address = "Canada", Age = 37 });
            mylist.Add(new Contact { Id = 5, Name = "Nish", Address = "Trivandam", Age = 30 });
            return mylist;
        }

        #region ICRUDContact Members

        public Contact GetContact(string roll)
        {
            return this.Store.FirstOrDefault(item => item.Id.ToString().Equals(roll));
        }

        public bool SaveContact(Contact currentContact)
        {
            if (this.Store.Any(item => item.Id == currentContact.Id))
                return false;
            this.Store.Add(currentContact);
            return true;
        }

        public bool RemoveContact(string roll)
        {
            var currentContacts = this.Store.Where(item => item.Id.ToString().Equals(roll));

            if (currentContacts.Count() <= 0)
                return false;

            foreach (Contact currentContact in currentContacts)
                this.Store.Remove(currentContact);

            return true;
        }

        public List<Contact> GetAllContacts()
        {
            return this.Store;
        }

        #endregion
    }
}
