using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Employee
    {
        public Employee(int Id,string Name,string DepartmentName)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }
        public int GetId()
        {
            MethodCalled("GetId()");
            return Id;
        }
        public string GetName()
        {
            MethodCalled("GetName()");
            return Name;
        }
        public string GetDepartmentName()
        {
            MethodCalled("GetDepartmentName()");
            return DepartmentName;
        }
        public void UpdateEmployee(int Id)
        {
            MethodCalled("UpdateEmployee()");
            this.Id = Id;
        }
        public void UpdateEmployee(int Id,string Name)
        {
            MethodCalled("UpdateEmployee()");
            this.Id = Id;
            this.Name = Name;
        }
        public void UpdateEmployee(int Id,string Name,string DepartmentName)
        {
            MethodCalled("UpdateEmployee()");
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }

        private int Id { get; set; }
        private string Name { get; set; }
        private string DepartmentName { get; set; }
        public event MethodCalledDelegate MethodCalled;
    }
}
