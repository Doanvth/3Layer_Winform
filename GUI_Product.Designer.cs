namespace GUI
{
    partial class FormProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pbImage = new PictureBox();
            label5 = new Label();
            btnUpload = new Button();
            dgvProducts = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            btnExport = new Button();
            btnExtension = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(324, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 74);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 103);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 184);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 260);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 3;
            label4.Text = "Product Price:";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(660, 143);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(307, 229);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 4;
            pbImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(660, 103);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 5;
            label5.Text = "Choose Image:";
            // 
            // btnUpload
            // 
            btnUpload.ForeColor = Color.DodgerBlue;
            btnUpload.Location = new Point(823, 98);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(112, 34);
            btnUpload.TabIndex = 6;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(64, 408);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(903, 279);
            dgvProducts.TabIndex = 7;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(72, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 46);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.DarkOrange;
            btnEdit.Location = new Point(171, 326);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 46);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.OrangeRed;
            btnDelete.Location = new Point(262, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 46);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(215, 107);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(402, 31);
            txtProductId.TabIndex = 11;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(215, 178);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(402, 31);
            txtProductName.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(215, 254);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(402, 31);
            txtPrice.TabIndex = 13;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExport.ForeColor = Color.Fuchsia;
            btnExport.Location = new Point(369, 326);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(103, 46);
            btnExport.TabIndex = 14;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnExtension
            // 
            btnExtension.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExtension.ForeColor = Color.Goldenrod;
            btnExtension.Location = new Point(478, 326);
            btnExtension.Name = "btnExtension";
            btnExtension.Size = new Size(139, 46);
            btnExtension.TabIndex = 15;
            btnExtension.Text = "Extension";
            btnExtension.UseVisualStyleBackColor = true;
            btnExtension.Click += btnExtension_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 726);
            Controls.Add(btnExtension);
            Controls.Add(btnExport);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Controls.Add(btnUpload);
            Controls.Add(label5);
            Controls.Add(pbImage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduct";
            Text = "Form Product ";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbImage;
        private Label label5;
        private Button btnUpload;
        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private Button btnExport;
        private Button btnExtension;
    }
}