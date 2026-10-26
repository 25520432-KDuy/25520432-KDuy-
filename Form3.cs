using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da bam nut Mo");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.Title = "Chọn file input3.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    rtbInput.Text = File.ReadAllText(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file: " + ex.Message);
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da bam Tinh");
            if (string.IsNullOrWhiteSpace(rtbInput.Text))
            {
                MessageBox.Show("Vui lòng mở file trước khi tính!", "Thông báo");
                return;
            }

            try
            {
                string[] lines = rtbInput.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                string outputContent = "";

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    double result = CalculateExpression(line);
                    outputContent += line + " = " + result + Environment.NewLine;
                }

                
                rtbOutput.Text = outputContent;

                
                File.WriteAllText("output3.txt", outputContent);
                MessageBox.Show("Đã ghi kết quả vào file output3.txt!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private double CalculateExpression(string expression)
        {
            string[] tokens = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double result = double.Parse(tokens[0]);

            for (int i = 1; i < tokens.Length; i += 2)
            {
                string op = tokens[i];
                double num = double.Parse(tokens[i + 1]);

                switch (op)
                {
                    case "+": result += num; break;
                    case "-": result -= num; break;
                    case "*": result *= num; break;
                    case "/": result /= num; break;
                }
            }
            return result;
        }
    }
}
