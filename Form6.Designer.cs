namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    partial class Form6
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
            this.lvNguoiDung = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lvMonAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.lblNguoiCap = new System.Windows.Forms.Label();
            this.txtNguoiCap = new System.Windows.Forms.TextBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lvNguoiDung
            // 
            this.lvNguoiDung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvNguoiDung.FullRowSelect = true;
            this.lvNguoiDung.GridLines = true;
            this.lvNguoiDung.HideSelection = false;
            this.lvNguoiDung.Location = new System.Drawing.Point(515, 147);
            this.lvNguoiDung.Name = "lvNguoiDung";
            this.lvNguoiDung.Size = new System.Drawing.Size(326, 97);
            this.lvNguoiDung.TabIndex = 2;
            this.lvNguoiDung.UseCompatibleStateImageBehavior = false;
            this.lvNguoiDung.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID NCC";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "HoVaTen";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "QuyenHan";
            this.columnHeader7.Width = 100;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Location = new System.Drawing.Point(96, 51);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(100, 50);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 3;
            this.picHinhAnh.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoad.Location = new System.Drawing.Point(223, 351);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(131, 47);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Tải dữ liệu từ DB";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.Form6_Load);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.LightGreen;
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRandom.Location = new System.Drawing.Point(515, 350);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(142, 48);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Hôm nay ăn gì? ";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lvMonAn
            // 
            this.lvMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMonAn.FullRowSelect = true;
            this.lvMonAn.GridLines = true;
            this.lvMonAn.HideSelection = false;
            this.lvMonAn.Location = new System.Drawing.Point(25, 147);
            this.lvMonAn.Name = "lvMonAn";
            this.lvMonAn.Size = new System.Drawing.Size(422, 97);
            this.lvMonAn.TabIndex = 9;
            this.lvMonAn.UseCompatibleStateImageBehavior = false;
            this.lvMonAn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IDMA";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TenMonAn";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HinhAnh";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IDNCC";
            this.columnHeader4.Width = 80;
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.AutoSize = true;
            this.lblTenMonAn.Location = new System.Drawing.Point(61, 317);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(78, 16);
            this.lblTenMonAn.TabIndex = 10;
            this.lblTenMonAn.Text = "Tên món ăn";
            // 
            // lblNguoiCap
            // 
            this.lblNguoiCap.AutoSize = true;
            this.lblNguoiCap.Location = new System.Drawing.Point(477, 317);
            this.lblNguoiCap.Name = "lblNguoiCap";
            this.lblNguoiCap.Size = new System.Drawing.Size(101, 16);
            this.lblNguoiCap.TabIndex = 11;
            this.lblNguoiCap.Text = "Người cung cấp";
            // 
            // txtNguoiCap
            // 
            this.txtNguoiCap.Location = new System.Drawing.Point(584, 314);
            this.txtNguoiCap.Name = "txtNguoiCap";
            this.txtNguoiCap.Size = new System.Drawing.Size(227, 22);
            this.txtNguoiCap.TabIndex = 12;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(145, 314);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(197, 22);
            this.txtTenMonAn.TabIndex = 14;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.txtNguoiCap);
            this.Controls.Add(this.lblNguoiCap);
            this.Controls.Add(this.lblTenMonAn);
            this.Controls.Add(this.lvMonAn);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.lvNguoiDung);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvNguoiDung;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListView lvMonAn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label lblNguoiCap;
        private System.Windows.Forms.TextBox txtNguoiCap;
        private System.Windows.Forms.TextBox txtTenMonAn;
    }
}