using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        public static List<NhanVienDTO> GetAllNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new NhanVienDTO
                    {
                        MaNhanVien = Convert.ToInt32(reader["MaNhanVien"]),
                        HoTen = reader["HoTen"].ToString(),
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MaVaiTro = Convert.ToInt32(reader["MaVaiTro"])
                    });
                }
            }
            return list;
        }
        public static void InsertNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO NhanVien(HoTen, TenDangNhap, MaVaiTro) VALUES (@HoTen, @TenDangNhap, @MaVaiTro)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@TenDangNhap", nv.TenDangNhap);
                cmd.Parameters.AddWithValue("@MaVaiTro", nv.MaVaiTro);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
