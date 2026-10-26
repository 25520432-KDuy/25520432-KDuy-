namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    partial class Form4
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCourse1 = new System.Windows.Forms.TextBox();
            this.txtCourse3 = new System.Windows.Forms.TextBox();
            this.txtCourse2 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblLID = new System.Windows.Forms.Label();
            this.lblLPhone = new System.Windows.Forms.Label();
            this.lblLCourse1 = new System.Windows.Forms.Label();
            this.lblLCourse2 = new System.Windows.Forms.Label();
            this.lblLCourse3 = new System.Windows.Forms.Label();
            this.lblLAverage = new System.Windows.Forms.Label();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.txtRPhone = new System.Windows.Forms.TextBox();
            this.txtRCourse1 = new System.Windows.Forms.TextBox();
            this.txtRCourse2 = new System.Windows.Forms.TextBox();
            this.txtRCourse3 = new System.Windows.Forms.TextBox();
            this.txtRAverage = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblRName = new System.Windows.Forms.Label();
            this.lblRID = new System.Windows.Forms.Label();
            this.lblRPhone = new System.Windows.Forms.Label();
            this.lblRCourse1 = new System.Windows.Forms.Label();
            this.lblRCourse2 = new System.Windows.Forms.Label();
            this.lblRCourse3 = new System.Windows.Forms.Label();
            this.lblRAverage = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 170);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(129, 22);
            this.txtPhone.TabIndex = 0;
            // 
            // txtCourse1
            // 
            this.txtCourse1.Location = new System.Drawing.Point(12, 223);
            this.txtCourse1.Name = "txtCourse1";
            this.txtCourse1.Size = new System.Drawing.Size(129, 22);
            this.txtCourse1.TabIndex = 1;
            this.txtCourse1.TextChanged += new System.EventHandler(this.txtCourse1_TextChanged);
            // 
            // txtCourse3
            // 
            this.txtCourse3.Location = new System.Drawing.Point(12, 334);
            this.txtCourse3.Name = "txtCourse3";
            this.txtCourse3.Size = new System.Drawing.Size(129, 22);
            this.txtCourse3.TabIndex = 2;
            // 
            // txtCourse2
            // 
            this.txtCourse2.Location = new System.Drawing.Point(12, 272);
            this.txtCourse2.Name = "txtCourse2";
            this.txtCourse2.Size = new System.Drawing.Size(129, 22);
            this.txtCourse2.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 121);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 22);
            this.txtID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(12, 396);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(129, 22);
            this.txtAverage.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(193, 81);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(44, 16);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Name";
            // 
            // lblLID
            // 
            this.lblLID.AutoSize = true;
            this.lblLID.Location = new System.Drawing.Point(217, 124);
            this.lblLID.Name = "lblLID";
            this.lblLID.Size = new System.Drawing.Size(20, 16);
            this.lblLID.TabIndex = 13;
            this.lblLID.Text = "ID";
            this.lblLID.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLPhone
            // 
            this.lblLPhone.AutoSize = true;
            this.lblLPhone.Location = new System.Drawing.Point(191, 176);
            this.lblLPhone.Name = "lblLPhone";
            this.lblLPhone.Size = new System.Drawing.Size(46, 16);
            this.lblLPhone.TabIndex = 15;
            this.lblLPhone.Text = "Phone";
            // 
            // lblLCourse1
            // 
            this.lblLCourse1.AutoSize = true;
            this.lblLCourse1.Location = new System.Drawing.Point(180, 229);
            this.lblLCourse1.Name = "lblLCourse1";
            this.lblLCourse1.Size = new System.Drawing.Size(57, 16);
            this.lblLCourse1.TabIndex = 17;
            this.lblLCourse1.Text = "Course1";
            // 
            // lblLCourse2
            // 
            this.lblLCourse2.AutoSize = true;
            this.lblLCourse2.Location = new System.Drawing.Point(178, 278);
            this.lblLCourse2.Name = "lblLCourse2";
            this.lblLCourse2.Size = new System.Drawing.Size(57, 16);
            this.lblLCourse2.TabIndex = 19;
            this.lblLCourse2.Text = "Course2";
            // 
            // lblLCourse3
            // 
            this.lblLCourse3.AutoSize = true;
            this.lblLCourse3.Location = new System.Drawing.Point(178, 340);
            this.lblLCourse3.Name = "lblLCourse3";
            this.lblLCourse3.Size = new System.Drawing.Size(57, 16);
            this.lblLCourse3.TabIndex = 21;
            this.lblLCourse3.Text = "Course3";
            // 
            // lblLAverage
            // 
            this.lblLAverage.AutoSize = true;
            this.lblLAverage.Location = new System.Drawing.Point(178, 402);
            this.lblLAverage.Name = "lblLAverage";
            this.lblLAverage.Size = new System.Drawing.Size(59, 16);
            this.lblLAverage.TabIndex = 23;
            this.lblLAverage.Text = "Average";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.rtbDisplay.Location = new System.Drawing.Point(256, 26);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(269, 506);
            this.rtbDisplay.TabIndex = 24;
            this.rtbDisplay.Text = "";
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(41, 26);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(124, 23);
            this.btnWriteFile.TabIndex = 25;
            this.btnWriteFile.Text = "Write to a File\r\n\r\n";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(602, 26);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(138, 23);
            this.btnReadFile.TabIndex = 26;
            this.btnReadFile.Text = "Button to read a File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtRName
            // 
            this.txtRName.Location = new System.Drawing.Point(593, 75);
            this.txtRName.Name = "txtRName";
            this.txtRName.ReadOnly = true;
            this.txtRName.Size = new System.Drawing.Size(128, 22);
            this.txtRName.TabIndex = 27;
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(602, 124);
            this.txtRID.Name = "txtRID";
            this.txtRID.ReadOnly = true;
            this.txtRID.Size = new System.Drawing.Size(119, 22);
            this.txtRID.TabIndex = 29;
            // 
            // txtRPhone
            // 
            this.txtRPhone.Location = new System.Drawing.Point(602, 176);
            this.txtRPhone.Name = "txtRPhone";
            this.txtRPhone.ReadOnly = true;
            this.txtRPhone.Size = new System.Drawing.Size(119, 22);
            this.txtRPhone.TabIndex = 31;
            // 
            // txtRCourse1
            // 
            this.txtRCourse1.Location = new System.Drawing.Point(602, 229);
            this.txtRCourse1.Name = "txtRCourse1";
            this.txtRCourse1.ReadOnly = true;
            this.txtRCourse1.Size = new System.Drawing.Size(119, 22);
            this.txtRCourse1.TabIndex = 33;
            // 
            // txtRCourse2
            // 
            this.txtRCourse2.Location = new System.Drawing.Point(602, 278);
            this.txtRCourse2.Name = "txtRCourse2";
            this.txtRCourse2.ReadOnly = true;
            this.txtRCourse2.Size = new System.Drawing.Size(119, 22);
            this.txtRCourse2.TabIndex = 35;
            // 
            // txtRCourse3
            // 
            this.txtRCourse3.Location = new System.Drawing.Point(602, 340);
            this.txtRCourse3.Name = "txtRCourse3";
            this.txtRCourse3.ReadOnly = true;
            this.txtRCourse3.Size = new System.Drawing.Size(119, 22);
            this.txtRCourse3.TabIndex = 37;
            // 
            // txtRAverage
            // 
            this.txtRAverage.Location = new System.Drawing.Point(602, 393);
            this.txtRAverage.Name = "txtRAverage";
            this.txtRAverage.ReadOnly = true;
            this.txtRAverage.Size = new System.Drawing.Size(119, 22);
            this.txtRAverage.TabIndex = 39;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(531, 451);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(705, 451);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 41;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Location = new System.Drawing.Point(736, 79);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(44, 16);
            this.lblRName.TabIndex = 42;
            this.lblRName.Text = "Name";
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Location = new System.Drawing.Point(736, 130);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(20, 16);
            this.lblRID.TabIndex = 44;
            this.lblRID.Text = "ID";
            // 
            // lblRPhone
            // 
            this.lblRPhone.AutoSize = true;
            this.lblRPhone.Location = new System.Drawing.Point(737, 182);
            this.lblRPhone.Name = "lblRPhone";
            this.lblRPhone.Size = new System.Drawing.Size(46, 16);
            this.lblRPhone.TabIndex = 46;
            this.lblRPhone.Text = "Phone";
            // 
            // lblRCourse1
            // 
            this.lblRCourse1.AutoSize = true;
            this.lblRCourse1.Location = new System.Drawing.Point(736, 232);
            this.lblRCourse1.Name = "lblRCourse1";
            this.lblRCourse1.Size = new System.Drawing.Size(57, 16);
            this.lblRCourse1.TabIndex = 48;
            this.lblRCourse1.Text = "Course1";
            // 
            // lblRCourse2
            // 
            this.lblRCourse2.AutoSize = true;
            this.lblRCourse2.Location = new System.Drawing.Point(729, 281);
            this.lblRCourse2.Name = "lblRCourse2";
            this.lblRCourse2.Size = new System.Drawing.Size(57, 16);
            this.lblRCourse2.TabIndex = 50;
            this.lblRCourse2.Text = "Course2";
            // 
            // lblRCourse3
            // 
            this.lblRCourse3.AutoSize = true;
            this.lblRCourse3.Location = new System.Drawing.Point(737, 340);
            this.lblRCourse3.Name = "lblRCourse3";
            this.lblRCourse3.Size = new System.Drawing.Size(57, 16);
            this.lblRCourse3.TabIndex = 52;
            this.lblRCourse3.Text = "Course3";
            // 
            // lblRAverage
            // 
            this.lblRAverage.AutoSize = true;
            this.lblRAverage.Location = new System.Drawing.Point(736, 402);
            this.lblRAverage.Name = "lblRAverage";
            this.lblRAverage.Size = new System.Drawing.Size(59, 16);
            this.lblRAverage.TabIndex = 54;
            this.lblRAverage.Text = "Average";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(660, 468);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(14, 16);
            this.lblPage.TabIndex = 56;
            this.lblPage.Text = "1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblRAverage);
            this.Controls.Add(this.lblRCourse3);
            this.Controls.Add(this.lblRCourse2);
            this.Controls.Add(this.lblRCourse1);
            this.Controls.Add(this.lblRPhone);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.lblRName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRAverage);
            this.Controls.Add(this.txtRCourse3);
            this.Controls.Add(this.txtRCourse2);
            this.Controls.Add(this.txtRCourse1);
            this.Controls.Add(this.txtRPhone);
            this.Controls.Add(this.txtRID);
            this.Controls.Add(this.txtRName);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.lblLAverage);
            this.Controls.Add(this.lblLCourse3);
            this.Controls.Add(this.lblLCourse2);
            this.Controls.Add(this.lblLCourse1);
            this.Controls.Add(this.lblLPhone);
            this.Controls.Add(this.lblLID);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCourse2);
            this.Controls.Add(this.txtCourse3);
            this.Controls.Add(this.txtCourse1);
            this.Controls.Add(this.txtPhone);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCourse1;
        private System.Windows.Forms.TextBox txtCourse3;
        private System.Windows.Forms.TextBox txtCourse2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblLID;
        private System.Windows.Forms.Label lblLPhone;
        private System.Windows.Forms.Label lblLCourse1;
        private System.Windows.Forms.Label lblLCourse2;
        private System.Windows.Forms.Label lblLCourse3;
        private System.Windows.Forms.Label lblLAverage;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.TextBox txtRPhone;
        private System.Windows.Forms.TextBox txtRCourse1;
        private System.Windows.Forms.TextBox txtRCourse2;
        private System.Windows.Forms.TextBox txtRCourse3;
        private System.Windows.Forms.TextBox txtRAverage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblRName;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.Label lblRPhone;
        private System.Windows.Forms.Label lblRCourse1;
        private System.Windows.Forms.Label lblRCourse2;
        private System.Windows.Forms.Label lblRCourse3;
        private System.Windows.Forms.Label lblRAverage;
        private System.Windows.Forms.Label lblPage;
    }
}