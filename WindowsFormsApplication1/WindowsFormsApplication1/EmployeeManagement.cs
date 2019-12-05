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

            var db = new MyDatabaseEntities();
            db.Employees.Add(newEmployee);
            db.SaveChanges();
        }
        public void EditClass(int id, string code, string name, DateTime birthday, string address, string location, int salary)
        {
            var db = new MyDatabaseEntities();
            var oldEmployee = db.Employees.Find(id);
            oldEmployee.Code = code;
            oldEmployee.Name = name;
            oldEmployee.Birthday = birthday;
            oldEmployee.Address = address;
            oldEmployee.Location = location;
            oldEmployee.Salary = salary;
            db.Entry(oldEmployee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            var db = new MyDatabaseEntities();
            var employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
        public Employee GetEmployee(int id)
        {
            var db = new MyDatabaseEntities();
            return db.Employees.Find(id);
        }

    }
}
