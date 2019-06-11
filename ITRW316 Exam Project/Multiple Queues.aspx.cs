using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ITRW316
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            /*int pro1A = 0;
            int pro2A = 0;
            int pro3A = 0;
            int pro4A = 0;

            int pro1R = 0;
            int pro2R = 0;
            int pro3R = 0;
            int pro4R = 0;

            string pro1Name = "";
            string pro2Name = "";
            string pro3Name = "";
            string pro4Name = "";*/

            Thread.Sleep(500);

            /*string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\WebPublish\\Process.mdb";
            OleDbConnection mydb = new OleDbConnection(conn);
            mydb.Open();

            OleDbDataAdapter query = new OleDbDataAdapter("SELECT * FROM processes", mydb);
            OleDbCommand com = new OleDbCommand("SELECT * FROM processes", mydb);

            OleDbDataReader read = com.ExecuteReader();

            string x = "";

            while(read.Read())
            {
                pro1Name = read[0].ToString();
                pro1A = int.Parse(read[1].ToString());
                pro1R = int.Parse(read[2].ToString());
            }

            Label1.Text = pro1Name + " " + pro1A + " " + pro1R;

            for (int i = 0; i < 3; i++)
            {
                while (read.Read())
                {
                    pro2Name = read[i].ToString();
                    pro2A = int.Parse(read[i].ToString());
                    pro2R = int.Parse(read[i].ToString());
                }
            }
            Label2.Text = pro2Name + " " + pro2A + " " + pro2R;*/

            int pro1Arr = int.Parse(Session["Process1_Arrival"].ToString());
            int pro2Arr = int.Parse(Session["Process2_Arrival"].ToString());
            int pro3Arr = int.Parse(Session["Process3_Arrival"].ToString());
            int pro4Arr = int.Parse(Session["Process4_Arrival"].ToString());

            int[] arr = new int[4];
            arr[0] = pro1Arr;
            arr[1] = pro2Arr;
            arr[2] = pro3Arr;
            arr[3] = pro4Arr;

            //Code above fetches information about process arrival times from previous page

            int pro1Run = int.Parse(Session["Process1_Run"].ToString());
            int pro2Run = int.Parse(Session["Process2_Run"].ToString());
            int pro3Run = int.Parse(Session["Process3_Run"].ToString());
            int pro4Run = int.Parse(Session["Process4_Run"].ToString());

            //Code above fetches information about process running times from previous page

            string pro1 = Session["Process1_Name"].ToString();
            string pro2 = Session["Process2_Name"].ToString();
            string pro3 = Session["Process3_Name"].ToString();
            string pro4 = Session["Process4_Name"].ToString();

            //Code above fetches information about process names from previous page

            int slide1 = int.Parse(Slider1.Value);
            int slide2 = int.Parse(Slider2.Value);
            int slide3 = int.Parse(Slider3.Value);

            //Code above fetches quantums selected from the sliders

            List<string> queue1 = new List<string>();
            List<string> queue2 = new List<string>();
            List<string> queue3 = new List<string>();

            //List variable created to represent each queue

            int pro1RunNew = pro1Run - slide1;
            int pro2RunNew = pro2Run - slide1;
            int pro3RunNew = pro3Run - slide1;
            int pro4RunNew = pro4Run - slide1;

            //After each iteration, the process' the quantum of the current queue is subtracted from the process' running time

            int pro1RunFinal = pro1RunNew - slide2;
            int pro2RunFinal = pro2RunNew - slide2;
            int pro3RunFinal = pro3RunNew - slide2;
            int pro4RunFinal = pro4RunNew - slide2;

            //Code above creates the three queues

            if (pro1Arr < pro2Arr && pro1Arr < pro3Arr && pro1Arr < pro4Arr) //Checks if a process running time is more than zero
            {
                queue1.Add(pro1);
                //If running time is more than zero, process is added into the first queue
                for (int j = 0; j < slide1 && j < pro1Run; j++)
                {
                    Label1.Text += pro1 + " "; //Each iteration the process runs, it is displayed in a label on the user interface
                }
                if (pro1RunNew >= slide1 || pro1RunNew > 0)
                {
                    queue2.Add(pro1); //if the process still has any time left to run after being in the first queue, it is put into the second queue

                    for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                    {
                        Label2.Text += pro1 + " "; //
                    }
                }
                if (pro1RunNew > slide2)
                {
                    queue3.Add(pro1);

                    for (int i = 0; i < pro1RunFinal; i++)
                    {
                        Label3.Text += pro1 + " "; //If any more time is needed the process completes in the third queue
                    }
                }
                if (pro2Arr < pro3Arr && pro2Arr < pro4Arr)
                {
                    queue1.Add(pro2);
                    for (int j = 0; j < slide1 && j < pro2Run; j++)
                    {
                        Label1.Text += pro2 + " ";
                    }
                    if (pro2RunNew >= slide1 || pro2RunNew > 0)
                    {
                        queue2.Add(pro2);

                        for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                        {
                            Label2.Text += pro2 + " ";
                        }
                    }
                    if (pro2RunNew > slide2)
                    {
                        queue3.Add(pro2);

                        for (int i = 0; i < pro2RunFinal; i++)
                        {
                            Label3.Text += pro2 + " ";
                        }
                    }
                    if (pro3Arr < pro4Arr)
                    {
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                    }
                    if(pro4Arr < pro3Arr)
                    {
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                    }
                }

                if(pro3Arr < pro2Arr && pro3Arr < pro4Arr)
                {
                    queue1.Add(pro3);
                    for (int j = 0; j < slide1 && j < pro3Run; j++)
                    {
                        Label1.Text += pro3 + " ";
                    }
                    if (pro3RunNew >= slide1 || pro3RunNew > 0)
                    {
                        queue2.Add(pro3);

                        for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                        {
                            Label2.Text += pro3 + " ";
                        }
                    }
                    if (pro3RunNew > slide2)
                    {
                        queue3.Add(pro3);

                        for (int i = 0; i < pro3RunFinal; i++)
                        {
                            Label3.Text += pro3 + " ";
                        }
                    }
                    if (pro2Arr < pro4Arr)
                    {
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                    }
                    if(pro4Arr < pro2Arr)
                    {
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                    }
                }

                if(pro4Arr < pro2Arr && pro4Arr < pro3Arr)
                {
                    queue1.Add(pro4);
                    for (int j = 0; j < slide1 && j < pro4Run; j++)
                    {
                        Label1.Text += pro4 + " ";
                    }
                    if (pro4RunNew >= slide1 || pro4RunNew > 0)
                    {
                        queue2.Add(pro4);

                        for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                        {
                            Label2.Text += pro4 + " ";
                        }
                    }
                    if (pro4RunNew > slide2)
                    {
                        queue3.Add(pro4);

                        for (int i = 0; i < pro4RunFinal; i++)
                        {
                            Label3.Text += pro4 + " ";
                        }
                    }
                    if (pro2Arr < pro3Arr)
                    {
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                    }
                    if(pro3Arr < pro2Arr)
                    {
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                    }
                }
            }
            

            if(pro2Arr < pro1Arr && pro2Arr < pro3Arr && pro2Arr < pro4Arr)
            {
                queue1.Add(pro2);
                for (int j = 0; j < slide1 && j < pro2Run; j++)
                {
                    Label1.Text += pro2 + " ";
                }
                if (pro2RunNew >= slide1 || pro2RunNew > 0)
                {
                    queue2.Add(pro2);

                    for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                    {
                        Label2.Text += pro2 + " ";
                    }
                }
                if (pro2RunNew > slide2)
                {
                    queue3.Add(pro2);

                    for (int i = 0; i < pro2RunFinal; i++)
                    {
                        Label3.Text += pro2 + " ";
                    }
                }
                if (pro1Arr < pro3Arr && pro1Arr < pro4Arr)
                {
                    queue1.Add(pro1);
                   
                    for (int j = 0; j < slide1 && j < pro1Run; j++)
                    {
                        Label1.Text += pro1 + " "; 
                    }
                    if (pro1RunNew >= slide1 || pro1RunNew > 0)
                    {
                        queue2.Add(pro1);

                        for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                        {
                            Label2.Text += pro1 + " ";
                        }
                    }
                    if (pro1RunNew > slide2)
                    {
                        queue3.Add(pro1);

                        for (int i = 0; i < pro1RunFinal; i++)
                        {
                            Label3.Text += pro1 + " ";
                        }
                    }
                    if (pro3Arr < pro4Arr)
                    {
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                    }
                    if (pro4Arr < pro3Arr)
                    {
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                    }
                }
                if(pro3Arr < pro4Arr && pro3Arr < pro1Arr)
                {
                    queue1.Add(pro3);
                    for (int j = 0; j < slide1 && j < pro3Run; j++)
                    {
                        Label1.Text += pro3 + " ";
                    }
                    if (pro3RunNew >= slide1 || pro3RunNew > 0)
                    {
                        queue2.Add(pro3);

                        for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                        {
                            Label2.Text += pro3 + " ";
                        }
                    }
                    if (pro3RunNew > slide2)
                    {
                        queue3.Add(pro3);

                        for (int i = 0; i < pro3RunFinal; i++)
                        {
                            Label3.Text += pro3 + " ";
                        }
                    }
                    if (pro1Arr < pro4Arr)
                    {
                        queue1.Add(pro1);
                        
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                    }
                    if(pro4Arr < pro1Arr)
                    {
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                        queue1.Add(pro1);
                        
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                    }
                }
                if(pro4Arr < pro1Arr && pro4Arr < pro3Arr)
                {
                    queue1.Add(pro4);
                    for (int j = 0; j < slide1 && j < pro4Run; j++)
                    {
                        Label1.Text += pro4 + " ";
                    }
                    if (pro4RunNew >= slide1 || pro4RunNew > 0)
                    {
                        queue2.Add(pro4);

                        for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                        {
                            Label2.Text += pro4 + " ";
                        }
                    }
                    if (pro1Arr < pro3Arr)
                    {
                        queue1.Add(pro1);
                        
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                    }
                    if(pro3Arr < pro1Arr)
                    {
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                        queue1.Add(pro1);
                        
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                    }
                }
            }  

            if(pro3Arr < pro1Arr && pro3Arr < pro2Arr && pro3Arr < pro4Arr)
            {
                queue1.Add(pro3);
                for (int j = 0; j < slide1 && j < pro3Run; j++)
                {
                    Label1.Text += pro3 + " ";
                }
                if (pro3RunNew >= slide1 || pro3RunNew > 0)
                {
                    queue2.Add(pro3);

                    for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                    {
                        Label2.Text += pro3 + " ";
                    }
                }
                if (pro3RunNew > slide2)
                {
                    queue3.Add(pro3);

                    for (int i = 0; i < pro3RunFinal; i++)
                    {
                        Label3.Text += pro3 + " ";
                    }
                }
                if (pro1Arr < pro2Arr && pro1Arr < pro4Arr)
                {
                    queue1.Add(pro1);
                    
                    for (int j = 0; j < slide1 && j < pro1Run; j++)
                    {
                        Label1.Text += pro1 + " "; 
                    }
                    if (pro1RunNew >= slide1 || pro1RunNew > 0)
                    {
                        queue2.Add(pro1);

                        for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                        {
                            Label2.Text += pro1 + " ";
                        }
                    }
                    if (pro1RunNew > slide2)
                    {
                        queue3.Add(pro1);

                        for (int i = 0; i < pro1RunFinal; i++)
                        {
                            Label3.Text += pro1 + " ";
                        }
                    }
                    if (pro2Arr < pro4Arr)
                    {
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                    }
                    if(pro4Arr < pro2Arr)
                    {
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                    }
                }
                if(pro2Arr < pro1Arr && pro2Arr < pro4Arr)
                {
                    queue1.Add(pro2);
                    for (int j = 0; j < slide1 && j < pro2Run; j++)
                    {
                        Label1.Text += pro2 + " ";
                    }
                    if (pro2RunNew >= slide1 || pro2RunNew > 0)
                    {
                        queue2.Add(pro2);

                        for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                        {
                            Label2.Text += pro2 + " ";
                        }
                    }
                    if (pro2RunNew > slide2)
                    {
                        queue3.Add(pro2);

                        for (int i = 0; i < pro2RunFinal; i++)
                        {
                            Label3.Text += pro2 + " ";
                        }
                    }
                    if (pro1Arr < pro4Arr)
                    {
                        queue1.Add(pro1);
                        
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                    }
                    if(pro4Arr < pro1Arr)
                    {
                        queue1.Add(pro4);
                        for (int j = 0; j < slide1 && j < pro4Run; j++)
                        {
                            Label1.Text += pro4 + " ";
                        }
                        if (pro4RunNew >= slide1 || pro4RunNew > 0)
                        {
                            queue2.Add(pro4);

                            for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                            {
                                Label2.Text += pro4 + " ";
                            }
                        }
                        if (pro4RunNew > slide2)
                        {
                            queue3.Add(pro4);

                            for (int i = 0; i < pro4RunFinal; i++)
                            {
                                Label3.Text += pro4 + " ";
                            }
                        }
                        queue1.Add(pro1);

                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                    }
                }
                if(pro4Arr < pro1Arr && pro4Arr < pro2Arr)
                {
                    queue1.Add(pro4);
                    for (int j = 0; j < slide1 && j < pro4Run; j++)
                    {
                        Label1.Text += pro4 + " ";
                    }
                    if (pro4RunNew >= slide1 || pro4RunNew > 0)
                    {
                        queue2.Add(pro4);

                        for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                        {
                            Label2.Text += pro4 + " ";
                        }
                    }
                    if (pro4RunNew > slide2)
                    {
                        queue3.Add(pro4);

                        for (int i = 0; i < pro4RunFinal; i++)
                        {
                            Label3.Text += pro4 + " ";
                        }
                    }
                    if (pro1Arr < pro2Arr)
                    {
                        queue1.Add(pro1);
                        
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }

                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                    }
                    if(pro2Arr < pro1Arr)
                    {
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        queue1.Add(pro1);

                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                            if (pro2RunNew >= slide1 || pro2RunNew > 0)
                            {
                                queue2.Add(pro2);

                                for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                                {
                                    Label2.Text += pro2 + " ";
                                }
                            }
                            if (pro2RunNew > slide2)
                            {
                                queue3.Add(pro2);

                                for (int i = 0; i < pro2RunFinal; i++)
                                {
                                    Label3.Text += pro2 + " ";
                                }
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                    }
                }
            }
            
            if(pro4Arr < pro1Arr && pro4Arr < pro2Arr && pro4Arr < pro3Arr)
            {
                queue1.Add(pro4);
                for (int j = 0; j < slide1 && j < pro4Run; j++)
                {
                    Label1.Text += pro4 + " ";
                }
                if (pro4RunNew >= slide1 || pro4RunNew > 0)
                {
                    queue2.Add(pro4);

                    for (int i = 0; i < slide2 && i < pro4RunNew; i++)
                    {
                        Label2.Text += pro4 + " ";
                    }
                }
                if (pro4RunNew > slide2)
                {
                    queue3.Add(pro4);

                    for (int i = 0; i < pro4RunFinal; i++)
                    {
                        Label3.Text += pro4 + " ";
                    }
                }
                if (pro1Arr < pro2Arr && pro1Arr < pro3Arr)
                {
                    queue1.Add(pro1);
                   
                    for (int j = 0; j < slide1 && j < pro1Run; j++)
                    {
                        Label1.Text += pro1 + " "; 
                    }
                    if (pro1RunNew >= slide1 || pro1RunNew > 0)
                    {
                        queue2.Add(pro1);

                        for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                        {
                            Label2.Text += pro1 + " ";
                        }
                    }
                    if (pro1RunNew > slide2)
                    {
                        queue3.Add(pro1);

                        for (int i = 0; i < pro1RunFinal; i++)
                        {
                            Label3.Text += pro1 + " ";
                        }
                    }
                    if (pro2Arr < pro3Arr)
                    {
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                    }
                    if(pro3Arr < pro2Arr)
                    {
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                    }
                }
                if(pro2Arr < pro1Arr && pro2Arr < pro3Arr)
                {
                    queue1.Add(pro2);
                    for (int j = 0; j < slide1 && j < pro2Run; j++)
                    {
                        Label1.Text += pro2 + " ";
                    }
                    if (pro2RunNew >= slide1 || pro2RunNew > 0)
                    {
                        queue2.Add(pro2);

                        for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                        {
                            Label2.Text += pro2 + " ";
                        }
                    }
                    if (pro2RunNew > slide2)
                    {
                        queue3.Add(pro2);

                        for (int i = 0; i < pro2RunFinal; i++)
                        {
                            Label3.Text += pro2 + " ";
                        }
                    }
                    if (pro1Arr < pro3Arr)
                    {
                        queue1.Add(pro1);
                        
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                    }
                    if(pro3Arr < pro1Arr)
                    {
                        queue1.Add(pro3);
                        for (int j = 0; j < slide1 && j < pro3Run; j++)
                        {
                            Label1.Text += pro3 + " ";
                        }
                        if (pro3RunNew >= slide1 || pro3RunNew > 0)
                        {
                            queue2.Add(pro3);

                            for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                            {
                                Label2.Text += pro3 + " ";
                            }
                        }
                        if (pro3RunNew > slide2)
                        {
                            queue3.Add(pro3);

                            for (int i = 0; i < pro3RunFinal; i++)
                            {
                                Label3.Text += pro3 + " ";
                            }
                        }
                        queue1.Add(pro1);
                        
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                    }
                    
                }
                if(pro3Arr < pro1Arr && pro3Arr < pro2Arr)
                {
                    queue1.Add(pro3);
                    for (int j = 0; j < slide1 && j < pro3Run; j++)
                    {
                        Label1.Text += pro3 + " ";
                    }
                    if (pro3RunNew >= slide1 || pro3RunNew > 0)
                    {
                        queue2.Add(pro3);

                        for (int i = 0; i < slide2 && i < pro3RunNew; i++)
                        {
                            Label2.Text += pro3 + " ";
                        }
                    }
                    if (pro3RunNew > slide2)
                    {
                        queue3.Add(pro3);

                        for (int i = 0; i < pro3RunFinal; i++)
                        {
                            Label3.Text += pro3 + " ";
                        }
                    }
                    if (pro1Arr < pro2Arr)
                    {
                        queue1.Add(pro1);
                        
                        {
                            Label1.Text += pro1 + " ";
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " ";
                            }
                        }
                    }
                    if(pro2Arr < pro1Arr)
                    {
                        queue1.Add(pro2);
                        for (int j = 0; j < slide1 && j < pro2Run; j++)
                        {
                            Label1.Text += pro2 + " ";
                        }
                        if (pro2RunNew >= slide1 || pro2RunNew > 0)
                        {
                            queue2.Add(pro2);

                            for (int i = 0; i < slide2 && i < pro2RunNew; i++)
                            {
                                Label2.Text += pro2 + " ";
                            }
                        }
                        if (pro2RunNew > slide2)
                        {
                            queue3.Add(pro2);

                            for (int i = 0; i < pro2RunFinal; i++)
                            {
                                Label3.Text += pro2 + " "; 
                            }
                        }
                        queue1.Add(pro1);
                        for (int j = 0; j < slide1 && j < pro1Run; j++)
                        {
                            Label1.Text += pro1 + " "; 
                        }
                        if (pro1RunNew >= slide1 || pro1RunNew > 0)
                        {
                            queue2.Add(pro1);

                            for (int i = 0; i < slide2 && i < pro1RunNew; i++)
                            {
                                Label2.Text += pro1 + " ";
                            }
                        }
                        if (pro1RunNew > slide2)
                        {
                            queue3.Add(pro1);

                            for (int i = 0; i < pro1RunFinal; i++)
                            {
                                Label3.Text += pro1 + " ";
                            }
                        }
                    }
                }
            }
            ListBox1.Items.Add("Queue 1");
            foreach (string x in queue1)
            {
                ListBox1.Items.Add(x); //Listbox displays which process is in which queue after algorithm is executed
            }

            //After each iteration the quantum of the first queue is subtracted from the process' remaining running time
            ListBox1.Items.Add("Queue 2");
            foreach(string y in queue2)
            {
                ListBox1.Items.Add(y); //Listbox displays which process is in which queue after algorithm is executed
            }
    
            ListBox1.Items.Add("Queue 3");
            foreach (string z in queue3)
            {
                ListBox1.Items.Add(z); //Listbox displays which process is in which queue after algorithm is executed
            }
        }
    }
}