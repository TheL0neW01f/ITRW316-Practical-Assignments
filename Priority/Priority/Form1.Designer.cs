namespace Priority
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Processes = new System.Windows.Forms.GroupBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPrio3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPrio2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPrio1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Processes.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter priority for process 3: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Processes
            // 
            this.Processes.Controls.Add(this.progressBar3);
            this.Processes.Controls.Add(this.progressBar2);
            this.Processes.Controls.Add(this.progressBar1);
            this.Processes.Controls.Add(this.label6);
            this.Processes.Controls.Add(this.label9);
            this.Processes.Controls.Add(this.label8);
            this.Processes.Controls.Add(this.label7);
            this.Processes.Controls.Add(this.label5);
            this.Processes.Controls.Add(this.button1);
            this.Processes.Controls.Add(this.label2);
            this.Processes.Controls.Add(this.textBox3);
            this.Processes.Controls.Add(this.txtPrio3);
            this.Processes.Controls.Add(this.textBox2);
            this.Processes.Controls.Add(this.txtPrio2);
            this.Processes.Controls.Add(this.textBox1);
            this.Processes.Controls.Add(this.txtPrio1);
            this.Processes.Location = new System.Drawing.Point(12, 12);
            this.Processes.Name = "Processes";
            this.Processes.Size = new System.Drawing.Size(776, 215);
            this.Processes.TabIndex = 4;
            this.Processes.TabStop = false;
            this.Processes.Text = "Processes";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(438, 178);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(140, 23);
            this.progressBar3.TabIndex = 4;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(439, 115);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(139, 23);
            this.progressBar2.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(442, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(136, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Enter priority of process 2: ";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Enter running time of process 3 (Max 10): ";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Enter running time of process 2 (Max 10): ";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Enter running time of process 1 (Max 10): ";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter priority of process 1: ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 5;
            // 
            // txtPrio3
            // 
            this.txtPrio3.Location = new System.Drawing.Point(4, 181);
            this.txtPrio3.Name = "txtPrio3";
            this.txtPrio3.Size = new System.Drawing.Size(136, 20);
            this.txtPrio3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txtPrio2
            // 
            this.txtPrio2.Location = new System.Drawing.Point(4, 115);
            this.txtPrio2.Name = "txtPrio2";
            this.txtPrio2.Size = new System.Drawing.Size(136, 20);
            this.txtPrio2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtPrio1
            // 
            this.txtPrio1.Location = new System.Drawing.Point(4, 51);
            this.txtPrio1.Name = "txtPrio1";
            this.txtPrio1.Size = new System.Drawing.Size(136, 20);
            this.txtPrio1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.Processes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Processes.ResumeLayout(false);
            this.Processes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Processes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPrio3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPrio2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPrio1;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

