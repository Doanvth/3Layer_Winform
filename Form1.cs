using BLL;
using DTO;
using System.Data;

namespace GUI
{
    public partial class frmQuanLyNhanVien : System.Windows.Forms.Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
            LoadCombo();
        }

        private void LoadData()
        {
            dgvQLNV.DataSource = NhanVienBLL.GetAll();
        }

        VaiTroBLL vaitroBLL = new VaiTroBLL();

        private void LoadCombo()
        {
            DataTable dt = vaitroBLL.GetVaiTroList();

            cboVaitro.DataSource = dt;
            cboVaitro.DisplayMember = "TenVaiTro";
            cboVaitro.ValueMember = "MaVaiTro";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ClearForm()
        {
            txtMaNV.Text = "";
            txtTenDN.Text = "";
            txtTenNV.Text = "";
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            var nv = new NhanVienDTO
            {
                HoTen = txtTenNV.Text.Trim(),
                TenDangNhap = txtTenDN.Text.Trim(),
                MaVaiTro = Convert.ToInt32(cboVaitro.SelectedValue)
            };
            NhanVienBLL.Add(nv);
            MessageBox.Show("Thêm thành công");
            LoadData();
            ClearForm();
        }
    }
}
