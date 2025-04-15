using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        public static List<NhanVienDTO> GetAll()
        {
            return NhanVienDAL.GetAllNhanVien();
        }
        public static void Add(NhanVienDTO nv)
        {
            NhanVienDAL.InsertNhanVien(nv);
        }
    }
}
