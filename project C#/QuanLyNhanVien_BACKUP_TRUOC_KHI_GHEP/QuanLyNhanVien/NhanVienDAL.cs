using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class NhanVienDAL
    {
        private readonly string connectionString =
              @"Data Source=RYANNGUYENZXJE\SQLEXPRESS;Initial Catalog=NhanSu;User ID=sa;Password=123456;TrustServerCertificate=True";

        public DataTable LayDanhSachNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT
                        nv.Manhanvien AS MaNV,
                        nv.HoTen AS HoTen,
                        nv.Ngaysinh AS NgaySinh,
                        CASE
                            WHEN nv.Gioitinh = 1 THEN N'Nam'
                            ELSE N'Nữ'
                        END AS GioiTinh,
                        pb.Tenphongban AS PhongBan,
                        cv.Tenchucvu AS ChucVu,
                        nv.[SĐT] AS SDT,
                        nv.Email AS Email
                    FROM Nhanvien nv
                    INNER JOIN Phongban pb
                        ON nv.Maphongban = pb.Maphongban
                    INNER JOIN Chucvu cv
                        ON nv.Machucvu = cv.Machucvu";

                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public bool ThemNhanVien(
            string hoTen,
            string sdt,
            DateTime ngaySinh,
            bool gioiTinh,
            int maPhongBan,
            int maChucVu,
            string email,
            string diaChi,
            DateTime ngayVaoLam,
            decimal luongCoBan,
            string trangThai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
            INSERT INTO Nhanvien
            (HoTen, [SĐT], Ngaysinh, Gioitinh, Maphongban,
             Machucvu, Email, DiaChi, NgayVaoLam,
             LuongCoBan, Trangthai)
            VALUES
            (@HoTen, @SDT, @NgaySinh, @GioiTinh, @MaPhongBan,
             @MaChucVu, @Email, @DiaChi, @NgayVaoLam,
             @LuongCoBan, @TrangThai)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@MaPhongBan", maPhongBan);
                    cmd.Parameters.AddWithValue("@MaChucVu", maChucVu);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@NgayVaoLam", ngayVaoLam);
                    cmd.Parameters.AddWithValue("@LuongCoBan", luongCoBan);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool SuaNhanVien(
    int maNV,
    string hoTen,
    string sdt,
    DateTime ngaySinh,
    bool gioiTinh,
    int maPhongBan,
    int maChucVu,
    string email,
    string diaChi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
            UPDATE Nhanvien
            SET HoTen = @HoTen,
                [SĐT] = @SDT,
                Ngaysinh = @NgaySinh,
                Gioitinh = @GioiTinh,
                Maphongban = @MaPhongBan,
                Machucvu = @MaChucVu,
                Email = @Email,
                DiaChi = @DiaChi
            WHERE Manhanvien = @MaNV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@MaPhongBan", maPhongBan);
                    cmd.Parameters.AddWithValue("@MaChucVu", maChucVu);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool XoaNhanVien(int maNV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Nhanvien WHERE Manhanvien = @MaNV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}