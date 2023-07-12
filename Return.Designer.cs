namespace Art_Gallery_Win
{
    partial class Return
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.returnPieceID_pre = new System.Windows.Forms.TextBox();
            this.returnPieceID_post = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pieceValueTxtBx = new System.Windows.Forms.TextBox();
            this.newPieceValueTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the ID of the item\r\n you wish to return:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Piece ID:";
            // 
            // returnPieceID_pre
            // 
            this.returnPieceID_pre.Location = new System.Drawing.Point(144, 89);
            this.returnPieceID_pre.Name = "returnPieceID_pre";
            this.returnPieceID_pre.Size = new System.Drawing.Size(100, 20);
            this.returnPieceID_pre.TabIndex = 4;
            // 
            // returnPieceID_post
            // 
            this.returnPieceID_post.Location = new System.Drawing.Point(144, 168);
            this.returnPieceID_post.Name = "returnPieceID_post";
            this.returnPieceID_post.Size = new System.Drawing.Size(100, 20);
            this.returnPieceID_post.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter New Piece ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Value:";
            // 
            // pieceValueTxtBx
            // 
            this.pieceValueTxtBx.Location = new System.Drawing.Point(144, 121);
            this.pieceValueTxtBx.Name = "pieceValueTxtBx";
            this.pieceValueTxtBx.Size = new System.Drawing.Size(100, 20);
            this.pieceValueTxtBx.TabIndex = 9;
            // 
            // newPieceValueTxtBx
            // 
            this.newPieceValueTxtBx.Location = new System.Drawing.Point(144, 207);
            this.newPieceValueTxtBx.Name = "newPieceValueTxtBx";
            this.newPieceValueTxtBx.Size = new System.Drawing.Size(100, 20);
            this.newPieceValueTxtBx.TabIndex = 10;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 336);
            this.Controls.Add(this.newPieceValueTxtBx);
            this.Controls.Add(this.pieceValueTxtBx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnPieceID_post);
            this.Controls.Add(this.returnPieceID_pre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Return";
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox returnPieceID_pre;
        private System.Windows.Forms.TextBox returnPieceID_post;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pieceValueTxtBx;
        private System.Windows.Forms.TextBox newPieceValueTxtBx;
    }
}