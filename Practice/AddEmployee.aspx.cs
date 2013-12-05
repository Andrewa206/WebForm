using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        private List<Employee> ManagersList;

        protected void Page_Load(object sender, EventArgs e)
        {

            ManagersList = (List<Employee>)Session["list"];
            if (!IsPostBack)
            {
                DDList.DataSource = Session["list"];
                DDList.DataTextField = "Name";
                DDList.DataValueField = "Id";
                DDList.DataBind();
            }

           
        }

        private bool isEdit()
        {
            //int id = Convert.ToInt32(Request.QueryString["id"]);
            int id = Convert.ToInt32(GetId.Text);
            if (id != 0)
                return true;
            return false;
        }

        

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
           if(Page.IsValid)
           {
               //int idm = Convert.ToInt32(Request.QueryString["id"]);
               string name = Getname.Text;
               int id = Convert.ToInt32(GetId.Text);
               double salary = Convert.ToDouble(GetSalary.Text);
               int managerID = Convert.ToInt32(DDList.SelectedValue);

               Employee manager = ManagersList.Find(x => x.Id == managerID);

               
                   AddNewEmployee(name, id, manager, salary);
               
               Response.Redirect("~/Employees.aspx");

           }

        }

        protected void CancelBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Employees.aspx");
        }

        

        private void AddNewEmployee(string name, int id, Employee manager, double salary)
        {
            Employee em = new Employee(name, id, manager, salary);
            ManagersList.Add(em);
        }

        private void SaveChanges(string name, int id, Employee manager, double salary)
        {
            int idem = Convert.ToInt32(Request.QueryString["id"]);
            Employee em = ManagersList.Find(x => x.Id == idem);
            em.Name = name;
            em.Id = id;
            em.Manager = manager;
            em.Salary = salary;
        }

        public object myList { get; set; }
    }
        }
