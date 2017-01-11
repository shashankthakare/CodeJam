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
    public class EmployeeImplementation : ICreateEmployee, IReturnEmployees
    {
        List<Employee> employeeList = new List<Employee>();

        public Employee CreateEmployee(CreateEmployeeRequest employeeRequest)
        {
            var validationResult = Validator.Validate(employeeRequest);
            if (validationResult.IsSuccessful == false)
            {
                throw new FaultException<DefaultFault>(new DefaultFault()
                {
                    Error1 = ErrorMessages.CreateEmployeeRequestError
                });
            }
                bool EmployeeExists = employeeList.Exists(emp => emp.Name.FirstName == employeeRequest.Employee.Name.FirstName);
                if (employeeRequest.Employee != null && EmployeeExists != true)
                {
                    try{
                    employeeRequest.Employee.Id = employeeList.Count + 1;
                    employeeList.Add(employeeRequest.Employee);
                    return employeeRequest.Employee;
                        }catch (Exception e)
                        { throw new FaultException<DefaultFault>(new DefaultFault()
                        {
                        Error1 = ErrorMessages.MemoryFull
                        });
                        }
                }
                else
                    throw new FaultException<DefaultFault>(new DefaultFault()
                    {
                        Error1 = ErrorMessages.EmployeeAlreadyExist
                    });
            }
        
        public void AddRemark(AddRemarkRequest remarkRequest)
        {
            var validationResult = Validator.Validate(remarkRequest);
            if (validationResult.IsSuccessful == false)
            {
                throw new FaultException<DefaultFault>(new DefaultFault()
                {
                    Error1 = ErrorMessages.CreateEmployeeRequestError
                });
            }

            Employee employee = new Employee();
            employee = employeeList.Find(emp => emp.Id == remarkRequest.Id);
            if (employee != null)
            {
                employee.Remark.Add(remarkRequest.Remark);
            }
            else
            {
                throw new FaultException<DefaultFault>(new DefaultFault()
                {
                    Error1 = ErrorMessages.EmployeeDoesntExist
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
                    Error1 = ErrorMessages.EmployeeDoesntExist
                });
            }
        }



        public List<Employee> ReturnEmployeeList()
        {
            return employeeList;
        }
    }

}
