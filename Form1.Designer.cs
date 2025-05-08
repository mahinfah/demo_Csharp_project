namespace main_project
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
            this.Submit = new System.Windows.Forms.Button();
            this.LBLPASS = new System.Windows.Forms.Label();
            this.LBLUname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.Teal;
            this.Submit.Location = new System.Drawing.Point(216, 390);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(156, 39);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit\r\n\r\n\r\n";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // LBLPASS
            // 
            this.LBLPASS.AutoSize = true;
            this.LBLPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPASS.Location = new System.Drawing.Point(147, 285);
            this.LBLPASS.Name = "LBLPASS";
            this.LBLPASS.Size = new System.Drawing.Size(111, 20);
            this.LBLPASS.TabIndex = 2;
            this.LBLPASS.Text = "PASSWORD";
            this.LBLPASS.Click += new System.EventHandler(this.LBLPASS_Click);
            // 
            // LBLUname
            // 
            this.LBLUname.AutoSize = true;
            this.LBLUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUname.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLUname.Location = new System.Drawing.Point(147, 203);
            this.LBLUname.Name = "LBLUname";
            this.LBLUname.Size = new System.Drawing.Size(109, 20);
            this.LBLUname.TabIndex = 4;
            this.LBLUname.Text = "USERNAME";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 279);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 26);
            this.textBox2.TabIndex = 6;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.title.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(243, 97);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(94, 43);
            this.title.TabIndex = 7;
            this.title.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 630);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LBLUname);
            this.Controls.Add(this.LBLPASS);
            this.Controls.Add(this.Submit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Form1";
            this.Text = "day1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label LBLPASS;
        private System.Windows.Forms.Label LBLUname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label title;
    }
}

