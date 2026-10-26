namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    partial class Form2
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblLineCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtCharCount = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(160, 41);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(175, 23);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read From File\r\n";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(114, 129);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(56, 16);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Tên FIle";
            this.lblFileName.Click += new System.EventHandler(this.lblFileName_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(114, 171);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(92, 16);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Kích thước File";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(114, 219);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(72, 16);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "Đường dẫn";
            this.lblUrl.Click += new System.EventHandler(this.lblUrl_Click);
            // 
            // lblLineCount
            // 
            this.lblLineCount.AutoSize = true;
            this.lblLineCount.Location = new System.Drawing.Point(114, 260);
            this.lblLineCount.Name = "lblLineCount";
            this.lblLineCount.Size = new System.Drawing.Size(61, 16);
            this.lblLineCount.TabIndex = 4;
            this.lblLineCount.Text = "Số dòng ";
            this.lblLineCount.Click += new System.EventHandler(this.lblLineCount_Click);
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(114, 307);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(37, 16);
            this.lblWordCount.TabIndex = 5;
            this.lblWordCount.Text = "Số từ";
            this.lblWordCount.Click += new System.EventHandler(this.lblWordCount_Click);
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(114, 354);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(57, 16);
            this.lblCharCount.TabIndex = 6;
            this.lblCharCount.Text = "Số ký tự ";
            this.lblCharCount.Click += new System.EventHandler(this.lblCharCount_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(250, 122);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 22);
            this.txtFileName.TabIndex = 7;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(250, 171);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 8;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(250, 219);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 22);
            this.txtUrl.TabIndex = 9;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Location = new System.Drawing.Point(250, 260);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.Size = new System.Drawing.Size(100, 22);
            this.txtLineCount.TabIndex = 10;
            // 
            // txtWordCount
            // 
            this.txtWordCount.Location = new System.Drawing.Point(250, 300);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.Size = new System.Drawing.Size(100, 22);
            this.txtWordCount.TabIndex = 11;
            // 
            // txtCharCount
            // 
            this.txtCharCount.Location = new System.Drawing.Point(250, 354);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.Size = new System.Drawing.Size(100, 22);
            this.txtCharCount.TabIndex = 12;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(434, 122);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(322, 254);
            this.rtbContent.TabIndex = 13;
            this.rtbContent.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.txtCharCount);
            this.Controls.Add(this.txtWordCount);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblLineCount);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblLineCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtCharCount;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnExit;
    }
}