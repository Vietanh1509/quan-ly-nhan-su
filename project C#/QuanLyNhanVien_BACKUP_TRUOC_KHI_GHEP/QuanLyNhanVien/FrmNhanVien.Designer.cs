namespace QuanLyNhanVien
{
    partial class FrmNhanVien
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
        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.cboLocChucVu = new System.Windows.Forms.ComboBox();
            this.lblChucVuLoc = new System.Windows.Forms.Label();
            this.cboLocPhongBan = new System.Windows.Forms.ComboBox();
            this.lblPhongBanLoc = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPhanTrang = new System.Windows.Forms.Panel();
            this.btnTrangSau = new System.Windows.Forms.Button();
            this.btnTrangHienTai = new System.Windows.Forms.Button();
            this.btnTrangTruoc = new System.Windows.Forms.Button();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboChucvu = new System.Windows.Forms.ComboBox();
            this.cboPhongban = new System.Windows.Forms.ComboBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.lblPhongban = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblSodienthoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblHovaten = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblThongTinNV = new System.Windows.Forms.Label();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.pnlPhanTrang.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Brown;
            this.lblTieuDe.Location = new System.Drawing.Point(1, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(399, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.LightGray;
            this.pnlTimKiem.Controls.Add(this.lblTimKiem);
            this.pnlTimKiem.Controls.Add(this.cboLocChucVu);
            this.pnlTimKiem.Controls.Add(this.lblChucVuLoc);
            this.pnlTimKiem.Controls.Add(this.cboLocPhongBan);
            this.pnlTimKiem.Controls.Add(this.lblPhongBanLoc);
            this.pnlTimKiem.Controls.Add(this.btnTimKiem);
            this.pnlTimKiem.Controls.Add(this.txtTimKiem);
            this.pnlTimKiem.Location = new System.Drawing.Point(13, 83);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(866, 85);
            this.pnlTimKiem.TabIndex = 1;
            this.pnlTimKiem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTimKiem_Paint);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(21, 21);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(83, 23);
            this.lblTimKiem.TabIndex = 6;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // cboLocChucVu
            // 
            this.cboLocChucVu.FormattingEnabled = true;
            this.cboLocChucVu.Location = new System.Drawing.Point(721, 43);
            this.cboLocChucVu.Name = "cboLocChucVu";
            this.cboLocChucVu.Size = new System.Drawing.Size(121, 31);
            this.cboLocChucVu.TabIndex = 5;
            this.cboLocChucVu.SelectedIndexChanged += new System.EventHandler(this.cboLocChucVu_SelectedIndexChanged);
            // 
            // lblChucVuLoc
            // 
            this.lblChucVuLoc.AutoSize = true;
            this.lblChucVuLoc.Location = new System.Drawing.Point(748, 17);
            this.lblChucVuLoc.Name = "lblChucVuLoc";
            this.lblChucVuLoc.Size = new System.Drawing.Size(72, 23);
            this.lblChucVuLoc.TabIndex = 4;
            this.lblChucVuLoc.Text = "Chức vụ";
            // 
            // cboLocPhongBan
            // 
            this.cboLocPhongBan.FormattingEnabled = true;
            this.cboLocPhongBan.Location = new System.Drawing.Point(548, 43);
            this.cboLocPhongBan.Name = "cboLocPhongBan";
            this.cboLocPhongBan.Size = new System.Drawing.Size(121, 31);
            this.cboLocPhongBan.TabIndex = 3;
            this.cboLocPhongBan.SelectedIndexChanged += new System.EventHandler(this.cboLocPhongBan_SelectedIndexChanged);
            // 
            // lblPhongBanLoc
            // 
            this.lblPhongBanLoc.AutoSize = true;
            this.lblPhongBanLoc.Location = new System.Drawing.Point(562, 17);
            this.lblPhongBanLoc.Name = "lblPhongBanLoc";
            this.lblPhongBanLoc.Size = new System.Drawing.Size(94, 23);
            this.lblPhongBanLoc.TabIndex = 2;
            this.lblPhongBanLoc.Text = "Phòng ban";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(402, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 30);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(128, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(259, 30);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colPhongBan,
            this.colChucVu,
            this.colSDT,
            this.colEmail});
            this.dgvNhanVien.Location = new System.Drawing.Point(13, 195);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(866, 419);
            this.dgvNhanVien.TabIndex = 2;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            // 
            // colPhongBan
            // 
            this.colPhongBan.HeaderText = "Phòng ban";
            this.colPhongBan.MinimumWidth = 6;
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.ReadOnly = true;
            // 
            // colChucVu
            // 
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SDT";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // pnlPhanTrang
            // 
            this.pnlPhanTrang.BackColor = System.Drawing.Color.LightGray;
            this.pnlPhanTrang.Controls.Add(this.btnTrangSau);
            this.pnlPhanTrang.Controls.Add(this.btnTrangHienTai);
            this.pnlPhanTrang.Controls.Add(this.btnTrangTruoc);
            this.pnlPhanTrang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPhanTrang.Location = new System.Drawing.Point(13, 643);
            this.pnlPhanTrang.Name = "pnlPhanTrang";
            this.pnlPhanTrang.Size = new System.Drawing.Size(866, 50);
            this.pnlPhanTrang.TabIndex = 3;
            this.pnlPhanTrang.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPhanTrang_Paint);
            // 
            // btnTrangSau
            // 
            this.btnTrangSau.Location = new System.Drawing.Point(788, 12);
            this.btnTrangSau.Name = "btnTrangSau";
            this.btnTrangSau.Size = new System.Drawing.Size(29, 29);
            this.btnTrangSau.TabIndex = 3;
            this.btnTrangSau.Text = ">";
            this.btnTrangSau.UseVisualStyleBackColor = true;
            // 
            // btnTrangHienTai
            // 
            this.btnTrangHienTai.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTrangHienTai.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrangHienTai.Location = new System.Drawing.Point(752, 12);
            this.btnTrangHienTai.Name = "btnTrangHienTai";
            this.btnTrangHienTai.Size = new System.Drawing.Size(29, 29);
            this.btnTrangHienTai.TabIndex = 2;
            this.btnTrangHienTai.Text = "1";
            this.btnTrangHienTai.UseVisualStyleBackColor = false;
            // 
            // btnTrangTruoc
            // 
            this.btnTrangTruoc.Location = new System.Drawing.Point(719, 12);
            this.btnTrangTruoc.Name = "btnTrangTruoc";
            this.btnTrangTruoc.Size = new System.Drawing.Size(27, 29);
            this.btnTrangTruoc.TabIndex = 1;
            this.btnTrangTruoc.Text = "<";
            this.btnTrangTruoc.UseVisualStyleBackColor = true;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.LightGray;
            this.pnlThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongTin.Controls.Add(this.btn_Xoa);
            this.pnlThongTin.Controls.Add(this.txtDiachi);
            this.pnlThongTin.Controls.Add(this.txtEmail);
            this.pnlThongTin.Controls.Add(this.cboChucvu);
            this.pnlThongTin.Controls.Add(this.cboPhongban);
            this.pnlThongTin.Controls.Add(this.txtSodienthoai);
            this.pnlThongTin.Controls.Add(this.cboGioitinh);
            this.pnlThongTin.Controls.Add(this.lblChucvu);
            this.pnlThongTin.Controls.Add(this.lblPhongban);
            this.pnlThongTin.Controls.Add(this.lblDiachi);
            this.pnlThongTin.Controls.Add(this.lblSodienthoai);
            this.pnlThongTin.Controls.Add(this.lblEmail);
            this.pnlThongTin.Controls.Add(this.lblGioitinh);
            this.pnlThongTin.Controls.Add(this.lblNgaysinh);
            this.pnlThongTin.Controls.Add(this.lblHovaten);
            this.pnlThongTin.Controls.Add(this.dtpNgaysinh);
            this.pnlThongTin.Controls.Add(this.txtHovaten);
            this.pnlThongTin.Controls.Add(this.btnLamMoi);
            this.pnlThongTin.Controls.Add(this.btnSua);
            this.pnlThongTin.Controls.Add(this.btnThem);
            this.pnlThongTin.Controls.Add(this.lblThongTinNV);
            this.pnlThongTin.Location = new System.Drawing.Point(900, 206);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(588, 487);
            this.pnlThongTin.TabIndex = 4;
            this.pnlThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTin_Paint);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa.Location = new System.Drawing.Point(288, 427);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 41);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDiachi.Location = new System.Drawing.Point(313, 227);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(218, 30);
            this.txtDiachi.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(9, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 30);
            this.txtEmail.TabIndex = 19;
            // 
            // cboChucvu
            // 
            this.cboChucvu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboChucvu.FormattingEnabled = true;
            this.cboChucvu.Location = new System.Drawing.Point(313, 313);
            this.cboChucvu.Name = "cboChucvu";
            this.cboChucvu.Size = new System.Drawing.Size(218, 31);
            this.cboChucvu.TabIndex = 18;
            this.cboChucvu.SelectedIndexChanged += new System.EventHandler(this.cboChucvu_SelectedIndexChanged);
            // 
            // cboPhongban
            // 
            this.cboPhongban.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboPhongban.FormattingEnabled = true;
            this.cboPhongban.Location = new System.Drawing.Point(9, 313);
            this.cboPhongban.Name = "cboPhongban";
            this.cboPhongban.Size = new System.Drawing.Size(208, 31);
            this.cboPhongban.TabIndex = 17;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSodienthoai.Location = new System.Drawing.Point(309, 151);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(218, 30);
            this.txtSodienthoai.TabIndex = 16;
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Location = new System.Drawing.Point(9, 151);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(208, 31);
            this.cboGioitinh.TabIndex = 15;
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.Location = new System.Drawing.Point(309, 281);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(72, 23);
            this.lblChucvu.TabIndex = 14;
            this.lblChucvu.Text = "Chức vụ";
            // 
            // lblPhongban
            // 
            this.lblPhongban.AutoSize = true;
            this.lblPhongban.Location = new System.Drawing.Point(5, 281);
            this.lblPhongban.Name = "lblPhongban";
            this.lblPhongban.Size = new System.Drawing.Size(94, 23);
            this.lblPhongban.TabIndex = 13;
            this.lblPhongban.Text = "Phòng ban";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(309, 195);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(62, 23);
            this.lblDiachi.TabIndex = 12;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblSodienthoai
            // 
            this.lblSodienthoai.AutoSize = true;
            this.lblSodienthoai.Location = new System.Drawing.Point(305, 119);
            this.lblSodienthoai.Name = "lblSodienthoai";
            this.lblSodienthoai.Size = new System.Drawing.Size(111, 23);
            this.lblSodienthoai.TabIndex = 11;
            this.lblSodienthoai.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(5, 113);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(75, 23);
            this.lblGioitinh.TabIndex = 9;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(309, 48);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(86, 23);
            this.lblNgaysinh.TabIndex = 8;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblHovaten
            // 
            this.lblHovaten.AutoSize = true;
            this.lblHovaten.Location = new System.Drawing.Point(5, 54);
            this.lblHovaten.Name = "lblHovaten";
            this.lblHovaten.Size = new System.Drawing.Size(84, 23);
            this.lblHovaten.TabIndex = 7;
            this.lblHovaten.Text = "Họ và tên";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(309, 80);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(222, 30);
            this.dtpNgaysinh.TabIndex = 6;
            // 
            // txtHovaten
            // 
            this.txtHovaten.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHovaten.Location = new System.Drawing.Point(9, 80);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(208, 30);
            this.txtHovaten.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DimGray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLamMoi.Location = new System.Drawing.Point(401, 427);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(116, 41);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(162, 427);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 41);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Info;
            this.btnThem.Location = new System.Drawing.Point(32, 427);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 41);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblThongTinNV
            // 
            this.lblThongTinNV.AutoSize = true;
            this.lblThongTinNV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinNV.ForeColor = System.Drawing.Color.Brown;
            this.lblThongTinNV.Location = new System.Drawing.Point(3, 0);
            this.lblThongTinNV.Name = "lblThongTinNV";
            this.lblThongTinNV.Size = new System.Drawing.Size(274, 31);
            this.lblThongTinNV.TabIndex = 0;
            this.lblThongTinNV.Text = "THÔNG TIN NHÂN VIÊN";
            this.lblThongTinNV.Click += new System.EventHandler(this.lblThongTinNV_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1500, 784);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.pnlPhanTrang);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.pnlPhanTrang.ResumeLayout(false);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboLocChucVu;
        private System.Windows.Forms.Label lblChucVuLoc;
        private System.Windows.Forms.ComboBox cboLocPhongBan;
        private System.Windows.Forms.Label lblPhongBanLoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Panel pnlPhanTrang;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnTrangHienTai;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblThongTinNV;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblHovaten;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.Label lblPhongban;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblSodienthoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboChucvu;
        private System.Windows.Forms.ComboBox cboPhongban;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.Button btn_Xoa;
    }
}