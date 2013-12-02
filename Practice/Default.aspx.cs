using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string MyProperty { get { return ViewState["title"] == null ? "" : ViewState["title"].ToString(); } set { ViewState["title"] = value; } }
         
        protected void Page_Load(object sender, EventArgs e)
        {
            
                Button myButton = new Button();
                myButton.Text = "NewButton";
                myButton.ID = "newButton";
                MyPanel.Controls.Add(myButton);
                myButton.Click += myButton_Click;

                Button deleteButton = new Button();
                deleteButton.Text = "Delete Dinamic Button";
                MyPanel.Controls.Add(deleteButton);
                deleteButton.Click += deleteButton_Click;

                label2.Text += "Text Page_Load";
                this.Form.Target = "_blank";
           
        }

        void deleteButton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if(MyPanel.FindControl("newButton")!=null)
            MyPanel.Controls.Remove(MyPanel.FindControl("newButton"));
        }

        void myButton_Click(object sender, EventArgs e)
        {
            label.Text = "Label Text Changed";
          
           
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MyProperty))
            {
                Page.Title = MyProperty;
            }
            label2.Text += "Text Page_Prerender";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            label2.Text +="Text Page_Init";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            label2.Text += "Text Page_Unload";
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            label2.Text += "Text Page_PreiInit";
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            String nume = Request.Form["MyTextBox"];
            label.Text = nume;
            
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            String title = "New Title";
            MyProperty = title;
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(MyCheckBox.Checked)
                MyPanel.Visible = false;
            else MyPanel.Visible = true;
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            label2.Text+="Am apasat pe buton!!";
            //Page_PreiInit(sender, e);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

    }
}