using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyNhanVien
{
    public partial class FrmNhanVien : Form
    {
        private NhanVienDAL dal = new NhanVienDAL();
        private DataTable bangNhanVien;
        public FrmNhanVien()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();
        }
        private void LoadDanhSachNhanVien()
        {
            bangNhanVien = dal.LayDanhSachNhanVien();

            dgvNhanVien.AutoGenerateColumns = false;

            dgvNhanVien.Columns["colMaNV"].DataPropertyName = "MaNV";
            dgvNhanVien.Columns["colHoTen"].DataPropertyName = "HoTen";
            dgvNhanVien.Columns["colNgaySinh"].DataPropertyName = "NgaySinh";
            dgvNhanVien.Columns["colGioiTinh"].DataPropertyName = "GioiTinh";
            dgvNhanVien.Columns["colPhongBan"].DataPropertyName = "PhongBan";
            dgvNhanVien.Columns["colChucVu"].DataPropertyName = "ChucVu";
            dgvNhanVien.Columns["colSDT"].DataPropertyName = "SDT";
            dgvNhanVien.Columns["colEmail"].DataPropertyName = "Email";
            dgvNhanVien.DataSource = bangNhanVien;
            NapDuLieuComboBox();
        }

        private void NapDuLieuComboBox()    // Hàm này dùng để nạp dữ liệu cho các ComboBox//
        {
            cboGioitinh.Items.Clear();
            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");
            cboGioitinh.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable dtPhongBan = new DataTable();
            DataTable dtChucVu = new DataTable();

            using (SqlConnection conn = new SqlConnection(
                @"Data Source=RYANNGUYENZXJE\SQLEXPRESS;Initial Catalog=NhanSu;User ID=sa;Password=123456;TrustServerCertificate=True"))
            {
                conn.Open();

                new SqlDataAdapter(
                    "SELECT Maphongban, Tenphongban FROM Phongban",
                    conn).Fill(dtPhongBan);

                new SqlDataAdapter(
                    "SELECT Machucvu, Tenchucvu FROM Chucvu",
                    conn).Fill(dtChucVu);
            }

            cboPhongban.DataSource = dtPhongBan;
            cboPhongban.DisplayMember = "Tenphongban";
            cboPhongban.ValueMember = "Maphongban";
            cboPhongban.DropDownStyle = ComboBoxStyle.DropDownList;

            cboChucvu.DataSource = dtChucVu;
            cboChucvu.DisplayMember = "Tenchucvu";
            cboChucvu.ValueMember = "Machucvu";
            cboChucvu.DropDownStyle = ComboBoxStyle.DropDownList;

            cboLocPhongBan.Items.Clear();
            cboLocPhongBan.Items.Add("Tất cả");

            foreach (DataRow row in dtPhongBan.Rows)
                cboLocPhongBan.Items.Add(row["Tenphongban"].ToString());

            cboLocChucVu.Items.Clear();
            cboLocChucVu.Items.Add("Tất cả");

            foreach (DataRow row in dtChucVu.Rows)
                cboLocChucVu.Items.Add(row["Tenchucvu"].ToString());

            cboLocPhongBan.SelectedIndex = 0;
            cboLocChucVu.SelectedIndex = 0;
        }

        private void LocNhanVien()
        {
            if (bangNhanVien == null)
                return;

            DataView view = bangNhanVien.DefaultView;
            string dieuKien = "";

            if (cboLocPhongBan.Text != "" && cboLocPhongBan.Text != "Tất cả")
            {
                dieuKien = "[PhongBan] = '" + cboLocPhongBan.Text + "'";
            }

            if (cboLocChucVu.Text != "" && cboLocChucVu.Text != "Tất cả")
            {
                if (dieuKien != "")
                    dieuKien += " AND ";

                dieuKien += "[ChucVu] = '" + cboLocChucVu.Text + "'";
            }

            view.RowFilter = dieuKien;
            dgvNhanVien.DataSource = view;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm!");
                return;
            }

            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string hoTen = Convert.ToString(row.Cells["colHoTen"].Value);

                if (hoTen.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    row.Selected = true;
                    dgvNhanVien.CurrentCell = row.Cells["colHoTen"];
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy nhân viên!");
        }

        private void pnlPhanTrang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblThongTinNV_Click(object sender, EventArgs e)
        {

        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHovaten.Clear();
            dtpNgaysinh.Value = DateTime.Today;
            cboGioitinh.SelectedIndex = -1;
            txtSodienthoai.Clear();
            txtEmail.Clear();
            txtDiachi.Clear();
            cboPhongban.SelectedIndex = -1;
            cboChucvu.SelectedIndex = -1;
            txtTimKiem.Clear();

            dgvNhanVien.ClearSelection();
            cboLocPhongBan.SelectedIndex = -1;
            cboLocChucVu.SelectedIndex = -1;

            if (bangNhanVien != null)
            {
                bangNhanVien.DefaultView.RowFilter = "";
                dgvNhanVien.DataSource = bangNhanVien;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null ||
        string.IsNullOrWhiteSpace(txtHovaten.Text) ||
        string.IsNullOrWhiteSpace(txtSodienthoai.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtDiachi.Text) ||
        cboGioitinh.SelectedIndex == -1 ||
        cboPhongban.SelectedIndex == -1 ||
        cboChucvu.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn nhân viên và nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                int maNV = Convert.ToInt32(
                    dgvNhanVien.CurrentRow.Cells["colMaNV"].Value);

                bool ketQua = dal.SuaNhanVien(
                    maNV,
                    txtHovaten.Text,
                    txtSodienthoai.Text,
                    dtpNgaysinh.Value,
                    cboGioitinh.Text == "Nam",
                    Convert.ToInt32(cboPhongban.SelectedValue),
                    Convert.ToInt32(cboChucvu.SelectedValue),
                    txtEmail.Text,
                    txtDiachi.Text
                );

                if (ketQua)
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHovaten.Text) ||
        string.IsNullOrWhiteSpace(txtSodienthoai.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtDiachi.Text) ||
        cboGioitinh.SelectedIndex == -1 ||
        cboPhongban.SelectedIndex == -1 ||
        cboChucvu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                bool ketQua = dal.ThemNhanVien(
                    txtHovaten.Text,
                    txtSodienthoai.Text,
                    dtpNgaysinh.Value,
                    cboGioitinh.Text == "Nam",
                    Convert.ToInt32(cboPhongban.SelectedValue),
                    Convert.ToInt32(cboChucvu.SelectedValue),
                    txtEmail.Text,
                    txtDiachi.Text,
                    DateTime.Today,
                    0m,
                    "Đang làm việc"
                );

                if (ketQua)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLocPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocNhanVien();
        }

        private void cboLocChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocNhanVien();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            txtHovaten.Text = Convert.ToString(row.Cells["colHoTen"].Value);
            object giaTriNgaySinh = row.Cells["colNgaySinh"].Value;

            if (giaTriNgaySinh != null &&
                giaTriNgaySinh != DBNull.Value &&
                DateTime.TryParse(giaTriNgaySinh.ToString(), out DateTime ngaySinh) &&
                ngaySinh >= dtpNgaysinh.MinDate &&
                ngaySinh <= dtpNgaysinh.MaxDate)
            {
                dtpNgaysinh.Value = ngaySinh;
            }
            else
            {
                dtpNgaysinh.Value = DateTime.Today;
            }
            cboGioitinh.Text = Convert.ToString(row.Cells["colGioiTinh"].Value);
            txtSodienthoai.Text = Convert.ToString(row.Cells["colSDT"].Value);
            txtEmail.Text = Convert.ToString(row.Cells["colEmail"].Value);
            cboPhongban.Text = Convert.ToString(row.Cells["colPhongBan"].Value);
            cboChucvu.Text = Convert.ToString(row.Cells["colChucVu"].Value);

        }

        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTimKiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            int maNV = Convert.ToInt32(
                dgvNhanVien.CurrentRow.Cells["colMaNV"].Value);

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    bool ketQua = dal.XoaNhanVien(maNV);

                    if (ketQua)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên cần xóa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa nhân viên: " + ex.Message);
                }
            }
        }

        private void cboChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
