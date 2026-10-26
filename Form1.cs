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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("output1.txt"))
                {
                    sw.Write(rtbContent.Text.ToUpper());
                }
                MessageBox.Show("Ghi file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input1.txt"))
                {
                    string content = sr.ReadToEnd();
                    rtbContent.Text = content;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }
    }
}
