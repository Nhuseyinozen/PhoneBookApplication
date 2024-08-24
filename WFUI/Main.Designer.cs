namespace WFUI
{
    partial class Main
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
            this.LstList = new System.Windows.Forms.ListBox();
            this.GroupRecord = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnNewRecord = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Surname = new System.Windows.Forms.TabPage();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtWebsite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPhone3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPhone2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPhone1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtExplanation = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.BtnJsonSent = new System.Windows.Forms.Button();
            this.BtnSentCSV = new System.Windows.Forms.Button();
            this.BtnSentXML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GroupRecord.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Surname.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LstList);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 619);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact List";
            // 
            // LstList
            // 
            this.LstList.FormattingEnabled = true;
            this.LstList.ItemHeight = 16;
            this.LstList.Location = new System.Drawing.Point(12, 25);
            this.LstList.Name = "LstList";
            this.LstList.Size = new System.Drawing.Size(418, 580);
            this.LstList.TabIndex = 0;
            this.LstList.DoubleClick += new System.EventHandler(this.LstList_DoubleClick);
            // 
            // GroupRecord
            // 
            this.GroupRecord.Controls.Add(this.button2);
            this.GroupRecord.Controls.Add(this.BtnUpdate);
            this.GroupRecord.Controls.Add(this.BtnNewRecord);
            this.GroupRecord.Controls.Add(this.tabControl1);
            this.GroupRecord.Location = new System.Drawing.Point(472, 12);
            this.GroupRecord.Name = "GroupRecord";
            this.GroupRecord.Size = new System.Drawing.Size(867, 464);
            this.GroupRecord.TabIndex = 1;
            this.GroupRecord.TabStop = false;
            this.GroupRecord.Text = "New Contact Record";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(459, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(21, 412);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(418, 42);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnNewRecord
            // 
            this.BtnNewRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNewRecord.Location = new System.Drawing.Point(21, 366);
            this.BtnNewRecord.Name = "BtnNewRecord";
            this.BtnNewRecord.Size = new System.Drawing.Size(826, 42);
            this.BtnNewRecord.TabIndex = 1;
            this.BtnNewRecord.Text = "New Record";
            this.BtnNewRecord.UseVisualStyleBackColor = false;
            this.BtnNewRecord.Click += new System.EventHandler(this.BtnNewRecord_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Surname);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // Surname
            // 
            this.Surname.Controls.Add(this.TxtAddress);
            this.Surname.Controls.Add(this.label8);
            this.Surname.Controls.Add(this.TxtEmail);
            this.Surname.Controls.Add(this.label7);
            this.Surname.Controls.Add(this.TxtWebsite);
            this.Surname.Controls.Add(this.label6);
            this.Surname.Controls.Add(this.TxtPhone3);
            this.Surname.Controls.Add(this.label5);
            this.Surname.Controls.Add(this.TxtPhone2);
            this.Surname.Controls.Add(this.label4);
            this.Surname.Controls.Add(this.TxtPhone1);
            this.Surname.Controls.Add(this.label3);
            this.Surname.Controls.Add(this.TxtSurname);
            this.Surname.Controls.Add(this.label2);
            this.Surname.Controls.Add(this.TxtName);
            this.Surname.Controls.Add(this.label1);
            this.Surname.Location = new System.Drawing.Point(4, 25);
            this.Surname.Name = "Surname";
            this.Surname.Padding = new System.Windows.Forms.Padding(3);
            this.Surname.Size = new System.Drawing.Size(832, 310);
            this.Surname.TabIndex = 0;
            this.Surname.Text = "Personal Information";
            this.Surname.UseVisualStyleBackColor = true;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(470, 45);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(330, 241);
            this.TxtAddress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(467, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(149, 264);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(289, 22);
            this.TxtEmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Website";
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Location = new System.Drawing.Point(149, 222);
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Size = new System.Drawing.Size(289, 22);
            this.TxtWebsite.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email Address";
            // 
            // TxtPhone3
            // 
            this.TxtPhone3.Location = new System.Drawing.Point(149, 178);
            this.TxtPhone3.Name = "TxtPhone3";
            this.TxtPhone3.Size = new System.Drawing.Size(289, 22);
            this.TxtPhone3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone III";
            // 
            // TxtPhone2
            // 
            this.TxtPhone2.Location = new System.Drawing.Point(149, 138);
            this.TxtPhone2.Name = "TxtPhone2";
            this.TxtPhone2.Size = new System.Drawing.Size(289, 22);
            this.TxtPhone2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone II";
            // 
            // TxtPhone1
            // 
            this.TxtPhone1.Location = new System.Drawing.Point(149, 100);
            this.TxtPhone1.Name = "TxtPhone1";
            this.TxtPhone1.Size = new System.Drawing.Size(289, 22);
            this.TxtPhone1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone I";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(149, 61);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(289, 22);
            this.TxtSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(149, 24);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(289, 22);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtExplanation);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Explanation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtExplanation
            // 
            this.TxtExplanation.Location = new System.Drawing.Point(6, 6);
            this.TxtExplanation.Multiline = true;
            this.TxtExplanation.Name = "TxtExplanation";
            this.TxtExplanation.Size = new System.Drawing.Size(807, 298);
            this.TxtExplanation.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblStatus);
            this.groupBox3.Controls.Add(this.BtnJsonSent);
            this.groupBox3.Controls.Add(this.BtnSentCSV);
            this.groupBox3.Controls.Add(this.BtnSentXML);
            this.groupBox3.Location = new System.Drawing.Point(476, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(862, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Operations";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblStatus.Location = new System.Drawing.Point(441, 44);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(187, 25);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "Status : No Action";
            // 
            // BtnJsonSent
            // 
            this.BtnJsonSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnJsonSent.Location = new System.Drawing.Point(293, 44);
            this.BtnJsonSent.Name = "BtnJsonSent";
            this.BtnJsonSent.Size = new System.Drawing.Size(114, 81);
            this.BtnJsonSent.TabIndex = 2;
            this.BtnJsonSent.Text = "SENT \"JSON\"";
            this.BtnJsonSent.UseVisualStyleBackColor = true;
            this.BtnJsonSent.Click += new System.EventHandler(this.BtnJsonSent_Click);
            // 
            // BtnSentCSV
            // 
            this.BtnSentCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSentCSV.Location = new System.Drawing.Point(161, 44);
            this.BtnSentCSV.Name = "BtnSentCSV";
            this.BtnSentCSV.Size = new System.Drawing.Size(114, 81);
            this.BtnSentCSV.TabIndex = 1;
            this.BtnSentCSV.Text = "SENT \"CSV\"";
            this.BtnSentCSV.UseVisualStyleBackColor = true;
            this.BtnSentCSV.Click += new System.EventHandler(this.BtnSentCSV_Click);
            // 
            // BtnSentXML
            // 
            this.BtnSentXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSentXML.Location = new System.Drawing.Point(34, 44);
            this.BtnSentXML.Name = "BtnSentXML";
            this.BtnSentXML.Size = new System.Drawing.Size(114, 81);
            this.BtnSentXML.TabIndex = 0;
            this.BtnSentXML.Text = "SENT \"XML\"";
            this.BtnSentXML.UseVisualStyleBackColor = true;
            this.BtnSentXML.Click += new System.EventHandler(this.BtnSentXML_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 643);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupRecord);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.GroupRecord.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Surname.ResumeLayout(false);
            this.Surname.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupRecord;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Surname;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtWebsite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPhone3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPhone2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPhone1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtExplanation;
        private System.Windows.Forms.Button BtnNewRecord;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSentXML;
        private System.Windows.Forms.Button BtnSentCSV;
        private System.Windows.Forms.Button BtnJsonSent;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ListBox LstList;
        private System.Windows.Forms.Button button2;
    }
}