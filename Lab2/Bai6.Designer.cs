namespace Lab2
{
    partial class Bai6
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.ComboBox cboNguoiDung;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.Button btnThemNguoiDung;
        private System.Windows.Forms.ListView lstDanhSachMonAn;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Button btnXoaMonAn;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Label lblKetQuaMonAn;
        private System.Windows.Forms.Label lblNguoiDongGop;
        private System.Windows.Forms.Button btnTimMonAn;
        private System.Windows.Forms.Button btnThoat;


        private void InitializeComponent()
        {
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.btnThemNguoiDung = new System.Windows.Forms.Button();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.cboNguoiDung = new System.Windows.Forms.ComboBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.btnXoaMonAn = new System.Windows.Forms.Button();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.lstDanhSachMonAn = new System.Windows.Forms.ListView();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblNguoiDongGop = new System.Windows.Forms.Label();
            this.lblKetQuaMonAn = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnTimMonAn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpNhapLieu.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNhapLieu
            // 
            this.grpNhapLieu.Controls.Add(this.btnThemNguoiDung);
            this.grpNhapLieu.Controls.Add(this.btnChonHinh);
            this.grpNhapLieu.Controls.Add(this.btnThemMonAn);
            this.grpNhapLieu.Controls.Add(this.cboNguoiDung);
            this.grpNhapLieu.Controls.Add(this.txtHinhAnh);
            this.grpNhapLieu.Controls.Add(this.txtTenMonAn);
            this.grpNhapLieu.Controls.Add(this.lblNguoiDung);
            this.grpNhapLieu.Controls.Add(this.lblHinhAnh);
            this.grpNhapLieu.Controls.Add(this.lblTenMonAn);
            this.grpNhapLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpNhapLieu.Location = new System.Drawing.Point(16, 86);
            this.grpNhapLieu.Margin = new System.Windows.Forms.Padding(4);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Padding = new System.Windows.Forms.Padding(4);
            this.grpNhapLieu.Size = new System.Drawing.Size(613, 283);
            this.grpNhapLieu.TabIndex = 0;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thêm Món Ăn Mới";
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemNguoiDung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemNguoiDung.Location = new System.Drawing.Point(480, 132);
            this.btnThemNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.Size = new System.Drawing.Size(113, 34);
            this.btnThemNguoiDung.TabIndex = 8;
            this.btnThemNguoiDung.Text = "Thêm";
            this.btnThemNguoiDung.UseVisualStyleBackColor = false;
            this.btnThemNguoiDung.Click += new System.EventHandler(this.btnThemNguoiDung_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.BackColor = System.Drawing.SystemColors.Control;
            this.btnChonHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnChonHinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChonHinh.Location = new System.Drawing.Point(480, 82);
            this.btnChonHinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(113, 34);
            this.btnChonHinh.TabIndex = 7;
            this.btnChonHinh.Text = "Chọn...";
            this.btnChonHinh.UseVisualStyleBackColor = false;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemMonAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemMonAn.Location = new System.Drawing.Point(200, 197);
            this.btnThemMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(267, 62);
            this.btnThemMonAn.TabIndex = 6;
            this.btnThemMonAn.Text = "THÊM MÓN ĂN";
            this.btnThemMonAn.UseVisualStyleBackColor = false;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // cboNguoiDung
            // 
            this.cboNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboNguoiDung.FormattingEnabled = true;
            this.cboNguoiDung.Location = new System.Drawing.Point(200, 134);
            this.cboNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.cboNguoiDung.Name = "cboNguoiDung";
            this.cboNguoiDung.Size = new System.Drawing.Size(265, 28);
            this.cboNguoiDung.TabIndex = 5;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHinhAnh.Location = new System.Drawing.Point(200, 85);
            this.txtHinhAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.ReadOnly = true;
            this.txtHinhAnh.Size = new System.Drawing.Size(265, 26);
            this.txtHinhAnh.TabIndex = 4;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTenMonAn.Location = new System.Drawing.Point(200, 37);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(392, 26);
            this.txtTenMonAn.TabIndex = 3;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNguoiDung.Location = new System.Drawing.Point(20, 138);
            this.lblNguoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(130, 20);
            this.lblNguoiDung.TabIndex = 2;
            this.lblNguoiDung.Text = "Người đóng góp:";
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHinhAnh.Location = new System.Drawing.Point(20, 89);
            this.lblHinhAnh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(81, 20);
            this.lblHinhAnh.TabIndex = 1;
            this.lblHinhAnh.Text = "Hình ảnh:";
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.AutoSize = true;
            this.lblTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTenMonAn.Location = new System.Drawing.Point(20, 41);
            this.lblTenMonAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(102, 20);
            this.lblTenMonAn.TabIndex = 0;
            this.lblTenMonAn.Text = "Tên món ăn:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.btnXoaMonAn);
            this.grpDanhSach.Controls.Add(this.lstDanhSachMonAn);
            this.grpDanhSach.Controls.Add(this.lblTongSo);
            this.grpDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(16, 382);
            this.grpDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(4);
            this.grpDanhSach.Size = new System.Drawing.Size(613, 345);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh Sách Món Ăn";
            // 
            // btnXoaMonAn
            // 
            this.btnXoaMonAn.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaMonAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaMonAn.Location = new System.Drawing.Point(413, 294);
            this.btnXoaMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaMonAn.Name = "btnXoaMonAn";
            this.btnXoaMonAn.Size = new System.Drawing.Size(180, 43);
            this.btnXoaMonAn.TabIndex = 2;
            this.btnXoaMonAn.Text = "Xóa món ăn";
            this.btnXoaMonAn.UseVisualStyleBackColor = false;
            this.btnXoaMonAn.Click += new System.EventHandler(this.btnXoaMonAn_Click);
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTongSo.Location = new System.Drawing.Point(8, 313);
            this.lblTongSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(133, 18);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "Tổng số món ăn: 0";
            // 
            // lstDanhSachMonAn
            // 
            this.lstDanhSachMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lstDanhSachMonAn.FullRowSelect = true;
            this.lstDanhSachMonAn.GridLines = true;
            this.lstDanhSachMonAn.HideSelection = false;
            this.lstDanhSachMonAn.Location = new System.Drawing.Point(20, 31);
            this.lstDanhSachMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.lstDanhSachMonAn.Name = "lstDanhSachMonAn";
            this.lstDanhSachMonAn.Size = new System.Drawing.Size(572, 245);
            this.lstDanhSachMonAn.TabIndex = 0;
            this.lstDanhSachMonAn.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachMonAn.View = System.Windows.Forms.View.Details;
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lblNguoiDongGop);
            this.grpKetQua.Controls.Add(this.lblKetQuaMonAn);
            this.grpKetQua.Controls.Add(this.picHinhAnh);
            this.grpKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.Location = new System.Drawing.Point(653, 86);
            this.grpKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Padding = new System.Windows.Forms.Padding(4);
            this.grpKetQua.Size = new System.Drawing.Size(507, 640);
            this.grpKetQua.TabIndex = 2;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Món Ăn Được Chọn";
            this.grpKetQua.Visible = false;
            // 
            // lblNguoiDongGop
            // 
            this.lblNguoiDongGop.BackColor = System.Drawing.SystemColors.Control;
            this.lblNguoiDongGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDongGop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNguoiDongGop.Location = new System.Drawing.Point(27, 529);
            this.lblNguoiDongGop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNguoiDongGop.Name = "lblNguoiDongGop";
            this.lblNguoiDongGop.Size = new System.Drawing.Size(453, 98);
            this.lblNguoiDongGop.TabIndex = 2;
            this.lblNguoiDongGop.Text = "Người đóng góp: ";
            this.lblNguoiDongGop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKetQuaMonAn
            // 
            this.lblKetQuaMonAn.BackColor = System.Drawing.SystemColors.Control;
            this.lblKetQuaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblKetQuaMonAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKetQuaMonAn.Location = new System.Drawing.Point(27, 443);
            this.lblKetQuaMonAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQuaMonAn.Name = "lblKetQuaMonAn";
            this.lblKetQuaMonAn.Size = new System.Drawing.Size(453, 74);
            this.lblKetQuaMonAn.TabIndex = 1;
            this.lblKetQuaMonAn.Text = "Tên món ăn";
            this.lblKetQuaMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Location = new System.Drawing.Point(53, 43);
            this.picHinhAnh.Margin = new System.Windows.Forms.Padding(4);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(399, 369);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 0;
            this.picHinhAnh.TabStop = false;
            // 
            // btnTimMonAn
            // 
            this.btnTimMonAn.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnTimMonAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimMonAn.Location = new System.Drawing.Point(653, 738);
            this.btnTimMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimMonAn.Name = "btnTimMonAn";
            this.btnTimMonAn.Size = new System.Drawing.Size(373, 74);
            this.btnTimMonAn.TabIndex = 4;
            this.btnTimMonAn.Text = "TÌM MÓN ĂN NGẪU NHIÊN";
            this.btnTimMonAn.UseVisualStyleBackColor = false;
            this.btnTimMonAn.Click += new System.EventHandler(this.btnTimMonAn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThoat.Location = new System.Drawing.Point(1040, 738);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 74);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1179, 826);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimMonAn);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpNhapLieu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Bai6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai6";
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}