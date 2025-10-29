using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Lab2
{
    public partial class Bai6 : Form
    {
        private string connectionString = "Data Source=MonAn.db;Version=3;";
        private Random random = new Random();

        public Bai6()
        {
            InitializeComponent();
            KhoiTaoDatabase();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                new SQLiteCommand("DELETE FROM MonAn", conn).ExecuteNonQuery();
                conn.Close();
            }

            LoadDanhSachMonAn();
            LoadDanhSachNguoiDung();
        }

        private void KhoiTaoDatabase()
        {
            try
            {
                if (!File.Exists("MonAn.db"))
                {
                    SQLiteConnection.CreateFile("MonAn.db");
                }

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // Tạo bảng NguoiDung
                    string createNguoiDungTable = @"
                        CREATE TABLE IF NOT EXISTS NguoiDung (
                            IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                            HoVaTen TEXT NOT NULL,
                            QuyenHan TEXT NOT NULL
                        )";

                    // Tạo bảng MonAn
                    string createMonAnTable = @"
                        CREATE TABLE IF NOT EXISTS MonAn (
                            IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                            TenMonAn TEXT NOT NULL,
                            HinhAnh TEXT,
                            IDNCC INTEGER,
                            FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                        )";

                    using (SQLiteCommand cmd = new SQLiteCommand(createNguoiDungTable, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand(createMonAnTable, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo database: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadDanhSachMonAn()
        {
            try
            {
                lstDanhSachMonAn.Items.Clear();
                lstDanhSachMonAn.View = View.Details;

                if (lstDanhSachMonAn.Columns.Count == 0)
                {
                    lstDanhSachMonAn.Columns.Add("ID", 50);
                    lstDanhSachMonAn.Columns.Add("Tên Món Ăn", 150);
                    lstDanhSachMonAn.Columns.Add("Người Đóng Góp", 150);
                    lstDanhSachMonAn.Columns.Add("Hình Ảnh", 150);
                }

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT m.IDMA, m.TenMonAn, m.HinhAnh, n.HoVaTen 
                        FROM MonAn m 
                        LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC
                        ORDER BY m.IDMA";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                            item.SubItems.Add(reader["TenMonAn"].ToString());
                            item.SubItems.Add(reader["HoVaTen"].ToString());
                            item.SubItems.Add(reader["HinhAnh"].ToString());
                            lstDanhSachMonAn.Items.Add(item);
                        }
                    }
                }

                lblTongSo.Text = $"Tổng số món ăn: {lstDanhSachMonAn.Items.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachNguoiDung()
        {
            try
            {
                cboNguoiDung.DataSource = null;

                cboNguoiDung.DisplayMember = "HoVaTen";
                cboNguoiDung.ValueMember = "IDNCC";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT IDNCC, HoVaTen FROM NguoiDung ORDER BY HoVaTen";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        cboNguoiDung.DataSource = dt;
                    }
                }

                if (cboNguoiDung.Items.Count > 0)
                    cboNguoiDung.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load người dùng: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            string tenMonAn = txtTenMonAn.Text.Trim();
            string hinhAnh = txtHinhAnh.Text.Trim();

            if (string.IsNullOrEmpty(tenMonAn))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMonAn.Focus();
                return;
            }

            if (cboNguoiDung.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn người đóng góp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@TenMonAn, @HinhAnh, @IDNCC)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                        cmd.Parameters.AddWithValue("@HinhAnh", string.IsNullOrEmpty(hinhAnh) ? DBNull.Value : (object)hinhAnh);
                        cmd.Parameters.AddWithValue("@IDNCC", cboNguoiDung.SelectedValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đã thêm món ăn thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTenMonAn.Clear();
                txtHinhAnh.Clear();
                txtTenMonAn.Focus();
                LoadDanhSachMonAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món ăn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Chọn hình ảnh món ăn";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtHinhAnh.Text = ofd.FileName;
                }
            }
        }

        private void btnTimMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // Đếm số lượng món ăn
                    string countQuery = "SELECT COUNT(*) FROM MonAn";
                    int totalMonAn = 0;

                    using (SQLiteCommand cmd = new SQLiteCommand(countQuery, conn))
                    {
                        totalMonAn = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (totalMonAn == 0)
                    {
                        MessageBox.Show("Danh sách món ăn đang trống!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Chọn ngẫu nhiên một món ăn
                    int randomOffset = random.Next(0, totalMonAn);
                    string query = @"
                        SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen 
                        FROM MonAn m 
                        LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC
                        LIMIT 1 OFFSET @Offset";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Offset", randomOffset);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tenMonAn = reader["TenMonAn"].ToString();
                                string hinhAnh = reader["HinhAnh"].ToString();
                                string nguoiDongGop = reader["HoVaTen"].ToString();

                                // Hiển thị kết quả
                                lblKetQuaMonAn.Text = tenMonAn;
                                lblNguoiDongGop.Text = $"Người đóng góp: {nguoiDongGop}";

                                // Hiển thị hình ảnh nếu có
                                if (!string.IsNullOrEmpty(hinhAnh) && File.Exists(hinhAnh))
                                {
                                    picHinhAnh.Image = Image.FromFile(hinhAnh);
                                    picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    picHinhAnh.Image = null;
                                    lblNguoiDongGop.Text += "\n(Chưa có hình ảnh)";
                                }

                                // Hiệu ứng hiển thị
                                grpKetQua.Visible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm món ăn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            if (lstDanhSachMonAn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa món ăn đã chọn?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int idma = int.Parse(lstDanhSachMonAn.SelectedItems[0].Text);

                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM MonAn WHERE IDMA = @IDMA";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IDMA", idma);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã xóa món ăn!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachMonAn();
                    grpKetQua.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa món ăn: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Xóa toàn bộ dữ liệu trong bảng MonAn
                string query = "DELETE FROM MonAn";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Đã xóa toàn bộ danh sách món ăn cũ!");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            using (Form formNguoiDung = new Form())
            {
                formNguoiDung.Text = "Thêm Người Dùng";
                formNguoiDung.Size = new Size(400, 200);
                formNguoiDung.StartPosition = FormStartPosition.CenterParent;

                Label lblHoTen = new Label() { Left = 20, Top = 20, Text = "Họ và tên:", Width = 100 };
                TextBox txtHoTen = new TextBox() { Left = 130, Top = 20, Width = 200 };

                Label lblQuyen = new Label() { Left = 20, Top = 60, Text = "Quyền hạn:", Width = 100 };
                ComboBox cboQuyen = new ComboBox() { Left = 130, Top = 60, Width = 200 };
                cboQuyen.Items.AddRange(new string[] { "Admin", "User" });
                cboQuyen.SelectedIndex = 1;

                Button btnLuu = new Button() { Text = "Lưu", Left = 150, Top = 100, Width = 80 };
                btnLuu.Click += (s, ev) =>
                {
                    if (string.IsNullOrEmpty(txtHoTen.Text.Trim()))
                    {
                        MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                        {
                            conn.Open();
                            string query = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@HoVaTen, @QuyenHan)";

                            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@HoVaTen", txtHoTen.Text.Trim());
                                cmd.Parameters.AddWithValue("@QuyenHan", cboQuyen.Text);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Đã thêm người dùng!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNguoiDung();
                        formNguoiDung.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                formNguoiDung.Controls.AddRange(new Control[] { lblHoTen, txtHoTen, lblQuyen, cboQuyen, btnLuu });
                formNguoiDung.ShowDialog();
            }
        }
    }
}
