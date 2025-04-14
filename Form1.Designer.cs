namespace GUI
{
    partial class frmQuanLyNhanVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbThongtin = new GroupBox();
            txtMaNV = new TextBox();
            label1 = new Label();
            cboVaitro = new ComboBox();
            txtTenDN = new TextBox();
            txtTenNV = new TextBox();
            txtSearch = new TextBox();
            lblVaitro = new Label();
            lblTendangnhap = new Label();
            lblTenNV = new Label();
            lblMaNV = new Label();
            dgvQLNV = new DataGridView();
            grbHanhdong = new GroupBox();
            btnSua = new Button();
            btnLammoi = new Button();
            btnXoa = new Button();
            btnTimkiem = new Button();
            btnTaomoi = new Button();
            grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLNV).BeginInit();
            grbHanhdong.SuspendLayout();
            SuspendLayout();
            // 
            // grbThongtin
            // 
            grbThongtin.Controls.Add(txtMaNV);
            grbThongtin.Controls.Add(label1);
            grbThongtin.Controls.Add(cboVaitro);
            grbThongtin.Controls.Add(txtTenDN);
            grbThongtin.Controls.Add(txtTenNV);
            grbThongtin.Controls.Add(txtSearch);
            grbThongtin.Controls.Add(lblVaitro);
            grbThongtin.Controls.Add(lblTendangnhap);
            grbThongtin.Controls.Add(lblTenNV);
            grbThongtin.Controls.Add(lblMaNV);
            grbThongtin.Location = new Point(27, 25);
            grbThongtin.Name = "grbThongtin";
            grbThongtin.Size = new Size(598, 301);
            grbThongtin.TabIndex = 7;
            grbThongtin.TabStop = false;
            grbThongtin.Text = "Thông tin";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(197, 90);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(371, 31);
            txtMaNV.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 96);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 8;
            label1.Text = "Mã NV:";
            // 
            // cboVaitro
            // 
            cboVaitro.FormattingEnabled = true;
            cboVaitro.Location = new Point(197, 240);
            cboVaitro.Name = "cboVaitro";
            cboVaitro.Size = new Size(371, 33);
            cboVaitro.TabIndex = 7;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(197, 188);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(371, 31);
            txtTenDN.TabIndex = 6;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(197, 138);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(371, 31);
            txtTenNV.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(197, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(371, 31);
            txtSearch.TabIndex = 4;
            // 
            // lblVaitro
            // 
            lblVaitro.AutoSize = true;
            lblVaitro.Location = new Point(29, 243);
            lblVaitro.Name = "lblVaitro";
            lblVaitro.Size = new Size(67, 25);
            lblVaitro.TabIndex = 3;
            lblVaitro.Text = "Vai trò:";
            // 
            // lblTendangnhap
            // 
            lblTendangnhap.AutoSize = true;
            lblTendangnhap.Location = new Point(29, 191);
            lblTendangnhap.Name = "lblTendangnhap";
            lblTendangnhap.Size = new Size(133, 25);
            lblTendangnhap.TabIndex = 2;
            lblTendangnhap.Text = "Tên đăng nhập:";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(28, 141);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(71, 25);
            lblTenNV.TabIndex = 1;
            lblTenNV.Text = "Tên NV:";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(29, 41);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(162, 25);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "NHẬP THÔNG TIN:";
            // 
            // dgvQLNV
            // 
            dgvQLNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLNV.Location = new Point(27, 350);
            dgvQLNV.Name = "dgvQLNV";
            dgvQLNV.RowHeadersWidth = 62;
            dgvQLNV.Size = new Size(992, 318);
            dgvQLNV.TabIndex = 6;
            // 
            // grbHanhdong
            // 
            grbHanhdong.Controls.Add(btnSua);
            grbHanhdong.Controls.Add(btnLammoi);
            grbHanhdong.Controls.Add(btnXoa);
            grbHanhdong.Controls.Add(btnTimkiem);
            grbHanhdong.Controls.Add(btnTaomoi);
            grbHanhdong.Location = new Point(675, 36);
            grbHanhdong.Name = "grbHanhdong";
            grbHanhdong.Size = new Size(344, 290);
            grbHanhdong.TabIndex = 8;
            grbHanhdong.TabStop = false;
            grbHanhdong.Text = "Hành động";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(99, 229);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(145, 42);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(99, 181);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(145, 42);
            btnLammoi.TabIndex = 3;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(99, 133);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(145, 42);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(99, 85);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(145, 42);
            btnTimkiem.TabIndex = 1;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // btnTaomoi
            // 
            btnTaomoi.Location = new Point(99, 37);
            btnTaomoi.Name = "btnTaomoi";
            btnTaomoi.Size = new Size(145, 42);
            btnTaomoi.TabIndex = 0;
            btnTaomoi.Text = "Tạo mới";
            btnTaomoi.UseVisualStyleBackColor = true;
            btnTaomoi.Click += btnTaomoi_Click;
            // 
            // frmQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 700);
            Controls.Add(grbThongtin);
            Controls.Add(dgvQLNV);
            Controls.Add(grbHanhdong);
            Name = "frmQuanLyNhanVien";
            Text = "Quản Lý Nhân Viên";
            Load += Form1_Load;
            grbThongtin.ResumeLayout(false);
            grbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLNV).EndInit();
            grbHanhdong.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbThongtin;
        private TextBox txtMaNV;
        private Label label1;
        private ComboBox cboVaitro;
        private TextBox txtTenDN;
        private TextBox txtTenNV;
        private TextBox txtSearch;
        private Label lblVaitro;
        private Label lblTendangnhap;
        private Label lblTenNV;
        private Label lblMaNV;
        private DataGridView dgvQLNV;
        private GroupBox grbHanhdong;
        private Button btnSua;
        private Button btnLammoi;
        private Button btnXoa;
        private Button btnTimkiem;
        private Button btnTaomoi;
    }
}
