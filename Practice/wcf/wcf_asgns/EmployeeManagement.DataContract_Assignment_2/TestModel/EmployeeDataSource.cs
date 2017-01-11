using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientReference;

namespace TestModel
{
    internal class EmployeeDataSource
    {
        internal List<Employee> GetAllEmployeeData()
        {
            List<Employee> sourceEmployeeList = new List<Employee>();
            sourceEmployeeList.Add(new Employee()
            {
                Name = new Name() { FirstName = "Saurav", MiddleName = "Dada", LastName = "Ganguly" },
                Gender = Gender.Male,
                Remarks = new List<Remark> { new Remark() { DateTime = DateTime.Now, Text = "KnightRiders" } }
            });

            sourceEmployeeList.Add(new Employee()
            {
                Name = new Name() { FirstName = "Sachin", MiddleName = "Ramesh", LastName = "Tendulkar" },
                Gender = Gender.Male,
                Remarks = new List<Remark> { new Remark() { DateTime = DateTime.Now, Text = "MasterBlaster" } }
            });
            sourceEmployeeList.Add(new Employee()
            {
                Name = new Name() { FirstName = "Mahendra", MiddleName = "Singh", LastName = "Dhoni" },
                Gender = Gender.Male,
                Remarks = new List<Remark> { new Remark() { DateTime = DateTime.Now, Text = "Champion" } }
            });
            sourceEmployeeList.Add(new Employee()
            {
                Name = new Name() { FirstName = "Rahul", MiddleName = "Sharad", LastName = "Dravid" },
                Gender = Gender.Male,
                Remarks = new List<Remark> { new Remark() { DateTime = DateTime.Now, Text = "Excellent" } }
            });

            return sourceEmployeeList;
        }

       
    }
}
