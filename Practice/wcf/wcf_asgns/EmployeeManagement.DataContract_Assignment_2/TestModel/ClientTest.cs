using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientReference;
using System.ServiceModel;
namespace TestModel
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void EmployeeCreationDone()
        {
            EmployeeDataSource source = new EmployeeDataSource();
            List<Employee> employeeList = source.GetAllEmployeeData();
            EmployeeCreateClient client = new EmployeeCreateClient();
            try
            {
                for (int i = 0; i < employeeList.Count; i++)
                {
                    CreateEmployeeResponse createEmployeeResponse = client.CreateEmployee(new CreateEmployeeRequest() { Employee = employeeList[i], Team = "Voyager" });
                    Assert.AreEqual(createEmployeeResponse.Employee.Name.FirstName, employeeList[i].Name.FirstName, "Successful");
                    Assert.AreNotEqual(createEmployeeResponse.Employee.Id, 0, "Successful");
                }
            }
            catch (FaultException<DefaultFault> fault)
            {
                Assert.AreEqual(DisplayError.EmployeeAlreadyExist, fault.Detail.ErrorMessage);

            }


        }

        [TestMethod]
        public void ReturnEmployeeById()
        {
            try
            {
                EmployeeReturnClient client = new EmployeeReturnClient();
                Employee ReturnedEmployee = client.ReturnEmployee(1);
                Assert.IsNotNull(ReturnedEmployee);
                Assert.IsTrue(ReturnedEmployee.Id == 1);
            }

            catch (Exception e)
            {
                Assert.AreEqual(DisplayError.EmployeeAlreadyExist, e.Message);

            }

        }

        [TestMethod]
        public void AddRemarkToAnEmployee()
        {
            Remark remarkEmployee = new Remark() { DateTime = DateTime.Now, Text = "Can Do better" };
            EmployeeCreateClient client = new EmployeeCreateClient();
            client.AddRemark(new AddRemarkRequest() { Id = 1, Remark = remarkEmployee });


        }

        [TestMethod]
        public void ReturnEmployeeList()
        {
            EmployeeDataSource source = new EmployeeDataSource();
            List<Employee> employeeList = source.GetAllEmployeeData();
            EmployeeReturnClient client = new EmployeeReturnClient();
            List<Employee> list = client.ReturnEmployeeList();
            Assert.IsNotNull(list);
            Assert.AreEqual(list.Count, employeeList.Count);
        }




    }
}
