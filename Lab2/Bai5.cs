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
using System.Threading;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        // Cấu trúc dữ liệu Phim
        public class Phim
        {
            public string MaPhim { get; set; }
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public List<string> DanhSachPhong { get; set; } = new List<string>();

            // Thống kê
            public int SoVeBanRa { get; set; } = 0;
            public int DoanhThu { get; set; } = 0;
        }

        // Cấu trúc dữ liệu Phòng chiếu
        public class PhongChieu
        {
            public string MaPhong { get; set; }
            public string TenPhong { get; set; }
            public string MaPhim { get; set; }
            public string GioChieu { get; set; }
        }

        // Cấu trúc Vé
        public class Ve
        {
            public string MaGhe { get; set; }
            public string LoaiGhe { get; set; }
            public int Gia { get; set; }
            public string MaPhong { get; set; }
            public string MaPhim { get; set; }
        }

        // Dictionary quản lý dữ liệu
        private Dictionary<string, Phim> danhSachPhim;
        private Dictionary<string, PhongChieu> danhSachPhongChieu;

        // Giá vé theo loại
        private Dictionary<string, decimal> tyLeGia;

        // Phân loại ghế theo vị trí
        private Dictionary<string, string> phanLoaiGhe;

        // Màu sắc theo loại ghế
        private Dictionary<string, Color> mauGhe;

        private Dictionary<string, Button> danhSachGhe;
        private Dictionary<string, Ve> gheDaBan;
        private List<Ve> veDangChon;

        private string hoTenKhachHang = "";
        private string phimDaChon = "";
        private string phongDaChon = "";

        private char[] danhSachHang = { 'A', 'B', 'C' };
        private int soCot = 5;
        private int tongSoGheMoiPhong = 15; // 3x5

        private Color mauGheDaChon = Color.Orange;
        private Color mauGheDaBan = Color.Red;

        private const string FILE_INPUT = "input5.txt";
        private const string FILE_OUTPUT = "output5.txt";

        public Bai5()
        {
            InitializeComponent();

            // Khởi tạo Dictionary
            danhSachPhim = new Dictionary<string, Phim>();
            danhSachPhongChieu = new Dictionary<string, PhongChieu>();
            danhSachGhe = new Dictionary<string, Button>();
            gheDaBan = new Dictionary<string, Ve>();
            veDangChon = new List<Ve>();

            tyLeGia = new Dictionary<string, decimal>
            {
                { "Vớt", 0.25m },
                { "Thường", 1.0m },
                { "VIP", 2.0m }
            };

            phanLoaiGhe = new Dictionary<string, string>
            {
                { "A1", "Vớt" }, { "A5", "Vớt" },
                { "C1", "Vớt" }, { "C5", "Vớt" },
                { "A2", "Thường" }, { "A3", "Thường" }, { "A4", "Thường" },
                { "B1", "Thường" }, { "B5", "Thường" },
                { "C2", "Thường" }, { "C3", "Thường" }, { "C4", "Thường" },
                { "B2", "VIP" }, { "B3", "VIP" }, { "B4", "VIP" }
            };

            mauGhe = new Dictionary<string, Color>
            {
                { "Vớt", Color.LightGray },
                { "Thường", Color.LightBlue },
                { "VIP", Color.Gold }
            };

            DocDuLieuTuFile();
            LoadDanhSachPhim();
            HienThiBangGia();
            VoHieuHoaChonGhe();
        }

        // Đọc dữ liệu từ file input5.txt
        private void DocDuLieuTuFile()
        {
            try
            {
                if (!File.Exists(FILE_INPUT))
                {
                    // Tạo file mẫu nếu chưa có
                    TaoFileMau();
                }

                string[] lines = File.ReadAllLines(FILE_INPUT, Encoding.UTF8);
                int index = 0;
                int maPhimCounter = 1;

                while (index < lines.Length)
                {
                    if (string.IsNullOrWhiteSpace(lines[index]))
                    {
                        index++;
                        continue;
                    }

                    string tenPhim = lines[index].Trim();
                    index++;

                    if (index >= lines.Length) break;
                    int giaVeChuan = int.Parse(lines[index].Trim());
                    index++;

                    List<string> danhSachPhongChieu = new List<string>();
                    while (index < lines.Length && !string.IsNullOrWhiteSpace(lines[index]))
                    {
                        string phongStr = lines[index].Trim();
                        danhSachPhongChieu.Add(phongStr);
                        index++;
                    }

                    // Tạo mã phim
                    string maPhim = $"P{maPhimCounter:000}";
                    maPhimCounter++;

                    // Thêm phim
                    Phim phim = new Phim
                    {
                        MaPhim = maPhim,
                        TenPhim = tenPhim,
                        GiaVeChuan = giaVeChuan,
                        DanhSachPhong = danhSachPhongChieu
                    };
                    danhSachPhim.Add(maPhim, phim);

                    // Tạo phòng chiếu với giờ chiếu mặc định
                    string[] gioChieuMacDinh = { "14:00", "16:00", "18:00", "20:00", "22:00" };
                    for (int i = 0; i < danhSachPhongChieu.Count; i++)
                    {
                        string phongNumber = danhSachPhongChieu[i];
                        string maPhongKey = $"R{phongNumber}_{maPhim}";
                        PhongChieu phongChieu = new PhongChieu
                        {
                            MaPhong = maPhongKey,
                            TenPhong = $"Phòng {phongNumber}",
                            MaPhim = maPhim,
                            GioChieu = gioChieuMacDinh[i % gioChieuMacDinh.Length]
                        };
                        this.danhSachPhongChieu.Add(maPhongKey, phongChieu);
                    }

                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tạo file mẫu
        private void TaoFileMau()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Đào, phở và piano");
            sb.AppendLine("45000");
            sb.AppendLine("1");
            sb.AppendLine("2");
            sb.AppendLine("3");
            sb.AppendLine();
            sb.AppendLine("Mai");
            sb.AppendLine("100000");
            sb.AppendLine("2");
            sb.AppendLine("3");
            sb.AppendLine();
            sb.AppendLine("Gặp lại chị bầu");
            sb.AppendLine("70000");
            sb.AppendLine("1");
            sb.AppendLine();
            sb.AppendLine("Tarot");
            sb.AppendLine("90000");
            sb.AppendLine("3");

            File.WriteAllText(FILE_INPUT, sb.ToString(), Encoding.UTF8);
        }

        // Hiển thị bảng giá
        private void HienThiBangGia()
        {
            string bangGia = "===== BẢNG GIÁ VÉ =====\n";
            bangGia += "Giá vé tùy theo phim:\n";
            bangGia += "- Vé Vớt (A1,A5,C1,C5): 1/4 giá chuẩn\n";
            bangGia += "- Vé Thường (A2-4,B1,B5,C2-4): 1× giá chuẩn\n";
            bangGia += "- Vé VIP (B2,B3,B4): 2× giá chuẩn\n\n";
            bangGia += "Giá chuẩn theo phim:\n";

            foreach (var phim in danhSachPhim.Values)
            {
                bangGia += $"• {phim.TenPhim}: {phim.GiaVeChuan:N0} VNĐ\n";
            }

            lblBangGia.Text = bangGia;
        }

        // Load danh sách phim
        private void LoadDanhSachPhim()
        {
            cboPhim.Items.Clear();
            foreach (var phim in danhSachPhim.Values)
            {
                cboPhim.Items.Add(phim.TenPhim);
            }
        }

        // Khi chọn phim
        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhim.SelectedIndex < 0) return;

            string maPhim = danhSachPhim.ElementAt(cboPhim.SelectedIndex).Key;
            phimDaChon = maPhim;

            LoadPhongChieu(maPhim);
        }

        // Load phòng chiếu theo phim
        private void LoadPhongChieu(string maPhim)
        {
            cboPhongChieu.Items.Clear();
            var phongChieuPhim = danhSachPhongChieu.Values
                .Where(p => p.MaPhim == maPhim)
                .ToList();

            foreach (var phong in phongChieuPhim)
            {
                cboPhongChieu.Items.Add($"{phong.TenPhong} - {phong.GioChieu}");
            }

            if (phongChieuPhim.Count > 0)
            {
                cboPhongChieu.Enabled = true;
            }
        }

        // Khi chọn phòng chiếu
        private void cboPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhongChieu.SelectedIndex < 0) return;

            var phongChieuPhimList = danhSachPhongChieu.Values
                .Where(p => p.MaPhim == phimDaChon)
                .ToList();

            phongDaChon = phongChieuPhimList[cboPhongChieu.SelectedIndex].MaPhong;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            hoTenKhachHang = txtHoTen.Text.Trim();

            if (string.IsNullOrEmpty(hoTenKhachHang))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (cboPhim.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboPhongChieu.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtHoTen.Enabled = false;
            cboPhim.Enabled = false;
            cboPhongChieu.Enabled = false;
            btnXacNhan.Enabled = false;

            HienThiSoDoGhe(phongDaChon);
            panelGhe.Enabled = true;
        }

        private void VoHieuHoaChonGhe()
        {
            cboPhongChieu.Enabled = false;
            panelGhe.Enabled = false;
        }

        private void HienThiSoDoGhe(string maPhong)
        {
            panelGhe.Controls.Clear();
            danhSachGhe.Clear();

            int kichThuocGhe = 50;
            int khoangCach = 10;
            int startX = 40;
            int startY = 50;

            Label lblManHinh = new Label();
            lblManHinh.Text = "=== MÀN HÌNH ===";
            lblManHinh.Font = new Font("Arial", 12, FontStyle.Bold);
            lblManHinh.AutoSize = true;
            lblManHinh.Left = startX + 60;
            lblManHinh.Top = 5;
            panelGhe.Controls.Add(lblManHinh);

            for (int hang = 0; hang < danhSachHang.Length; hang++)
            {
                char kyTuHang = danhSachHang[hang];

                for (int cot = 1; cot <= soCot; cot++)
                {
                    Button btnGhe = new Button();
                    btnGhe.Width = kichThuocGhe;
                    btnGhe.Height = kichThuocGhe;
                    btnGhe.Left = startX + (cot - 1) * (kichThuocGhe + khoangCach);
                    btnGhe.Top = startY + hang * (kichThuocGhe + khoangCach);

                    string tenGhe = kyTuHang + cot.ToString();
                    string keyGhe = $"{maPhong}_{tenGhe}";
                    string loaiGhe = phanLoaiGhe[tenGhe];

                    btnGhe.Text = tenGhe;
                    btnGhe.Name = keyGhe;
                    btnGhe.Tag = loaiGhe;
                    btnGhe.Font = new Font("Arial", 12, FontStyle.Bold);

                    if (gheDaBan.ContainsKey(keyGhe))
                    {
                        btnGhe.BackColor = mauGheDaBan;
                        btnGhe.ForeColor = Color.White;
                        btnGhe.Enabled = false;
                        btnGhe.Text = "X";
                    }
                    else
                    {
                        btnGhe.BackColor = mauGhe[loaiGhe];
                        btnGhe.ForeColor = Color.Black;
                        btnGhe.Click += BtnGhe_Click;
                    }

                    danhSachGhe.Add(keyGhe, btnGhe);
                    panelGhe.Controls.Add(btnGhe);
                }
            }

            int yChuthich = startY + danhSachHang.Length * (kichThuocGhe + khoangCach) + 20;
            ThemChuThich("Vớt", mauGhe["Vớt"], startX, yChuthich);
            ThemChuThich("Thường", mauGhe["Thường"], startX + 120, yChuthich);
            ThemChuThich("VIP", mauGhe["VIP"], startX + 240, yChuthich);
        }

        private void ThemChuThich(string tenLoai, Color mau, int x, int y)
        {
            Panel pnlMau = new Panel();
            pnlMau.BackColor = mau;
            pnlMau.BorderStyle = BorderStyle.FixedSingle;
            pnlMau.Width = 30;
            pnlMau.Height = 30;
            pnlMau.Left = x;
            pnlMau.Top = y;
            panelGhe.Controls.Add(pnlMau);

            Label lblTen = new Label();
            lblTen.Text = tenLoai;
            lblTen.AutoSize = true;
            lblTen.Left = x + 35;
            lblTen.Top = y + 7;
            lblTen.Font = new Font("Arial", 9);
            panelGhe.Controls.Add(lblTen);
        }

        private void CapNhatThongTin()
        {
            int tongTien = veDangChon.Sum(v => v.Gia);
            lblSoGhe.Text = $"Số ghế đã chọn: {veDangChon.Count}";
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";

            var thongKe = veDangChon.GroupBy(v => v.LoaiGhe)
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => new { SoLuong = g.Count(), Gia = g.First().Gia });

            string chiTiet = "";
            foreach (var loai in thongKe)
            {
                int thanhTien = loai.Value.SoLuong * loai.Value.Gia;
                chiTiet += $"Vé {loai.Key}: {loai.Value.SoLuong} × {loai.Value.Gia:N0} = {thanhTien:N0} VNĐ\n";
            }
            lblChiTiet.Text = chiTiet;
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hoTenKhachHang))
            {
                MessageBox.Show("Vui lòng xác nhận thông tin trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Button btnGhe = (Button)sender;
            string keyGhe = btnGhe.Name;
            string[] parts = keyGhe.Split('_');
            string maPhong = parts[0];
            string maGhe = parts[1];
            string loaiGhe = btnGhe.Tag.ToString();

            if (gheDaBan.ContainsKey(keyGhe))
            {
                MessageBox.Show("Ghế này đã được bán!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var veHienTai = veDangChon.FirstOrDefault(v => v.MaGhe == keyGhe);

            if (veHienTai != null)
            {
                veDangChon.Remove(veHienTai);
                btnGhe.BackColor = mauGhe[loaiGhe];
            }
            else
            {
                var vePhongKhac = veDangChon.FirstOrDefault(v => v.MaPhong != maPhong);
                if (vePhongKhac != null)
                {
                    MessageBox.Show("Không thể chọn vé ở 2 phòng chiếu khác nhau!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (veDangChon.Count >= 2)
                {
                    MessageBox.Show("Chỉ được chọn tối đa 2 vé!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var phim = danhSachPhim[phimDaChon];
                int giaVeChuan = phim.GiaVeChuan;
                int giaVe = (int)(giaVeChuan * tyLeGia[loaiGhe]);

                Ve veMoi = new Ve
                {
                    MaGhe = keyGhe,
                    LoaiGhe = loaiGhe,
                    Gia = giaVe,
                    MaPhong = maPhong,
                    MaPhim = phimDaChon
                };
                veDangChon.Add(veMoi);
                btnGhe.BackColor = mauGheDaChon;
            }

            CapNhatThongTin();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (veDangChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thống kê phim
            int tongTien = veDangChon.Sum(v => v.Gia);
            var phim = danhSachPhim[phimDaChon];
            phim.SoVeBanRa += veDangChon.Count;
            phim.DoanhThu += tongTien;

            // Lưu vé đã bán
            foreach (var ve in veDangChon)
            {
                gheDaBan.Add(ve.MaGhe, ve);
            }

            string tenPhim = danhSachPhim[phimDaChon].TenPhim;
            var phongChieu = danhSachPhongChieu[phongDaChon];
            var danhSachGheStr = string.Join(", ", veDangChon.Select(v => v.MaGhe.Split('_')[1]).OrderBy(x => x));

            string thongBao = $"Họ và tên: {hoTenKhachHang}\n" +
                            $"Phim: {tenPhim}\n" +
                            $"Phòng chiếu: {phongChieu.TenPhong}\n" +
                            $"Giờ chiếu: {phongChieu.GioChieu}\n" +
                            $"Số vé: {veDangChon.Count}\n" +
                            $"Vé đã chọn: {danhSachGheStr}\n\n" +
                            $"TỔNG TIỀN: {tongTien:N0} VNĐ\n";


            MessageBox.Show(thongBao, "Thanh toán thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
        }

        // Xuất thống kê ra file với ProgressBar
        private async void btnXuatThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị ProgressBar
                progressBar.Value = 0;
                progressBar.Visible = true;
                btnXuatThongKe.Enabled = false;

                await Task.Run(() =>
                {
                    Thread.Sleep(500); // Mô phỏng xử lý
                    this.Invoke((MethodInvoker)delegate { progressBar.Value = 20; });

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("========== THỐNG KÊ DOANH THU PHÒNG VÉ ==========");
                    sb.AppendLine($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                    sb.AppendLine("=================================================\n");

                    Thread.Sleep(300);
                    this.Invoke((MethodInvoker)delegate { progressBar.Value = 40; });

                    // Xếp hạng theo doanh thu
                    var xepHang = danhSachPhim.Values
                        .OrderByDescending(p => p.DoanhThu)
                        .ToList();

                    Thread.Sleep(300);
                    this.Invoke((MethodInvoker)delegate { progressBar.Value = 60; });

                    int rank = 1;
                    foreach (var phim in xepHang)
                    {
                        int soVeTon = tongSoGheMoiPhong * phim.DanhSachPhong.Count - phim.SoVeBanRa;
                        double tiLeBanRa = phim.SoVeBanRa > 0
                            ? (double)phim.SoVeBanRa / (tongSoGheMoiPhong * phim.DanhSachPhong.Count) * 100
                            : 0;

                        sb.AppendLine($"Xếp hạng: #{rank}");
                        sb.AppendLine($"Tên phim: {phim.TenPhim}");
                        sb.AppendLine($"Giá vé chuẩn: {phim.GiaVeChuan:N0} VNĐ");
                        sb.AppendLine($"Số vé bán ra: {phim.SoVeBanRa}");
                        sb.AppendLine($"Số vé tồn: {soVeTon}");
                        sb.AppendLine($"Tỉ lệ vé bán ra: {tiLeBanRa:F2}%");
                        sb.AppendLine($"Doanh thu: {phim.DoanhThu:N0} VNĐ");
                        sb.AppendLine("-------------------------------------------------");
                        rank++;
                    }

                    Thread.Sleep(300);
                    this.Invoke((MethodInvoker)delegate { progressBar.Value = 80; });

                    int tongDoanhThu = danhSachPhim.Values.Sum(p => p.DoanhThu);
                    int tongVeBanRa = danhSachPhim.Values.Sum(p => p.SoVeBanRa);

                    sb.AppendLine("\n=================================================");
                    sb.AppendLine($"TỔNG DOANH THU: {tongDoanhThu:N0} VNĐ");
                    sb.AppendLine($"TỔNG SỐ VÉ ĐÃ BÁN: {tongVeBanRa}");
                    sb.AppendLine("=================================================");

                    File.WriteAllText(FILE_OUTPUT, sb.ToString(), Encoding.UTF8);

                    Thread.Sleep(300);
                    this.Invoke((MethodInvoker)delegate { progressBar.Value = 100; });
                });

                MessageBox.Show($"Xuất thống kê thành công!\nFile: {FILE_OUTPUT}",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false;
                progressBar.Value = 0;
                btnXuatThongKe.Enabled = true;
            }
        }

        private void ResetForm()
        {
            veDangChon.Clear();
            hoTenKhachHang = "";
            phimDaChon = "";
            phongDaChon = "";

            txtHoTen.Clear();
            txtHoTen.Enabled = true;
            cboPhim.SelectedIndex = -1;
            cboPhim.Enabled = true;
            cboPhongChieu.Items.Clear();
            cboPhongChieu.Enabled = false;
            btnXacNhan.Enabled = true;

            panelGhe.Controls.Clear();
            panelGhe.Enabled = false;

            lblSoGhe.Text = "Số ghế đã chọn: 0";
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            lblChiTiet.Text = "Chi tiết: ";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn hủy đặt vé?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}