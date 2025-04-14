using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormProduct : System.Windows.Forms.Form
    {
        private ProductBLL productBLL = new ProductBLL();


        private string selectedImagePath = ""; // cần quan tâm

        public FormProduct()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = productBLL.GetAll();
            dgvProducts.Columns["ImagePath"].Visible = false; // Ẩn đường dẫn ảnh
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductDTO product = new ProductDTO
            {
                ProductName = txtProductName.Text,
                Price = decimal.Parse(txtPrice.Text),
                ImagePath = selectedImagePath
            };

            productBLL.Add(product);
            LoadProducts();
            ClearFields();
        }
        private void ClearFields()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            pbImage.Image = null;
            selectedImagePath = "";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dlg.FileName;
                pbImage.ImageLocation = selectedImagePath;
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                selectedImagePath = row.Cells["ImagePath"].Value.ToString();
                pbImage.ImageLocation = selectedImagePath;
            }
        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                ProductDTO product = new ProductDTO
                {
                    ProductID = (int)dgvProducts.CurrentRow.Cells["ProductID"].Value,
                    ProductName = txtProductName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ImagePath = selectedImagePath
                };

                productBLL.Update(product);
                LoadProducts();
                ClearFields();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int id = (int)dgvProducts.CurrentRow.Cells["ProductID"].Value;
                productBLL.Delete(id);
                LoadProducts();
                ClearFields();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            string filePath = @"D:\DanhSachNhanVien.csv";

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // Ghi dòng tiêu đề
                    for (int i = 0; i < dgvProducts.Columns.Count; i++)
                    {
                        sw.Write(dgvProducts.Columns[i].HeaderText);
                        if (i < dgvProducts.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // Ghi từng dòng dữ liệu
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgvProducts.Columns.Count; i++)
                            {
                                var value = row.Cells[i].Value?.ToString().Replace(",", " "); // Tránh lỗi khi có dấu ,
                                sw.Write(value);
                                if (i < dgvProducts.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Xuất danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExtension_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Chọn nơi lưu danh sách nhân viên";
            saveFileDialog.FileName = "DanhSachNhanVien.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        // Ghi tiêu đề
                        for (int i = 0; i < dgvProducts.Columns.Count; i++)
                        {
                            sw.Write(dgvProducts.Columns[i].HeaderText);
                            if (i < dgvProducts.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Ghi từng dòng
                        foreach (DataGridViewRow row in dgvProducts.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvProducts.Columns.Count; i++)
                                {
                                    var value = row.Cells[i].Value?.ToString().Replace(",", " ");
                                    sw.Write(value);
                                    if (i < dgvProducts.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Xuất danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
