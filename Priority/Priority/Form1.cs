using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Priority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void AnimateProgBar1(int seconds)
        {
            if (!timer1.Enabled)
            {
                progressBar1.Value = 0;
                timer1.Interval = seconds / 100;
                timer1.Enabled = true;
            }
        }
        public void AnimateProgBar2(int seconds)
        {
            if (!timer2.Enabled)
            {
                progressBar2.Value = 0;
                timer2.Interval = seconds / 100;
                timer2.Enabled = true;
            }
        }
        public void AnimateProgBar3(int seconds)
        {
            if (!timer3.Enabled)
            {
                progressBar3.Value = 0;
                timer3.Interval = seconds / 100;
                timer3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prio1 = int.Parse(txtPrio1.Text);
            int prio2 = int.Parse(txtPrio2.Text);
            int prio3 = int.Parse(txtPrio3.Text);

            int time1 = int.Parse(textBox1.Text);
            int time2 = int.Parse(textBox2.Text);
            int time3 = int.Parse(textBox3.Text);

            progressBar1.Maximum = 100;
            progressBar2.Maximum = 100;
            progressBar3.Maximum = 100;

            Thread thread1 = new Thread(delegate ()
            {
                if (progressBar1.Value == time1)
                {
                    if (prio2 > prio3)
                    {
                        AnimateProgBar2(time2 * 1000);

                        if (progressBar2.Value == time2)
                        {
                            AnimateProgBar3(time3 * 1000);
                        }
                    }
                    else
                    {
                        AnimateProgBar3(time3 * 1000);

                        if (progressBar3.Value == time3)
                        {
                            AnimateProgBar2(time2 * 1000);
                        }
                    }
                }
            });

            Thread thread2 = new Thread(delegate ()
            {
                if (progressBar2.Value == time2)
                {
                    if (prio1 > prio3)
                    {
                        AnimateProgBar1(time1 * 1000);

                        if (progressBar1.Value == time1)
                        {
                            AnimateProgBar3(time3 * 1000);
                        }
                    }
                    else
                    {
                        AnimateProgBar3(time3 * 1000);

                        if (progressBar3.Value == time3)
                        {
                            AnimateProgBar1(time1 * 1000);
                        }
                    }
                }
            });

            Thread thread3 = new Thread(delegate ()
            {
                if (progressBar3.Value == time3)
                {
                    if (prio1 > prio2)
                    {
                        AnimateProgBar1(time1 * 1000);

                        if (progressBar1.Value == time1)
                        {
                            AnimateProgBar2(time2 * 1000);
                        }
                    }
                    else
                    {
                        AnimateProgBar2(time2 * 1000);

                        if (progressBar2.Value == time2)
                        {
                            AnimateProgBar1(time1 * 1000);
                        }
                    }
                }
            });

            if (prio1 > prio2 && prio1 > prio3)
            {
                AnimateProgBar1(time1 * 1000);
                thread1.Start();

                if (progressBar1.Value == progressBar1.Maximum && prio2 > prio3)
                {
                    AnimateProgBar2(time2 * 1000);
                }
                else
                {
                    AnimateProgBar3(time3 * 1000);
                }
            }

            if(prio2 > prio1 && prio2 > prio3)
            {
                thread2.Start();
                AnimateProgBar2(time2 * 1000);

               if(progressBar2.Value == progressBar2.Maximum && prio1 > prio3)
                {
                      AnimateProgBar1(time1 * 1000);
                }
                else
                {
                      AnimateProgBar3(time3 * 1000);
                }
            }

            if(prio3 > prio1 && prio3 > prio2)
            {  
                thread3.Start();
                AnimateProgBar3(time3 * 1000);
                
                if (progressBar3.Value == progressBar3.Maximum && prio1 > prio2)
                {
                    AnimateProgBar1(time1 * 1000);
                }
                else
                {
                    AnimateProgBar2(time2 * 1000);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Increment(1);
            }
            else
            {
                timer1.Enabled = false;
            } 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value < 100)
            {
                progressBar2.Increment(1); ;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar3.Value < 100)
            {
                progressBar3.Increment(1); ;
            }
            else
            {
                timer3.Enabled = false;
            }
        }
    }
}
