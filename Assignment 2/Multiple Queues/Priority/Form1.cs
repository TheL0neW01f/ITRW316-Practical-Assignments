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

        async Task PutTaskDelay(int i)
        {
            await Task.Delay(i);
        }

        public int getMaxPriority(int[] arr)
        {
            int index = 0;
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    index = i;
                }
            }
            return index;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;

            int time1 = int.Parse(textBox1.Text);
            int time2 = int.Parse(textBox2.Text);
            int time3 = int.Parse(textBox3.Text);
            
            int[] priority = new int[3];

            priority[0] = int.Parse(txtPrio1.Text);
            priority[1] = int.Parse(txtPrio2.Text);
            priority[2] = int.Parse(txtPrio3.Text);

            for (int i = 0; i < 3; i++)
            {
                int index = getMaxPriority(priority);
                priority[index] = 0;
                if (index == 0)
                {
                    for (int j = 0; j <= 100; j++)
                    {
                        progressBar1.Value = j;
                        await PutTaskDelay(time1 * 10);
                    }
                }

                if (index == 1)
                {
                    for (int j = 0; j <= 100; j++)
                    {
                        progressBar2.Value = j;
                        await PutTaskDelay(time2 * 10);
                    }
                    priority[1] = 0;
                }

                if (index == 2)
                {
                    for (int j = 0; j <= 100; j++)
                    {
                        progressBar3.Value = j;
                        await PutTaskDelay(time3 * 10);
                    }
                    priority[2] = 0;
                }
            }
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (progressBar1.Value < 100)
            {
                progressBar1.Increment(1);
            }
            else
            {
                timer1.Enabled = false;
            }
            if(progressBar4.Value>0)
            {
                timer1.Stop();
            }*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*if (progressBar2.Value < 100)
            {
                progressBar2.Increment(1);
            }
            else
            {
                timer2.Enabled = false;
            }
            if (progressBar4.Value > 0)
            {
                timer2.Stop();
            }*/
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            /*if (progressBar3.Value < 100)
            {
                progressBar3.Increment(1);
            }
            else
            {
                timer3.Enabled = false;
            }
            if (progressBar4.Value > 0)
            {
                timer3.Stop();
            }*/
        }

        private async void btnNewProcess_Click(object sender, EventArgs e)
        {
            progressBar4.Value = 0;
            int time4 = int.Parse(txtNewProcess.Text);
            int[] priority = new int[3];
            int index = getMaxPriority(priority);
            priority[index] = 0;
            if (index == 0)
            {
                for (int j = 0; j <= 100; j++)
                {
                    progressBar4.Value = j;
                    await PutTaskDelay(time4 * 10);
                }

            }
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            /*if(progressBar4.Value<100)
            {
                progressBar4.Increment(1);
            }
            else
            {
                timer4.Enabled = false;
            }*/
        }
    }
}
