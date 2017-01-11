using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.EmployeeManagement.DataContracts.Messages;
using Demo.EmployeeManagement.DataContracts;


namespace TestSuite
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ServiceTests
    {
        EmployeeManagementClient client;
        public ServiceTests()
        {
           
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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

            client = new EmployeeManagementClient();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (client != null)
            {
                if (client.State == System.ServiceModel.CommunicationState.Faulted)
                    client.Abort();
                else
                    client.Close();
            }
            client.CloseClient();
           
        }

        #endregion

        [TestMethod]
        public void TestCounter()
        {
            int counter = 0;
            counter = client.GetCounter();
            Console.WriteLine(counter.ToString());
        }

        [TestMethod]
        public void TestCreateEmployee_Success()
        {
            CreateEmployeeRQ request = new CreateEmployeeRQ(){ Employee = new Employee(){ Id = 100, Name = new Name(){ FirstName = "Rawan", LastName= "Lanka"}}, Team = "Clarifi"};
            client.CreateEmployee(request);
            
        }

        [TestMethod]
        public void TestCreateEmployee_Failure()
        {
            client.CreateEmployee(null);
            
        }

        public void TestExtensionMethod()
        {
            CreateEmployeeRequest request = null;
            request.Validate();
        }
    }
}
