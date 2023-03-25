using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Core
{
    public class Employee
    {
        public string FirstName { get; set; } = null!; 
        public string LastName { get; set; } = null!;
        public string FullName => $"{FirstName} {LastName}";
        public IEnumerable<PayItem> PayItems { get; set; }
    }
    //Symeolate like a source Db
    public class EmployeeDataReder
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                      FirstName="Mohamed",
                    LastName="Ahmed",  
                     PayItems=new List<PayItem>()
                     {
                     new PayItem() { Name="Basic salary",Value=1000 },
                     new PayItem() { Name="Transportaion",Value=250 },
                     new PayItem() { Name="Medical Insurance",Value=150 ,IsDeduction=true}
                     }
                },
                      new Employee()
                {
                    FirstName="Ibrahim",
                    LastName="Mahmpud", 
                     PayItems=new List<PayItem>()
                     {
                     new PayItem() { Name="Basic salary",Value=1000 },
                     new PayItem() { Name="Transportaion",Value=250 },
                     new PayItem() { Name="Medical Insurance",Value=-150 }
                     }
                }
            };
        }
    }

}
