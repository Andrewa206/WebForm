using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice
{
    public class Employee
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public Employee Manager{ get; set; }
        public double Salary { get; set; }

        public Employee() { }
        
        public Employee(string name,int id,Employee Manager,double salary)
        {
            this.Name = name;
            this.Id = id;
            this.Manager = Manager;
            this.Salary = salary;
        }

         
    }
}