using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeManagement.DataContracts;
using EmployeeManagement.ServiceContracts;
using System.ServiceModel;



namespace EmployeeManagement.ServiceImplementation
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EmployeeImplementation : IEmployee, IEmployeeFunctions
    {
        List<Employee> listEmployees = new List<Employee>();

        public CreateEmployeeResponse CreateEmployee(CreateEmployeeRequest createEmployeeRequest)
        {
            var validationResult = ValidationLogic.Validate(createEmployeeRequest);
            if (validationResult.IsSuccessful == false)
            {
                throw new FaultException<FaultHandler>(new FaultHandler()
                {
                    ErrorMessage = DisplayError.CreateEmployeeRequestError
                });
            }

            bool IsEmployeeExists = listEmployees.Exists(emp => emp.Name.FirstName == createEmployeeRequest.Employee.Name.FirstName);
            if (createEmployeeRequest.Employee != null && IsEmployeeExists != true)
            {
                try
                {
                    createEmployeeRequest.Employee.Id = listEmployees.Count + 1;
                    listEmployees.Add(createEmployeeRequest.Employee);
                    return new CreateEmployeeResponse()
                    {
                        Employee = createEmployeeRequest.Employee,
                        Id = createEmployeeRequest.Employee.Id
                    };
                }
                catch (Exception exception)
                {
                    throw new FaultException<FaultHandler>(new FaultHandler()
                    {
                        ErrorMessage = DisplayError.MemoryFull
                    });
                }
            }
            else
                throw new FaultException<FaultHandler>(new FaultHandler()
                  {
                      ErrorMessage = DisplayError.EmployeeAlreadyExist
                  });
        }

        public void AddRemark(AddRemarkRequest addRemarkRequest)
        {
            var validationResult = ValidationLogic.Validate(addRemarkRequest);
            if (validationResult.IsSuccessful == false)
            {
                throw new FaultException<FaultHandler>(new FaultHandler()
                {
                    ErrorMessage = DisplayError.CreateEmployeeRequestError
                });
            }

            try
            {
                bool IsEmployeeExists = listEmployees.Exists(emp => emp.Id == addRemarkRequest.Id);
                if (IsEmployeeExists != false)
                {
                    Employee employee = listEmployees.Find(emp => emp.Id == addRemarkRequest.Id);
                    employee.Remarks.Add(addRemarkRequest.Remark);
                }
                else
                {
                    throw new FaultException<FaultHandler>(new FaultHandler()
                    {
                        ErrorMessage = DisplayError.EmployeeDoesntExist
                    });
                }
            }
            catch (Exception exception)
            {

            }

        }


        public Employee ReturnEmployee(int id)
        {

            bool IsEmployeeExists = listEmployees.Exists(emp => emp.Id == id);
            if (IsEmployeeExists != false)
            {
                Employee employee = listEmployees.Find(emp => emp.Id == id);
                return employee;
            }
            else
                throw new FaultException<FaultHandler>(new FaultHandler()
                {
                    ErrorMessage = DisplayError.EmployeeAlreadyExist
                });
        }



        public List<Employee> ReturnEmployeeList()
        {
            return listEmployees;
        }
    }

}
