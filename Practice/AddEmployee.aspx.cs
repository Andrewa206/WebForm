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
            if (isEdit())
            {
                GetInitialValues();
            }


        }


        public bool isEdit()
        {

            int id = Convert.ToInt32(Request.QueryString["id"]);
            if (id != 0)
                return true;
            return false;
        }

        private void GetInitialValues()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Employee em = ManagersList.Find(x => x.Id == id);


            Getname.Text = em.Name;
            GetId.Text = em.Id.ToString();
            GetSalary.Text = em.Salary.ToString();

            if (em.Manager == null)
            {
                DDList.SelectedValue="0";
            }
            else
            {
                DDList.SelectedValue = em.Manager.Id.ToString();
            }
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            

                string name = Getname.Text;
                int id = Convert.ToInt32(GetId.Text);
                double salary = Convert.ToDouble(GetSalary.Text);
                int managerID = Convert.ToInt32(DDList.SelectedValue);

                Employee manager = ManagersList.Find(x => x.Id == managerID);

                if (isEdit())
                {
                   
                    SaveChanges(name, id, manager, salary);
                }
                else
                {
                    AddNewEmployee(name, id, manager, salary);
                }
                Response.Redirect("~/Employees.aspx");
            

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


    }
}
