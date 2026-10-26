using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 
using System.Windows.Forms;

namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    public partial class Form4 : Form
    {
        
        List<SinhVien> danhSachSV = new List<SinhVien>();
        int currentPage = 0;

        public Form4()
        {
            InitializeComponent();
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtName.Text.Trim();
                string mssv = txtID.Text.Trim();
                string sdt = txtPhone.Text.Trim();
                float d1 = float.Parse(txtCourse1.Text);
                float d2 = float.Parse(txtCourse2.Text);
                float d3 = float.Parse(txtCourse3.Text);

               
                if (mssv.Length != 8 || !long.TryParse(mssv, out _))
                {
                    MessageBox.Show("MSSV phải là số có đúng 8 chữ số!"); return;
                }
                if (sdt.Length != 10 || !sdt.StartsWith("0"))
                {
                    MessageBox.Show("SĐT phải có 10 số và bắt đầu bằng 0!"); return;
                }
                if (d1 < 0 || d1 > 10 || d2 < 0 || d2 > 10 || d3 < 0 || d3 > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10!"); return;
                }

                
                danhSachSV.Add(new SinhVien(ten, mssv, sdt, d1, d2, d3));
                MessageBox.Show("Thêm thành công!");

                
                txtName.Clear(); txtID.Clear(); txtPhone.Clear();
                txtCourse1.Clear(); txtCourse2.Clear(); txtCourse3.Clear();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho điểm!");
            }
        }


        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Write da chay");

            if (danhSachSV.Count == 0)
            {
                MessageBox.Show("Danh sách trống, không có gì để ghi!");
                return;
            }

            try
            {
                string json = JsonSerializer.Serialize(danhSachSV);

                File.WriteAllText("input4.txt", json);

                rtbDisplay.Clear();

                foreach (SinhVien sv in danhSachSV)
                {
                    rtbDisplay.AppendText(sv.HoTen + Environment.NewLine);
                    rtbDisplay.AppendText(sv.MSSV + Environment.NewLine);
                    rtbDisplay.AppendText(sv.DienThoai + Environment.NewLine);
                    rtbDisplay.AppendText(sv.DiemMon1 + Environment.NewLine);
                    rtbDisplay.AppendText(sv.DiemMon2 + Environment.NewLine);
                    rtbDisplay.AppendText(sv.DiemMon3 + Environment.NewLine);
                    rtbDisplay.AppendText(Environment.NewLine);
                }

                MessageBox.Show("Đã ghi vào file input4.txt thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }


        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input4.txt"))
                {
                    MessageBox.Show("Không tìm thấy file input4.txt!");
                    return;
                }

               
                string json = File.ReadAllText("input4.txt");
                danhSachSV = JsonSerializer.Deserialize<List<SinhVien>>(json);

               
                string outputContent = "";
                foreach (SinhVien sv in danhSachSV)
                {
                    outputContent += $"{sv.HoTen} - {sv.MSSV} - {sv.DienThoai} - ĐTB: {sv.DiemTrungBinh:0.00}\n";
                }
                File.WriteAllText("output4.txt", outputContent);

            
                currentPage = 0;
                HienThiTrang(currentPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }
        }

       
        private void HienThiTrang(int page)
        {
            if (danhSachSV.Count == 0) return;

            SinhVien sv = danhSachSV[page];
            txtRName.Text = sv.HoTen;
            txtRID.Text = sv.MSSV;
            txtRPhone.Text = sv.DienThoai;
            txtRCourse1.Text = sv.DiemMon1.ToString();
            txtRCourse2.Text = sv.DiemMon2.ToString();
            txtRCourse3.Text = sv.DiemMon3.ToString();
            txtRAverage.Text = sv.DiemTrungBinh.ToString("0.00");

            lblPage.Text = (page + 1).ToString() + " / " + danhSachSV.Count.ToString();
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                HienThiTrang(currentPage);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < danhSachSV.Count - 1)
            {
                currentPage++;
                HienThiTrang(currentPage);
            }
        }

        
        private void Form4_Load(object sender, EventArgs e) { }
        private void txtCourse1_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}