namespace FormsApp
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.IPAddressTxt = new System.Windows.Forms.TextBox();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SleepTimeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OptionsFileTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // textBox1
            // 
            this.IPAddressTxt.Location = new System.Drawing.Point(120, 12);
            this.IPAddressTxt.Name = "IPAddressTxt";
            this.IPAddressTxt.Size = new System.Drawing.Size(289, 20);
            this.IPAddressTxt.TabIndex = 1;
            // 
            // textBox2
            // 
            this.PortTxt.Location = new System.Drawing.Point(120, 38);
            this.PortTxt.Name = "textBox2";
            this.PortTxt.Size = new System.Drawing.Size(289, 20);
            this.PortTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // textBox3
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(120, 90);
            this.PasswordTxt.Name = "textBox3";
            this.PasswordTxt.Size = new System.Drawing.Size(289, 20);
            this.PasswordTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // textBox4
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(120, 64);
            this.UserNameTxt.Name = "textBox4";
            this.UserNameTxt.Size = new System.Drawing.Size(289, 20);
            this.UserNameTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Name";
            // 
            // textBox5
            // 
            this.SleepTimeTxt.Location = new System.Drawing.Point(120, 116);
            this.SleepTimeTxt.Name = "textBox5";
            this.SleepTimeTxt.Size = new System.Drawing.Size(289, 20);
            this.SleepTimeTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SleepTime";
            // 
            // textBox6
            // 
            this.OptionsFileTxt.Location = new System.Drawing.Point(120, 143);
            this.OptionsFileTxt.Name = "textBox6";
            this.OptionsFileTxt.Size = new System.Drawing.Size(289, 20);
            this.OptionsFileTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Path Options File";
            // 
            // button1
            // 
            this.SaveBtn.Location = new System.Drawing.Point(20, 193);
            this.SaveBtn.Name = "button1";
            this.SaveBtn.Size = new System.Drawing.Size(84, 23);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button2
            // 
            this.CancelBtn.Location = new System.Drawing.Point(120, 193);
            this.CancelBtn.Name = "button2";
            this.CancelBtn.Size = new System.Drawing.Size(80, 23);
            this.CancelBtn.TabIndex = 13;
            this.CancelBtn.Text = "Cancele";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 228);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OptionsFileTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SleepTimeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPAddressTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPAddressTxt;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SleepTimeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OptionsFileTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}