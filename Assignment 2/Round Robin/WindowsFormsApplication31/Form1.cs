using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication31
{
    public partial class Form1 : Form
    {
        string[] array1 = new string[] { "1-A ", "2-A ", "3-A ", "4-A ", "5-A ", "6-A" };
        string[] array2 = new string[] { "1-B ", "2-B ", "3-B ", "4-B ", "5-B ", "6-B" , "7-B", "8-B"};
        string[] array3 = new string[] { "1-C ", "2-C ", "3-C ", "4-C " };
        string[] array4 = new string[] { "1-D ", "2-D ", "3-D ", "4-D ", "5-D "};
        public Form1()
        {
            InitializeComponent();
        }
        public void roundRobinTwoQ1(int quantum, String[] a1, String[] a2)
        {
            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i <= quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == quantum - 1) // for 2 of A
                {
                    for (int j = 0; j < quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter2++;
                    }
                }
                else if (i == quantum)
                {
                    listBox1.Items.Add(a2[quantum] + "\n");
                    counter2++;
                }
                counter1++;
            }

            int counter11 = counter1;
            int counter22 = counter2;

            for (int i = counter1; i <= counter1 + quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == counter1) // for 2 of A
                {
                    for (int j = counter2; j < counter2 + quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter22++;
                    }
                }
                else if (i == counter1 + 1)
                {
                    listBox1.Items.Add(a2[counter11] + "\n");
                    counter22++;
                }
                counter11++;
            }
            for (int j = counter11; j <= counter1 + (quantum + quantum); j++)//lastmod
            {
                listBox1.Items.Add(a1[j] + "\n");
            }

            for (int j = counter22; j < a2.Length; j++)
            {
                listBox1.Items.Add(a2[j] + "\n");
            }
        }
        public void roundRobinTwo(int quantum, string[] a1, string[] a2)
        {
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 0; i < quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == quantum - 1)
                {
                    for (int j = 0; j < quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter2++;
                    }
                }
                counter1++;
            }
            int counter11 = counter1;
            int counter22 = counter2;

            for (int i = counter1; i < counter1 + quantum; i++)
            {
                 listBox1.Items.Add(a1[i] + "\n");
                if (i == counter1 + 1)
                {
                    for (int j = counter2; j < counter2 + quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter22++;
                    }
                }
                counter11++;
            }
            for (int j = counter11; j < counter1 + (quantum + quantum); j++)
            {
                listBox1.Items.Add(a1[j] + "\n");
            }

            for (int j = counter22; j < a2.Length; j++)
            {
                listBox1.Items.Add(a2[j] + "\n");
            }
        }

        public void roundRobinTwoQ3(int quantum, String[] a1, String[] a2)
        {
            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == quantum - 1) // for 2 of A
                {
                    for (int j = 0; j < quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter2++;
                    }
                }
                counter1++;
            }

            int counter11 = counter1; 
            int counter22 = counter2; 

            for (int i = counter1; i < counter1 + quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == counter1 + 2)
                {
                    for (int j = counter2; j <= (counter2 + quantum) + 1; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter22++;
                    }
                }
                counter11++;
            }
        }
        public void roundRobinTwoQ4(int quantum, String[] a1, String[] a2)
        {

            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == quantum - 1) // for 2 of A
                {
                    for (int j = 0; j < quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter2++;
                    }
                }
                counter1++;
            }

            int counter11 = counter1;
            int counter22 = counter2; 

            for (int i = counter1; i < counter1 + 2; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == counter1 + 1) // for 2 of A
                {
                    for (int j = counter2; j <= (counter2 + (counter1 - 1)); j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter22++;
                    }
                }
                counter11++;
            }
        }


        public void roundRobinThree(int quantum, string[] a1, string[] a2, string[] a3)
        {
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;

            for (int i = 0; i < quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == quantum - 1)
                {
                    for (int j = 0; j < quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        if (j == quantum - 1)
                        {
                            for (int x = 0; x < quantum; x++)
                            {
                                listBox1.Items.Add(a3[x] + "\n");
                                counter3++;
                            }
                        }
                        counter2++;
                    }
                }
                counter1++;
            }

            int counter11 = counter1; 
            int counter22 = counter2; 
            int counter33 = counter3; 

            for (int i = counter1; i < counter1 + quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == counter1 + 1)
                {
                    for (int j = counter2; j < counter2 + quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        if (j == counter2 + 1)
                        {
                            for (int x = counter3; x < counter3 + quantum; x++)
                            {
                                listBox1.Items.Add(a3[x] + "\n");
                            }
                            counter33++;
                        }
                        counter22++;
                    }
                }
                counter11++;
            }

            int counter111 = counter11; 
            int counter222 = counter22; 
            int counter333 = counter33;

            for (int i = counter11; i < counter11 + quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == counter11 + 1)
                {
                    for (int j = counter22; j < counter22 + quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        counter222++;
                    }
                }
                counter111++;
            }

            for (int j = counter222; j < counter222 + quantum; j++)
            {
                listBox1.Items.Add(a2[j] + "\n");
            }

        }

        public void roundRobinFour(int quantum, string[] a1, string[] a2, string[] a3, string[] a4)
        {
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            for (int i = 0; i < quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == quantum - 1)
                {
                    for (int j = 0; j < quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        if (j == quantum - 1)
                        {
                            for (int x = 0; x < quantum; x++)
                            {
                                listBox1.Items.Add(a3[x] + "\n");
                                if (x == quantum - 1)
                                {
                                    for (int y = 0; y < quantum; y++)
                                    {
                                        listBox1.Items.Add(a4[y] + "\n");
                                        counter4++;
                                    }
                                }
                                counter3++;
                            }
                        }
                        counter2++;
                    }
                }
                counter1++;
            }

            int counter11 = counter1;
            int counter22 = counter2;
            int counter33 = counter3;
            int counter44 = counter4;

            for (int i = counter1; i < counter1 + quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == counter1 + 1)
                {
                    for (int j = counter2; j < counter2 + quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        if (j == counter2 + 1)
                        {
                            for (int x = counter3; x < counter3 + quantum; x++)
                            {
                                listBox1.Items.Add(a3[x] + "\n");
                                if (x == counter3 + 1)
                                {
                                    for (int y = counter4; y < counter4 + quantum; y++)
                                    {
                                        listBox1.Items.Add(a4[y] + "\n");
                                        counter44++;
                                    }
                                }
                            }
                            counter33++;
                        }
                        counter22++;
                    }
                }
                counter11++;
            }

            int counter111 = counter11; 
            int counter222 = counter22; 
            int counter333 = counter33;
            int counter444 = counter44;

            for (int i = counter11; i < counter11 + quantum; i++)
            {
                listBox1.Items.Add(a1[i] + "\n");
                if (i == counter11 + 1) 
                {
                    for (int j = counter22; j < counter22 + quantum; j++)
                    {
                        listBox1.Items.Add(a2[j] + "\n");
                        if (j == counter22 + 1)
                        {
                            for (int y = counter44; y < counter44 + 1; y++)
                            {
                                listBox1.Items.Add(a4[y] + "\n");
                                counter444++;
                            }
                        }
                        counter222++;
                    }
                }
                counter111++;
            }

            for (int j = counter222; j < counter222 + quantum; j++)
            {
                listBox1.Items.Add(a2[j] + "\n");
            }
        }


    private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            int num = int.Parse(textBox2.Text);
            int quantum = int.Parse(textBox1.Text);
            for(int z = 0; z < array1.Length;z++)
            {
                textBox3.AppendText(array1[z].ToString());   
            }
            textBox3.AppendText(Environment.NewLine);
            for (int i = 0; i < array2.Length; i++)
            {
                textBox3.AppendText(array2[i].ToString());
                
            }
            textBox3.AppendText(Environment.NewLine);
            for (int i = 0; i < array3.Length; i++)
            {
                textBox3.AppendText(array3[i].ToString());
            }
            textBox3.AppendText(Environment.NewLine);
            for (int i = 0; i < array4.Length; i++)
            {
                textBox3.AppendText(array4[i].ToString());
            }
            
            if (num == 2)
            {
                if(quantum == 1)
                {
                    roundRobinTwoQ1(quantum, array1, array2);
                }
                else if(quantum==2)
                {
                    roundRobinTwo(quantum, array1, array2);
                }
                else if (quantum == 3)
                {
                    roundRobinTwoQ3(quantum, array1, array2);
                }
                else if (quantum == 4)
                {
                    roundRobinTwoQ4(quantum, array1, array2);
                }
                if (listBox1.Items != null)
                {
                    progressBar1.Increment(+100);
                }
            }
            
            if(num == 3)
            {
                roundRobinThree(quantum, array1, array2, array3);
                if (listBox1.Items != null)
                {
                    progressBar1.Increment(+100);
                }
            }
            
            if(num == 4)
            {
                roundRobinFour(quantum, array1, array2, array3, array4);

                if(listBox1.Items != null)
                {
                    progressBar1.Increment(+100);
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
        }
    }
}
