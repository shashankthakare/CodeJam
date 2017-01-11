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
    public class EmployeeImplementation : IEmployee, IEmployeeOperation
    {
        List<Employee> employeeList = new List<Employee>();

        public Employee CreateEmployee(CreateEmployeeRequest employeeRequest)
        {
            var validationResult = ValidatorExtension.Validate(employeeRequest);
            if (validationResult.IsSuccessful == false)
            {
                throw new FaultException<DefaultFault>(new DefaultFault()
                                                           {
                                                               ErrorMessage = ErrorMessages.CreateEmployeeRequestError
                                                           });
            }
            bool isEmployeeExists =
                employeeList.Exists(emp => emp.Name.FirstName == employeeRequest.Employee.Name.FirstName);
            if ( isEmployeeExists != true)
            {
                try
                {
                    employeeRequest.Employee.Id = employeeList.Count + 1;
                    employeeList.Add(employeeRequest.Employee);
                    return employeeRequest.Employee;
                }
                catch (Exception e)
                {
                    throw new FaultException<DefaultFault>(new DefaultFault()
                                                               {
                                                                   ErrorMessage = ErrorMessages.MemoryFull
                                                               });
                }
            }
            else
                throw new FaultException<DefaultFault>(new DefaultFault()
                                                           {
                                                               ErrorMessage = ErrorMessages.EmployeeAlreadyExist
                                                           });
        }

        public void AddRemark(AddRemarkRequest remarkRequest)
        {
            var validationResult = ValidatorExtension.Validate(remarkRequest);
            if (validationResult.IsSuccessful == false)
            {
                throw new FaultException<DefaultFault>(new DefaultFault()
                {
                    ErrorMessage = ErrorMessages.CreateEmployeeRequestError
                });
            }

            Employee employee =  employeeList.Find(emp => emp.Id == remarkRequest.Id);
            if (employee != null)
            {
                employee.Remarks.Add(remarkRequest.Remark);
            }
            else
            {
                throw new FaultException<DefaultFault>(new DefaultFault()
                {
                    ErrorMessage = ErrorMessages.EmployeeDoesntExist
                });
            }

        }


        public Employee ReturnEmployee(int id)
        {
            Employee employee = new Employee();
            employee = employeeList.Find(emp => emp.Id == id);
            if (employee != null)
            {
                return employee;
            }
            else
            {
                throw new FaultException<DefaultFault>(new DefaultFault()
                {
                    ErrorMessage = ErrorMessages.EmployeeDoesntExist
                });
            }
        }



        public List<Employee> ReturnEmployeeList()
        {
            return employeeList;
        }
    }

}
