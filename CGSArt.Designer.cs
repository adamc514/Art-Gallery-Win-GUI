namespace Art_Gallery_Win
{
    partial class CGSArt
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.PsWtxt = new System.Windows.Forms.TextBox();
            this.Unametxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.Label();
            this.GreetTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitbtn
            // 
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitbtn.Location = new System.Drawing.Point(16, 92);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 0;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exitbtn.Location = new System.Drawing.Point(127, 92);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 1;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // PsWtxt
            // 
            this.PsWtxt.Location = new System.Drawing.Point(85, 49);
            this.PsWtxt.Name = "PsWtxt";
            this.PsWtxt.Size = new System.Drawing.Size(100, 21);
            this.PsWtxt.TabIndex = 2;
            this.PsWtxt.UseSystemPasswordChar = true;
            this.PsWtxt.TextChanged += new System.EventHandler(this.PsWtxt_TextChanged);
            // 
            // Unametxt
            // 
            this.Unametxt.Location = new System.Drawing.Point(85, 15);
            this.Unametxt.Name = "Unametxt";
            this.Unametxt.Size = new System.Drawing.Size(100, 21);
            this.Unametxt.TabIndex = 3;
            this.Unametxt.TextChanged += new System.EventHandler(this.Unametxt_TextChanged);
            // 
            // UserNametxt
            // 
            this.UserNametxt.AutoSize = true;
            this.UserNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNametxt.Location = new System.Drawing.Point(13, 22);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(67, 15);
            this.UserNametxt.TabIndex = 4;
            this.UserNametxt.Text = "UserName";
            this.UserNametxt.Click += new System.EventHandler(this.UserNametxt_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.AutoSize = true;
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(13, 49);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(61, 15);
            this.Passwordtxt.TabIndex = 5;
            this.Passwordtxt.Text = "Password";
            // 
            // GreetTxt
            // 
            this.GreetTxt.AutoSize = true;
            this.GreetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetTxt.Location = new System.Drawing.Point(77, 33);
            this.GreetTxt.Name = "GreetTxt";
            this.GreetTxt.Size = new System.Drawing.Size(147, 40);
            this.GreetTxt.TabIndex = 7;
            this.GreetTxt.Text = "Welcome To The \r\nCGS Art Gallery";
            this.GreetTxt.Click += new System.EventHandler(this.GreetTxt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PsWtxt);
            this.groupBox1.Controls.Add(this.submitbtn);
            this.groupBox1.Controls.Add(this.Exitbtn);
            this.groupBox1.Controls.Add(this.Passwordtxt);
            this.groupBox1.Controls.Add(this.Unametxt);
            this.groupBox1.Controls.Add(this.UserNametxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please login:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CGSArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 276);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GreetTxt);
            this.Name = "CGSArt";
            this.Text = "CGSArt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.TextBox PsWtxt;
        private System.Windows.Forms.TextBox Unametxt;
        private System.Windows.Forms.Label UserNametxt;
        private System.Windows.Forms.Label Passwordtxt;
        private System.Windows.Forms.Label GreetTxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}