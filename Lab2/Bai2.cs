using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

                    FileInfo fileInfo = new FileInfo(filePath);
                    string content;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        content = reader.ReadToEnd();
                    }

                    int soDong = DemSoDong(content);
                    int soTu = DemSoTu(content);
                    int soKyTu = content.Length;

                    txtFileName.Text = openFileDialog.SafeFileName;
                    txtSize.Text = content.Length + " bytes";
                    txtURL.Text = openFileDialog.FileName;
                    txtLineCount.Text = $"{soDong}";
                    txtWordCount.Text = $"{soTu}";
                    txtCharacterCount.Text = $"{soKyTu}";
                    richTextBox1.Text = content;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int DemSoDong(string content)
        {
            if (string.IsNullOrEmpty(content))
                return 0;
            string[] lines = content.Split('\n');
            return lines.Length;
        }

        private int DemSoTu(string content)
        {
            if (string.IsNullOrEmpty(content))
                return 0;
            char[] separators = new char[] { '\n', ' ', '\t', '\r' };
            string[] lines = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return lines.Length;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
