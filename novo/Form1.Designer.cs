namespace AlgoZaSort
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
            System.Windows.Forms.Button butBS;
            this.panel1 = new System.Windows.Forms.Panel();
            this.butReset = new System.Windows.Forms.Button();
            this.ButQS = new System.Windows.Forms.Button();
            this.butSS = new System.Windows.Forms.Button();
            this.butIS = new System.Windows.Forms.Button();
            this.butSelecS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            butBS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butBS
            // 
            butBS.Location = new System.Drawing.Point(12, 12);
            butBS.Name = "butBS";
            butBS.Size = new System.Drawing.Size(75, 47);
            butBS.TabIndex = 2;
            butBS.Text = "Bubble Sort";
            butBS.UseVisualStyleBackColor = true;
            butBS.Click += new System.EventHandler(this.butStart_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 417);
            this.panel1.TabIndex = 0;
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(573, 12);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(126, 47);
            this.butReset.TabIndex = 1;
            this.butReset.Text = "reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // ButQS
            // 
            this.ButQS.Location = new System.Drawing.Point(336, 12);
            this.ButQS.Name = "ButQS";
            this.ButQS.Size = new System.Drawing.Size(72, 47);
            this.ButQS.TabIndex = 3;
            this.ButQS.Text = "Quick Sort";
            this.ButQS.UseVisualStyleBackColor = true;
            this.ButQS.Click += new System.EventHandler(this.ButQS_Click);
            // 
            // butSS
            // 
            this.butSS.Location = new System.Drawing.Point(174, 12);
            this.butSS.Name = "butSS";
            this.butSS.Size = new System.Drawing.Size(75, 47);
            this.butSS.TabIndex = 4;
            this.butSS.Text = "Shell Sort";
            this.butSS.UseVisualStyleBackColor = true;
            this.butSS.Click += new System.EventHandler(this.butSS_Click);
            // 
            // butIS
            // 
            this.butIS.Location = new System.Drawing.Point(93, 12);
            this.butIS.Name = "butIS";
            this.butIS.Size = new System.Drawing.Size(75, 47);
            this.butIS.TabIndex = 5;
            this.butIS.Text = "Insertion Sort";
            this.butIS.UseVisualStyleBackColor = true;
            this.butIS.Click += new System.EventHandler(this.butIS_Click);
            // 
            // butSelecS
            // 
            this.butSelecS.Location = new System.Drawing.Point(414, 12);
            this.butSelecS.Name = "butSelecS";
            this.butSelecS.Size = new System.Drawing.Size(72, 47);
            this.butSelecS.TabIndex = 6;
            this.butSelecS.Text = "Selection sort";
            this.butSelecS.UseVisualStyleBackColor = true;
            this.butSelecS.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "n : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Radix Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "Counting Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butSelecS);
            this.Controls.Add(this.butSS);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButQS);
            this.Controls.Add(this.butIS);
            this.Controls.Add(butBS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button ButQS;
        private System.Windows.Forms.Button butSS;
        private System.Windows.Forms.Button butIS;
        private System.Windows.Forms.Button butSelecS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

