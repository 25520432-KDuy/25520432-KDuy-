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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        

        private void lblFileName_Click(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void lblUrl_Click(object sender, EventArgs e)
        {

        }

        private void lblLineCount_Click(object sender, EventArgs e)
        {

        }

        private void lblWordCount_Click(object sender, EventArgs e)
        {

        }

        private void lblCharCount_Click(object sender, EventArgs e)
        {

        }


        private void btnReadFile_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Nut da duoc bam");
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileName = ofd.SafeFileName;
                        FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        string url = fs.Name;
                        long size = fs.Length;

                        string[] lines = File.ReadAllLines(ofd.FileName);
                        string content = File.ReadAllText(ofd.FileName);

                        int lineCount = lines.Length;
                        int wordCount = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        int charCount = content.Length;

                    txtFileName.Text = fileName;
                    txtSize.Text = size.ToString() + " bytes";
                    txtUrl.Text = url;
                    txtLineCount.Text = lineCount.ToString();
                    txtWordCount.Text = wordCount.ToString();
                    txtCharCount.Text = charCount.ToString();

                    rtbContent.Text = content;


                    fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                    }
                }
            }

           
               
            
    }
}
