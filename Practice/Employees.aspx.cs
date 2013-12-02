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
        protected void Page_Load(object sender, EventArgs e)
        {
            var MyList=new EmployeeService().GetAll();
            //repeater1.DataSource = list;
            //repeater1.DataBind();

            gridView.DataSource = MyList;
            gridView.DataBind();

           

           
        }
    }
}