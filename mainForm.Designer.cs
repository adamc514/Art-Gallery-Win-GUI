namespace Art_Gallery_Win
{
    partial class mainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Curator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CuratorAddFile = new System.Windows.Forms.Button();
            this.CuratorList = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.curLN = new System.Windows.Forms.TextBox();
            this.curID = new System.Windows.Forms.TextBox();
            this.curFN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.ArtistList = new System.Windows.Forms.ListBox();
            this.artistSaveBtn = new System.Windows.Forms.Button();
            this.cID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._artistID = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.ArtistView = new System.Windows.Forms.Button();
            this.artLN = new System.Windows.Forms.TextBox();
            this.artFN = new System.Windows.Forms.TextBox();
            this.Returnbtn = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.ArtPieceInfo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnDisplay = new System.Windows.Forms.RadioButton();
            this.rbtnStorage = new System.Windows.Forms.RadioButton();
            this.addPiece = new System.Windows.Forms.Button();
            this.pieceSell = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._pieceValue = new System.Windows.Forms.TextBox();
            this.pieceYear = new System.Windows.Forms.TextBox();
            this.pieceTitle = new System.Windows.Forms.TextBox();
            this.pieceID = new System.Windows.Forms.TextBox();
            this.artistID = new System.Windows.Forms.TextBox();
            this.curatorID = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.theMainForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.Curator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Returnbtn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.theMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Curator);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Curator
            // 
            this.Curator.Controls.Add(this.tabPage1);
            this.Curator.Controls.Add(this.tabPage2);
            this.Curator.Controls.Add(this.Returnbtn);
            this.Curator.Location = new System.Drawing.Point(6, 0);
            this.Curator.Name = "Curator";
            this.Curator.SelectedIndex = 0;
            this.Curator.Size = new System.Drawing.Size(367, 366);
            this.Curator.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CuratorAddFile);
            this.tabPage1.Controls.Add(this.CuratorList);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.curLN);
            this.tabPage1.Controls.Add(this.curID);
            this.tabPage1.Controls.Add(this.curFN);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Curators";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // CuratorAddFile
            // 
            this.CuratorAddFile.Location = new System.Drawing.Point(255, 62);
            this.CuratorAddFile.Name = "CuratorAddFile";
            this.CuratorAddFile.Size = new System.Drawing.Size(84, 27);
            this.CuratorAddFile.TabIndex = 11;
            this.CuratorAddFile.Text = "add file";
            this.CuratorAddFile.UseVisualStyleBackColor = true;
            this.CuratorAddFile.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // CuratorList
            // 
            this.CuratorList.FormattingEnabled = true;
            this.CuratorList.Location = new System.Drawing.Point(11, 217);
            this.CuratorList.Name = "CuratorList";
            this.CuratorList.Size = new System.Drawing.Size(328, 108);
            this.CuratorList.TabIndex = 10;
            this.CuratorList.SelectedIndexChanged += new System.EventHandler(this.CuratorList_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "View Curator";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(255, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Save Curator";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add Curator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // curLN
            // 
            this.curLN.Location = new System.Drawing.Point(89, 86);
            this.curLN.Name = "curLN";
            this.curLN.Size = new System.Drawing.Size(127, 20);
            this.curLN.TabIndex = 6;
            // 
            // curID
            // 
            this.curID.Location = new System.Drawing.Point(89, 112);
            this.curID.Name = "curID";
            this.curID.Size = new System.Drawing.Size(127, 20);
            this.curID.TabIndex = 5;
            // 
            // curFN
            // 
            this.curFN.Location = new System.Drawing.Point(89, 60);
            this.curFN.Name = "curFN";
            this.curFN.Size = new System.Drawing.Size(127, 20);
            this.curFN.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Curator Information:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.ArtistList);
            this.tabPage2.Controls.Add(this.artistSaveBtn);
            this.tabPage2.Controls.Add(this.cID);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this._artistID);
            this.tabPage2.Controls.Add(this.Add);
            this.tabPage2.Controls.Add(this.ArtistView);
            this.tabPage2.Controls.Add(this.artLN);
            this.tabPage2.Controls.Add(this.artFN);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(359, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artists";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(273, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "add file";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // ArtistList
            // 
            this.ArtistList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistList.FormattingEnabled = true;
            this.ArtistList.ItemHeight = 15;
            this.ArtistList.Location = new System.Drawing.Point(6, 222);
            this.ArtistList.Name = "ArtistList";
            this.ArtistList.Size = new System.Drawing.Size(329, 109);
            this.ArtistList.TabIndex = 10;
            this.ArtistList.SelectedIndexChanged += new System.EventHandler(this.ArtistList_SelectedIndexChanged);
            // 
            // artistSaveBtn
            // 
            this.artistSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistSaveBtn.Location = new System.Drawing.Point(273, 140);
            this.artistSaveBtn.Name = "artistSaveBtn";
            this.artistSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.artistSaveBtn.TabIndex = 9;
            this.artistSaveBtn.Text = "Save Artist";
            this.artistSaveBtn.UseVisualStyleBackColor = true;
            this.artistSaveBtn.Click += new System.EventHandler(this.artistSaveBtn_Click);
            // 
            // cID
            // 
            this.cID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cID.Location = new System.Drawing.Point(94, 140);
            this.cID.Name = "cID";
            this.cID.Size = new System.Drawing.Size(140, 22);
            this.cID.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "Curator ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Artist Information:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // _artistID
            // 
            this._artistID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._artistID.Location = new System.Drawing.Point(94, 111);
            this._artistID.Name = "_artistID";
            this._artistID.Size = new System.Drawing.Size(140, 22);
            this._artistID.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(273, 114);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add Artist";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArtistView
            // 
            this.ArtistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistView.Location = new System.Drawing.Point(273, 168);
            this.ArtistView.Name = "ArtistView";
            this.ArtistView.Size = new System.Drawing.Size(75, 23);
            this.ArtistView.TabIndex = 2;
            this.ArtistView.Text = "View Artist";
            this.ArtistView.UseVisualStyleBackColor = true;
            this.ArtistView.Click += new System.EventHandler(this.button2_Click);
            // 
            // artLN
            // 
            this.artLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artLN.Location = new System.Drawing.Point(94, 83);
            this.artLN.Name = "artLN";
            this.artLN.Size = new System.Drawing.Size(140, 22);
            this.artLN.TabIndex = 1;
            // 
            // artFN
            // 
            this.artFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artFN.Location = new System.Drawing.Point(94, 55);
            this.artFN.Name = "artFN";
            this.artFN.Size = new System.Drawing.Size(140, 22);
            this.artFN.TabIndex = 0;
            this.artFN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Returnbtn
            // 
            this.Returnbtn.BackColor = System.Drawing.Color.White;
            this.Returnbtn.Controls.Add(this.button6);
            this.Returnbtn.Controls.Add(this.ArtPieceInfo);
            this.Returnbtn.Controls.Add(this.button1);
            this.Returnbtn.Controls.Add(this.groupBox2);
            this.Returnbtn.Controls.Add(this.addPiece);
            this.Returnbtn.Controls.Add(this.pieceSell);
            this.Returnbtn.Controls.Add(this.button8);
            this.Returnbtn.Controls.Add(this.label15);
            this.Returnbtn.Controls.Add(this.label14);
            this.Returnbtn.Controls.Add(this.label13);
            this.Returnbtn.Controls.Add(this.label12);
            this.Returnbtn.Controls.Add(this.label11);
            this.Returnbtn.Controls.Add(this.label10);
            this.Returnbtn.Controls.Add(this.label9);
            this.Returnbtn.Controls.Add(this._pieceValue);
            this.Returnbtn.Controls.Add(this.pieceYear);
            this.Returnbtn.Controls.Add(this.pieceTitle);
            this.Returnbtn.Controls.Add(this.pieceID);
            this.Returnbtn.Controls.Add(this.artistID);
            this.Returnbtn.Controls.Add(this.curatorID);
            this.Returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbtn.Location = new System.Drawing.Point(4, 22);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Padding = new System.Windows.Forms.Padding(3);
            this.Returnbtn.Size = new System.Drawing.Size(359, 340);
            this.Returnbtn.TabIndex = 2;
            this.Returnbtn.Text = "ArtPieces";
            this.Returnbtn.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(273, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "add file";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // ArtPieceInfo
            // 
            this.ArtPieceInfo.FormattingEnabled = true;
            this.ArtPieceInfo.ItemHeight = 15;
            this.ArtPieceInfo.Location = new System.Drawing.Point(9, 237);
            this.ArtPieceInfo.Name = "ArtPieceInfo";
            this.ArtPieceInfo.Size = new System.Drawing.Size(339, 94);
            this.ArtPieceInfo.TabIndex = 15;
            this.ArtPieceInfo.SelectedIndexChanged += new System.EventHandler(this.ArtPieceInfo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnDisplay);
            this.groupBox2.Controls.Add(this.rbtnStorage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(234, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 72);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbtnDisplay
            // 
            this.rbtnDisplay.AutoSize = true;
            this.rbtnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDisplay.Location = new System.Drawing.Point(6, 23);
            this.rbtnDisplay.Name = "rbtnDisplay";
            this.rbtnDisplay.Size = new System.Drawing.Size(85, 17);
            this.rbtnDisplay.TabIndex = 5;
            this.rbtnDisplay.TabStop = true;
            this.rbtnDisplay.Text = "On Display";
            this.rbtnDisplay.UseVisualStyleBackColor = true;
            this.rbtnDisplay.CheckedChanged += new System.EventHandler(this.rbtnDisplay_CheckedChanged);
            // 
            // rbtnStorage
            // 
            this.rbtnStorage.AutoSize = true;
            this.rbtnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStorage.Location = new System.Drawing.Point(6, 49);
            this.rbtnStorage.Name = "rbtnStorage";
            this.rbtnStorage.Size = new System.Drawing.Size(83, 17);
            this.rbtnStorage.TabIndex = 6;
            this.rbtnStorage.TabStop = true;
            this.rbtnStorage.Text = "In Storage";
            this.rbtnStorage.UseVisualStyleBackColor = true;
            // 
            // addPiece
            // 
            this.addPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPiece.Location = new System.Drawing.Point(273, 146);
            this.addPiece.Name = "addPiece";
            this.addPiece.Size = new System.Drawing.Size(75, 23);
            this.addPiece.TabIndex = 5;
            this.addPiece.Text = "Add ArtPiece";
            this.addPiece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPiece.UseVisualStyleBackColor = true;
            this.addPiece.Click += new System.EventHandler(this.button6_Click);
            // 
            // pieceSell
            // 
            this.pieceSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceSell.Location = new System.Drawing.Point(273, 175);
            this.pieceSell.Name = "pieceSell";
            this.pieceSell.Size = new System.Drawing.Size(75, 23);
            this.pieceSell.TabIndex = 6;
            this.pieceSell.Text = "Sell ArtPiece";
            this.pieceSell.UseVisualStyleBackColor = true;
            this.pieceSell.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(273, 207);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "View";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "ArtPiece Information:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Artist ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Year:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Title:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Piece ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Curator ID:";
            // 
            // _pieceValue
            // 
            this._pieceValue.Location = new System.Drawing.Point(90, 137);
            this._pieceValue.Name = "_pieceValue";
            this._pieceValue.Size = new System.Drawing.Size(118, 21);
            this._pieceValue.TabIndex = 7;
            // 
            // pieceYear
            // 
            this.pieceYear.Location = new System.Drawing.Point(90, 102);
            this.pieceYear.Name = "pieceYear";
            this.pieceYear.Size = new System.Drawing.Size(118, 21);
            this.pieceYear.TabIndex = 6;
            // 
            // pieceTitle
            // 
            this.pieceTitle.Location = new System.Drawing.Point(90, 73);
            this.pieceTitle.Name = "pieceTitle";
            this.pieceTitle.Size = new System.Drawing.Size(118, 21);
            this.pieceTitle.TabIndex = 5;
            // 
            // pieceID
            // 
            this.pieceID.Location = new System.Drawing.Point(90, 41);
            this.pieceID.Name = "pieceID";
            this.pieceID.Size = new System.Drawing.Size(118, 21);
            this.pieceID.TabIndex = 4;
            this.pieceID.TextChanged += new System.EventHandler(this.pieceID_TextChanged);
            // 
            // artistID
            // 
            this.artistID.Location = new System.Drawing.Point(90, 169);
            this.artistID.Name = "artistID";
            this.artistID.Size = new System.Drawing.Size(118, 21);
            this.artistID.TabIndex = 3;
            // 
            // curatorID
            // 
            this.curatorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curatorID.Location = new System.Drawing.Point(90, 201);
            this.curatorID.Name = "curatorID";
            this.curatorID.Size = new System.Drawing.Size(118, 21);
            this.curatorID.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // theMainForm
            // 
            this.theMainForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.theMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.theMainForm.Location = new System.Drawing.Point(0, 0);
            this.theMainForm.Name = "theMainForm";
            this.theMainForm.Size = new System.Drawing.Size(472, 24);
            this.theMainForm.TabIndex = 1;
            this.theMainForm.Text = "menuStrip1";
            this.theMainForm.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.theMainForm_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.theMainForm);
            this.MainMenuStrip = this.theMainForm;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.curatorFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.Curator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Returnbtn.ResumeLayout(false);
            this.Returnbtn.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.theMainForm.ResumeLayout(false);
            this.theMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl Curator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Returnbtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip theMainForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox _artistID;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ArtistView;
        private System.Windows.Forms.TextBox artLN;
        private System.Windows.Forms.TextBox artFN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox curLN;
        private System.Windows.Forms.TextBox curID;
        private System.Windows.Forms.TextBox curFN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addPiece;
        private System.Windows.Forms.Button pieceSell;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _pieceValue;
        private System.Windows.Forms.TextBox pieceYear;
        private System.Windows.Forms.TextBox pieceTitle;
        private System.Windows.Forms.TextBox pieceID;
        private System.Windows.Forms.TextBox artistID;
        private System.Windows.Forms.TextBox curatorID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnDisplay;
        private System.Windows.Forms.RadioButton rbtnStorage;
        private System.Windows.Forms.TextBox cID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button artistSaveBtn;
        private System.Windows.Forms.ListBox CuratorList;
        private System.Windows.Forms.ListBox ArtistList;
        private System.Windows.Forms.ListBox ArtPieceInfo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button CuratorAddFile;
        private System.Windows.Forms.Button button9;
    }
}