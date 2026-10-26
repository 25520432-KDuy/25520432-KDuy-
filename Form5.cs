using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    public partial class Form5 : Form
    {
      
        class Phim
        {
            public string TenPhim { get; set; }
            public double GiaVe { get; set; }
            public int SoVeBanRa { get; set; }
            public double DoanhThu { get { return GiaVe * SoVeBanRa; } }
        }

        List<Phim> danhSachPhim = new List<Phim>();

        public Form5()
        {
            InitializeComponent();
        }

        
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input5.txt"))
                {
                    MessageBox.Show("Không tìm thấy file input5.txt!");
                    return;
                }

                string[] lines = File.ReadAllLines("input5.txt");
                rtbInput.Text = string.Join("\n", lines); 
                danhSachPhim.Clear();


                for (int i = 0; i < lines.Length; i += 3)
                {
                    if (i + 2 < lines.Length) 
                    {
                        string ten = lines[i].Trim();
                        double gia = double.Parse(lines[i + 1].Trim());
                        int soVe = int.Parse(lines[i + 2].Trim());

                        danhSachPhim.Add(new Phim { TenPhim = ten, GiaVe = gia, SoVeBanRa = soVe });
                    }
                }
                MessageBox.Show("Đọc dữ liệu thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi đọc file: " + ex.Message); }
        }

        
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (danhSachPhim.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu, hãy Đọc file trước!");
                return;
            }

            try
            {
                var danhSachSapXep = danhSachPhim.OrderByDescending(p => p.DoanhThu).ToList();

                string result = "Tên Phim | Vé Bán | Vé Tồn | Tỉ Lệ | Doanh Thu | Xếp Hạng\n";
                result += "------------------------------------------------------------------\n";

                progressBar1.Value = 0;
                progressBar1.Maximum = danhSachSapXep.Count;

                int hang = 1;
                foreach (var phim in danhSachSapXep)
                {
                    
                    int veTon = 0;
                    double tiLe = 100;

                    result += $"{phim.TenPhim} | {phim.SoVeBanRa} | {veTon} | {tiLe}% | {phim.DoanhThu:N0} | {hang}\n";

                    hang++;
                    progressBar1.Value++; 
                    Application.DoEvents(); 
                }

                rtbOutput.Text = result;
                File.WriteAllText("output5.txt", result);
                MessageBox.Show("Đã ghi thống kê ra file output5.txt!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi ghi file: " + ex.Message); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}