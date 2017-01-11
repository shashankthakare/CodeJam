using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.DataContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
//using TestModel.EmployeeImplementation.cs;
namespace TestModel
{
    [TestClass]
    public class ClientTest
    {
        CreateEmployeeClient createEmployeeClient;
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //

        [TestInitialize]
        public void TestInitialize()
        {

            createEmployeeClient = new CreateEmployeeClient();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (createEmployeeClient != null)
                createEmployeeClient.CloseClient();
        }

        #endregion


        [TestMethod]
        public void CreateEmployeeSuccess()
        {
            Employee employee1 = new Employee();

            employee1.Name = new Name() { FirstName = "Saurav", MiddleName = "Dada", LastName = "Ganguly" };
            employee1.Gender = Gender.Male;
            try
            {
                CreateEmployeeClient client = new CreateEmployeeClient();
                Employee createEmployee1 = client.CreateEmployee(new CreateEmployeeRequest() { Employee = employee1, Team = "KolkataKnightRiders" });
                Assert.AreEqual(createEmployee1.Name.FirstName, employee1.Name.FirstName, "Successful");
            }
            catch (FaultException<DefaultFault> fault)
            {
                Assert.AreEqual(ErrorMessages.EmployeeAlreadyExist, fault.Detail.Error1);

            }


        }
        
        [TestMethod]
        public void AddRemarkToAnEmployee()
        {
            Remark remarkEmployee1 = new Remark() { DateTime = DateTime.Now, Text = "improve naming conventions" };
            CreateEmployeeClient client = new CreateEmployeeClient();
            client.AddRemark(new AddRemarkRequest() { Id = 1, Remark = remarkEmployee1 });


        }

        [TestMethod]
        public void ReturnsAnEmployeeById()
        {
            ReturnEmployeesClient client = new ReturnEmployeesClient();
            Employee ReturnedEmployee = client.ReturnEmployee(1);
            Assert.IsNotNull(ReturnedEmployee);
            Assert.IsTrue(ReturnedEmployee.Id == 1);

        }

        [TestMethod]
        public void ReturnsAnEmployeeList()
        {
            ReturnEmployeesClient client = new ReturnEmployeesClient();
            Employee[] list = client.ReturnEmployeeList();
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Length >= 2);
        }


    }
}
