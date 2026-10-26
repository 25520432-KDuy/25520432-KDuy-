using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Ẩn cả 2 khung hiển thị ban đầu
            pictureBox1.Visible = false;
            richTextBox1.Visible = false;

            // Lấy tất cả ổ đĩa (C:\, D:\...)
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady) // Chỉ lấy những ổ đĩa đang kết nối
                {
                    TreeNode node = new TreeNode(d.Name);
                    node.Tag = d.Name; // Lưu đường dẫn vào Tag
                    treeView1.Nodes.Add(node);
                    node.Nodes.Add("..."); // Tạo một node giả để hiện nút mở rộng (+)
                }
            }
        }

        // 2. Sự kiện khi click vào một node trên cây
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            // Xóa các node con cũ
            e.Node.Nodes.Clear();

            try
            {
                // Lấy tất cả thư mục con
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dir));
                    node.Tag = dir; // Lưu đường dẫn thư mục
                    node.Nodes.Add("..."); // Node giả để mở rộng
                    e.Node.Nodes.Add(node);
                }

                // Lấy tất cả file
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    node.Tag = file; // Lưu đường dẫn file
                    node.ImageIndex = 1; // (Tùy chọn) Icon cho file nếu có ImageList
                    e.Node.Nodes.Add(node);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Bỏ qua lỗi không có quyền truy cập (ví dụ: ổ C:\System Volume Information)
            }
        }

        // 3. Sự kiện khi Double-click vào một node (để mở file/thư mục)
        // (Bạn cần gán sự kiện NodeMouseDoubleClick cho treeView1 trong Properties)
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            // Nếu là File thì hiển thị nội dung
            if (File.Exists(path))
            {
                string extension = Path.GetExtension(path).ToLower();

                // Nếu là file ảnh
                if (extension == ".jpg" || extension == ".png" || extension == ".bmp" || extension == ".jpeg")
                {
                    richTextBox1.Visible = false;
                    pictureBox1.Visible = true;
                    try
                    {
                        pictureBox1.Image = Image.FromFile(path);
                    }
                    catch { MessageBox.Show("Không thể mở file ảnh này!"); }
                }
                // Nếu là file văn bản
                else if (extension == ".txt" || extension == ".cs" || extension == ".log")
                {
                    pictureBox1.Visible = false;
                    richTextBox1.Visible = true;
                    try
                    {
                        richTextBox1.Text = File.ReadAllText(path);
                    }
                    catch { MessageBox.Show("Không thể đọc file này!"); }
                }
                else
                {
                    // Các file khác (pdf, exe...) thì thông báo
                    pictureBox1.Visible = false;
                    richTextBox1.Visible = false;
                    MessageBox.Show("Định dạng file này chưa được hỗ trợ xem trước!");
                }
            }
        }

    }
}
