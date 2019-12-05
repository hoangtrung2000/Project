using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class EmployeeManagement
    {
        public Employee[] GetEmployees()
        {
            var db = new MyDatabaseEntities();
            return db.Employees.ToArray();
        }
        public void AddEmployee(string code, string name, DateTime birthday, string address, string location, int salary)
        {
            var newEmployee = new Employee();
            newEmployee.Code = code;
            newEmployee.Name = name;
            newEmployee.Birthday = birthday;
            newEmployee.Address = address;
            newEmployee.Location = location;
            newEmployee.Salary = salary;
        }
    }
}
