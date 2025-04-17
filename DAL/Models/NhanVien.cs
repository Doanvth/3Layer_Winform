using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhanVien
{
    public int MaNhanVien { get; set; }

    public string HoTen { get; set; } = null!;

    public string TenDangNhap { get; set; } = null!;

    public int MaVaiTro { get; set; }

    public virtual VaiTro MaVaiTroNavigation { get; set; } = null!;
}
