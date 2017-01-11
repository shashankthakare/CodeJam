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
        public void CreateEmployeeSuccess()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Name = new Name() { FirstName = "Ram", MiddleName = "Mohan", LastName = "Prasad" };
            employee1.Gender = Gender.Male;
            try
            {
                CreateEmployeeClient client = new CreateEmployeeClient();
                Employee createEmployee1 = client.CreateEmployee(new CreateEmployeeRequest() { Employee = employee1, Team = "India" });
                 Assert.AreEqual(createEmployee1.Name.FirstName, employee1.Name.FirstName, "Successful");
            }
            catch (FaultException<DefaultFault> fault)
            {
                Assert.AreEqual(ErrorMessages.EmployeeAlreadyExist,fault.Detail.Error1);
            
            }
           

        }

        //[TestMethod]
        //public void FaultCheck()
        //{
        //    EmployeeClient client = new EmployeeClient();
        //    try
        //    {
        //        CreateEmployeeRS createEmployee = client.CreateEmployee(new CreateEmployeeRQ());
        //    }

        //    catch(FaultException fault)
        //    {

        //        Assert.AreEqual("It's A Fault",fault.Error,"Fault Detected");
        //    }
        //}

        //[TestMethod]
        //public void AddRemarkToAnEmployee()
        //{
        //    Remark remarkEmployee1 = new Remark() { DateTime = DateTime.Now, Text = "Very Good" };
        //    EmployeeClient client = new EmployeeClient();
        //    client.AddRemark(new AddRemarkRQ() { Id = 1, Remark = remarkEmployee1 });


        //}

        //[TestMethod]
        //public void ReturnsAnEmployeeById()
        //{
        //    ReturnEmployeeClient client = new ReturnEmployeeClient();
        //    Employee ReturnedEmployee = client.ReturnEmployee(1);
        //    Assert.IsNotNull(ReturnedEmployee);
        //    Assert.IsTrue(ReturnedEmployee.Id == 1);

        //}

        //[TestMethod]
        //public void ReturnsAnEmployeeList()
        //{
        //    ReturnEmployeeClient client = new ReturnEmployeeClient();
        //    Employee[] list = client.ReturnEmployeeList();
        //    Assert.IsNotNull(list);
        //    Assert.IsTrue(list.Length >= 2);
        //}

    }
}
