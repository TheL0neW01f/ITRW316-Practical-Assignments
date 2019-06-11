using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace ITRW316
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\WebPublish\\Process.mdb";
            OleDbConnection mydb = new OleDbConnection(conn);
            mydb.Open();
            OleDbDataAdapter query = new OleDbDataAdapter(@"SELECT * FROM process", mydb);
            OleDbCommand cmd  = new OleDbCommand("INSERT INTO processes(name, arrival_time, running_time) VALUES('" + txtArr1.Text + "'," + int.Parse(txtRun1.Text) + "," + int.Parse(txtArr2.Text) + ")", mydb);
            OleDbCommand cmd1 = new OleDbCommand("INSERT INTO processes(name, arrival_time, running_time) VALUES('2'," + int.Parse(txtArr2.Text) + "," + int.Parse(txtRun2.Text) + ")", mydb);
            OleDbCommand cmd2 = new OleDbCommand("INSERT INTO processes(name, arrival_time, running_time) VALUES('3'," + int.Parse(txtArr3.Text) + "," + int.Parse(txtRun3.Text) + ")", mydb);
            OleDbCommand cmd3 = new OleDbCommand("INSERT INTO processes(name, arrival_time, running_time) VALUES('4'," + int.Parse(txtArr4.Text) + "," + int.Parse(txtRun4.Text) + ")", mydb);
            query.InsertCommand = cmd;
            query.InsertCommand.ExecuteNonQuery();
            query.InsertCommand = cmd1;
            query.InsertCommand.ExecuteNonQuery();
            query.InsertCommand = cmd2;
            query.InsertCommand.ExecuteNonQuery();
            query.InsertCommand = cmd3;
            query.InsertCommand.ExecuteNonQuery();
            mydb.Close();

            //Code above accesses the database and fills in the data from the textboxes

            Session["Process1_Name"] = "P1";
            Session["Process2_Name"] = "P2";
            Session["Process3_Name"] = "P3";
            Session["Process4_Name"] = "P4";

            //Code above assigns process names to variable that is used to send the data to the next form

            Session["Process1_Arrival"] = txtArr1.Text;
            Session["Process2_Arrival"] = txtArr2.Text;
            Session["Process3_Arrival"] = txtArr3.Text;
            Session["Process4_Arrival"] = txtArr4.Text;

            //Code above assigns process arrival times to variable that is used to send the data to the next form

            Session["Process1_Run"] = txtRun1.Text;
            Session["Process2_Run"] = txtRun2.Text;
            Session["Process3_Run"] = txtRun3.Text;
            Session["Process4_Run"] = txtRun4.Text;

            Response.Redirect("Multiple Queues.aspx"); //Navigates to next page
        }

    }
}