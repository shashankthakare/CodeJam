﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.EmployeeManagement.DataContracts.Messages
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CreateEmployeeRQ", Namespace = "http://schemas.datacontract.org/2004/07/Demo.EmployeeManagement.DataContracts.Mes" +
        "sages")]
    public partial class CreateEmployeeRQ : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private Demo.EmployeeManagement.DataContracts.Employee EmployeeField;

        private decimal SalaryField;

        private string TeamField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Demo.EmployeeManagement.DataContracts.Employee Employee
        {
            get
            {
                return this.EmployeeField;
            }
            set
            {
                this.EmployeeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Salary
        {
            get
            {
                return this.SalaryField;
            }
            set
            {
                this.SalaryField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Team
        {
            get
            {
                return this.TeamField;
            }
            set
            {
                this.TeamField = value;
            }
        }
    }
}
namespace Demo.EmployeeManagement.DataContracts
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Employee", Namespace = "http://schemas.datacontract.org/2004/07/Demo.EmployeeManagement.DataContracts")]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int IdField;

        private Demo.EmployeeManagement.DataContracts.Name NameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Demo.EmployeeManagement.DataContracts.Name Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Name", Namespace = "http://schemas.datacontract.org/2004/07/Demo.EmployeeManagement.DataContracts")]
    public partial class Name : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string FirstNameField;

        private string LastNameField;

        private string MiddleNameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName
        {
            get
            {
                return this.MiddleNameField;
            }
            set
            {
                this.MiddleNameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IEmployeeManagement")]
public interface IEmployeeManagement
{

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IEmployeeManagement/CreateEmployee")]
    void CreateEmployee(Demo.EmployeeManagement.DataContracts.Messages.CreateEmployeeRQ request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmployeeManagement/GetCounter", ReplyAction = "http://tempuri.org/IEmployeeManagement/GetCounterResponse")]
    int GetCounter();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IEmployeeManagementChannel : IEmployeeManagement, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class EmployeeManagementClient : System.ServiceModel.ClientBase<IEmployeeManagement>, IEmployeeManagement
{

    public EmployeeManagementClient()
    {
    }

    public EmployeeManagementClient(string endpointConfigurationName) :
        base(endpointConfigurationName)
    {
    }

    public EmployeeManagementClient(string endpointConfigurationName, string remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public EmployeeManagementClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public EmployeeManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
    {
    }

    public void CreateEmployee(Demo.EmployeeManagement.DataContracts.Messages.CreateEmployeeRQ request)
    {
        base.Channel.CreateEmployee(request);
    }

    public int GetCounter()
    {
        return base.Channel.GetCounter();
    }
}