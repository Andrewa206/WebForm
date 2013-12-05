using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice
{
    public partial class Employees1 : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                GetgridView.DataSource = Session["list"];
                GetgridView.DataBind();
            }
        }

        

    }
}
