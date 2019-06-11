using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ITRW316
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string path = "C:\\WebPublish\\file.txt";
        string x;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader(path);
            x = read.ReadToEnd();
            read.Close();
            Label2.Text = x;

            //Code above reads in the contents of the file and displays it on the user interface
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(path);
            object _lock = new object();
            lock (writer) //Locks the file while being written to, no other process may access the file while it is open
            {
                if (x.Contains(TextBox1.Text))
                { 
                    writer.Write(x.Replace(TextBox1.Text, TextBox2.Text));
                    writer.Close();
                }
            }
            StreamReader read = new StreamReader(path);
            string y = read.ReadToEnd();
            Label2.Text = y;
            read.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Processes.aspx"); //Navigates to next page
        }
    }
}