using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    public partial class Form6 : Form
    {
        string connectionString = "Data Source=data.db;Version=3;";

        public Form6()
        {
            InitializeComponent();
        }

        // Hàm Load dữ liệu lên 2 ListView
        private void LoadData()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // Load Món Ăn
                    string sqlMonAn = "SELECT * FROM MonAn";
                    SQLiteDataAdapter daMA = new SQLiteDataAdapter(sqlMonAn, conn);
                    DataTable dtMA = new DataTable();
                    daMA.Fill(dtMA);

                    lvMonAn.Items.Clear();
                    foreach (DataRow row in dtMA.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["IDMA"].ToString());
                        item.SubItems.Add(row["TenMonAn"].ToString());
                        item.SubItems.Add(row["HinhAnh"].ToString());
                        item.SubItems.Add(row["IDNCC"].ToString());
                        lvMonAn.Items.Add(item);
                    }

                    // Load Người Cấp
                    string sqlNguoiDung = "SELECT * FROM NguoiDung";
                    SQLiteDataAdapter daND = new SQLiteDataAdapter(sqlNguoiDung, conn);
                    DataTable dtND = new DataTable();
                    daND.Fill(dtND);

                    lvNguoiDung.Items.Clear();
                    foreach (DataRow row in dtND.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["IDNCC"].ToString());
                        item.SubItems.Add(row["HoVaTen"].ToString());
                        item.SubItems.Add(row["QuyenHan"].ToString());
                        lvNguoiDung.Items.Add(item);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load DB: " + ex.Message); }
        }

        // Nút Tải Dữ Liệu
        private void btnLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã bấm nút Tải dữ liệu!");

            lvMonAn.Items.Clear();
            lvNguoiDung.Items.Clear();

            lvNguoiDung.Items.Add(
                new ListViewItem(new[] { "1", "Nguyen Van A", "Admin" }));

            lvNguoiDung.Items.Add(
                new ListViewItem(new[] { "2", "Tran Van B", "User" }));

            lvMonAn.Items.Add(
                new ListViewItem(new[] { "1", "Pho Bo", "pho.jpg", "1" }));

            lvMonAn.Items.Add(
                new ListViewItem(new[] { "2", "Com Tam", "comtam.jpg", "2" }));

        }

        // Nút "Hôm nay ăn gì?"
        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (lvMonAn.Items.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu món ăn!");
                return;
            }

            Random rnd = new Random();
            int index = rnd.Next(lvMonAn.Items.Count);

            ListViewItem randomMon = lvMonAn.Items[index];

            string tenMon = randomMon.SubItems[1].Text;
            string hinhAnh = randomMon.SubItems[2].Text;
            string idNCC = randomMon.SubItems[3].Text;

            string tenNguoiCap = "Không rõ";

            foreach (ListViewItem item in lvNguoiDung.Items)
            {
                if (item.SubItems[0].Text == idNCC)
                {
                    tenNguoiCap = item.SubItems[1].Text;
                    break;
                }
            }

            txtTenMonAn.Text = tenMon;
            txtNguoiCap.Text = tenNguoiCap;

            try
            {
                if (File.Exists(hinhAnh))
                {
                    picHinhAnh.Image = Image.FromFile(hinhAnh);
                    picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picHinhAnh.Image = null;
                }
            }
            catch
            {
                picHinhAnh.Image = null;
            }
        }

        // Nút thoát (nếu có)
        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }
    }
}