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

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private double TinhBieuThuc(string bieuThuc)
        {

            bieuThuc = bieuThuc.Replace(" ", "");

            while (bieuThuc.Contains("("))
            {
                int viTriDongNgoac = bieuThuc.IndexOf(')');
                int viTriMoNgoac = bieuThuc.LastIndexOf('(', viTriDongNgoac);

                string bieuThucTrongNgoac = bieuThuc.Substring(viTriMoNgoac + 1, viTriDongNgoac - viTriMoNgoac - 1);
                double ketQuaTrongNgoac = TinhBieuThucKhongNgoac(bieuThucTrongNgoac);

                bieuThuc = bieuThuc.Substring(0, viTriMoNgoac) + ketQuaTrongNgoac + bieuThuc.Substring(viTriDongNgoac + 1);
            }

            return TinhBieuThucKhongNgoac(bieuThuc);
        }

        private double TinhBieuThucKhongNgoac(string bieuThuc)
        {
            List<double> danhSachSo = new List<double>();
            List<char> danhSachToanTu = new List<char>();
            string soHienTai = "";

            for (int i = 0; i < bieuThuc.Length; i++)
            {
                char kyTu = bieuThuc[i];

                if (char.IsDigit(kyTu) || kyTu == '.')
                {
                    soHienTai += kyTu;
                }
                else if (kyTu == '+' || kyTu == '-' || kyTu == '*' || kyTu == '/')
                {
                    if ((kyTu == '+' || kyTu == '-') &&
                        (i == 0 || bieuThuc[i - 1] == '+' || bieuThuc[i - 1] == '-' ||
                         bieuThuc[i - 1] == '*' || bieuThuc[i - 1] == '/'))
                    {
                        soHienTai += kyTu;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(soHienTai))
                        {
                            danhSachSo.Add(double.Parse(soHienTai));
                            soHienTai = "";
                        }
                        danhSachToanTu.Add(kyTu);
                    }
                }
            }

            if (!string.IsNullOrEmpty(soHienTai))
            {
                danhSachSo.Add(double.Parse(soHienTai));
            }

            for (int i = 0; i < danhSachToanTu.Count; i++)
            {
                if (danhSachToanTu[i] == '*' || danhSachToanTu[i] == '/')
                {
                    double ketQuaTam;
                    if (danhSachToanTu[i] == '*')
                        ketQuaTam = danhSachSo[i] * danhSachSo[i + 1];
                    else
                    {
                        if (danhSachSo[i + 1] == 0)
                            throw new DivideByZeroException("Không thể chia cho 0");
                        ketQuaTam = danhSachSo[i] / danhSachSo[i + 1];
                    }

                    danhSachSo[i] = ketQuaTam;
                    danhSachSo.RemoveAt(i + 1);
                    danhSachToanTu.RemoveAt(i);
                    i--;
                }
            }

            double ketQua = danhSachSo[0];
            for (int i = 0; i < danhSachToanTu.Count; i++)
            {
                if (danhSachToanTu[i] == '+')
                {
                    ketQua += danhSachSo[i + 1];
                }
                else if (danhSachToanTu[i] == '-')
                {
                    ketQua -= danhSachSo[i + 1];
                }
            }

            return ketQua;
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.Title = "Chọn file input";
            openFile.InitialDirectory = Application.StartupPath;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] cacDong = File.ReadAllLines(openFile.FileName);

                    txtInputFile.Clear();
                    txtInputFile.Text = string.Join(Environment.NewLine, cacDong);

                    List<string> ketQuaList = new List<string>();
                    StringBuilder ketQuaHienThi = new StringBuilder();

                    foreach (string dong in cacDong)
                    {
                        string dongTrim = dong.Trim();
                        if (!string.IsNullOrEmpty(dongTrim))
                        {
                            try
                            {

                                double ketQua = TinhBieuThuc(dongTrim);

                                string ketQuaStr;
                                if (ketQua == (int)ketQua)
                                {

                                    ketQuaStr = $"{dongTrim} = {(int)ketQua}";
                                }
                                else
                                {
                                    ketQuaStr = $"{dongTrim} = {ketQua}";
                                }

                                ketQuaList.Add(ketQuaStr);
                                ketQuaHienThi.AppendLine(ketQuaStr);
                            }
                            catch (Exception ex)
                            {
                                ketQuaHienThi.AppendLine($"Lỗi: {dongTrim} - {ex.Message}");
                            }
                        }
                    }

                    txtOutputFile.Clear();
                    txtOutputFile.Text = ketQuaHienThi.ToString();

                    string duongDanOutput = Path.Combine(
                        Path.GetDirectoryName(openFile.FileName),
                        "output3.txt"
                    );

                    File.WriteAllLines(duongDanOutput, ketQuaList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}