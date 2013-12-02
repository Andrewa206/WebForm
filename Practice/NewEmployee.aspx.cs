using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice
{
    public partial class NewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ManagersList = new EmployeeService().GetManagers();
            DDList.DataSource = ManagersList;
            DDList.DataTextField = "Name";
            DDList.DataValueField = "Id";
            DDList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            Session["list"] = myList;
           






        }

        public object myList { get; set; }
    }
}