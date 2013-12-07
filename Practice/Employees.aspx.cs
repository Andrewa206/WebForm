using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice
{
    public partial class Employees : System.Web.UI.Page
    {
        private EmployeeService es;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["list"] == null)
            {
                es = new EmployeeService();
                List<Employee> EmList = es.GetAll();
                Session["list"] = EmList;
            }
           
                GetgridView.DataSource = Session["list"];
                GetgridView.DataBind();
            
        }

         protected void gridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument.ToString());
            int id = (int)GetgridView.DataKeys[rowIndex].Value;

            if (e.CommandName == "Editeaza")
            { 

                Response.Redirect("~/AddEmployee.aspx?id=" + id);
            }


            else if (e.CommandName == "Sterge")
            {

                List<Employee> l = (List<Employee>)Session["list"];
                Employee empToDelete = l.Find(x => x.Id == id);
                for (int i = 0; i < l.Count(); i++)
                {
                    Employee emp = l.ElementAt(i);
                    if (emp.Manager != null && emp.Manager.Id == empToDelete.Id)
                        emp.Manager = null;

                }

            l.Remove(empToDelete);
            GetgridView.DataSource = Session["list"];
            GetgridView.DataBind();
            }
        }

    }
}
