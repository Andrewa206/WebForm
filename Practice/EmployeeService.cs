using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice
{
    

    public class EmployeeService
    {
        private List<Employee> newList=new List<Employee>();
        private List<Employee> Managers = new List<Employee>();


        public List<Employee> GetManagers()
        {
            Managers.Add(new Employee("Mihai", 1, null, 1023));
            Managers.Add(new Employee("Mihaela", 2, null, 789));
            Managers.Add(new Employee("Mirela", 3, null, 2345));
            Managers.Add(new Employee("Marius", 4, null, 1500));
            return Managers;
        }

         public List<Employee> GetAll()
        {
            GetManagers();
            newList.Add(new Employee("Gigel",11,Managers[1],700));
            newList.Add(new Employee("Laura",12,Managers[3],400));
            newList.Add(new Employee("Andrei", 13, Managers[0], 1000));
            newList.Add(new Employee("Ionut", 14, Managers[2], 900));
            newList.Add(new Employee("Gica",15,Managers[1],800));
            newList.Add(Managers[0]);
            newList.Add(Managers[1]);
            newList.Add(Managers[2]);
            newList.Add(Managers[3]);
            return newList;
        }
    }
}