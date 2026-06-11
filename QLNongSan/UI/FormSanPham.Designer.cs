namespace QLNongSan.UI
{
    partial class FormSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvSanPham = new DataGridView();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            cboLoaiHang = new ComboBox();
            txtGiaBan = new TextBox();
            txtTenSP = new TextBox();
            txtSoLuongTon = new TextBox();
            txtMaSP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSanPham
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(131, 404);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(1307, 326);
            dgvSanPham.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboLoaiHang);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtSoLuongTon);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(131, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1307, 308);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lí sản phẩm";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(192, 255, 192);
            btnSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(791, 229);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 52);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 255, 192);
            btnXoa.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(959, 229);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(137, 52);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(192, 255, 192);
            btnLamMoi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(1130, 229);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(137, 52);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 255, 192);
            btnThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(620, 229);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 52);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // cboLoaiHang
            // 
            cboLoaiHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiHang.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiHang.FormattingEnabled = true;
            cboLoaiHang.Location = new Point(262, 152);
            cboLoaiHang.Name = "cboLoaiHang";
            cboLoaiHang.Size = new Size(261, 45);
            cboLoaiHang.TabIndex = 10;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaBan.Location = new Point(262, 229);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(261, 43);
            txtGiaBan.TabIndex = 9;
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenSP.Location = new Point(846, 75);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(261, 43);
            txtTenSP.TabIndex = 7;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.BackColor = Color.White;
            txtSoLuongTon.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuongTon.Location = new Point(846, 152);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(261, 43);
            txtSoLuongTon.TabIndex = 6;
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaSP.Location = new Point(262, 75);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(261, 43);
            txtMaSP.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(620, 152);
            label6.Name = "label6";
            label6.Size = new Size(199, 38);
            label6.TabIndex = 4;
            label6.Text = "Số lượng tồn : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(620, 75);
            label5.Name = "label5";
            label5.Size = new Size(202, 38);
            label5.TabIndex = 3;
            label5.Text = "Tên sản phẩm: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 229);
            label4.Name = "label4";
            label4.Size = new Size(197, 38);
            label4.TabIndex = 2;
            label4.Text = "Giá bán         : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 152);
            label3.Name = "label3";
            label3.Size = new Size(199, 38);
            label3.TabIndex = 1;
            label3.Text = "Loại hàng      : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 75);
            label2.Name = "label2";
            label2.Size = new Size(198, 38);
            label2.TabIndex = 0;
            label2.Text = "Mã sản phẩm: ";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1836, 856);
            Controls.Add(dgvSanPham);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "FormSanPham";
            Text = "FormSanPham";
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSanPham;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnThem;
        private ComboBox cboLoaiHang;
        private TextBox txtGiaBan;
        private TextBox txtTenSP;
        private TextBox txtSoLuongTon;
        private TextBox txtMaSP;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}