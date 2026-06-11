namespace QLNongSan.UI
{
    partial class FormLoaiHang
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvLoaiHang = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            txtTenLoai = new TextBox();
            txtMaLoai = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dgvLoaiHang);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(170, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1277, 707);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lí loại hàng";
            // 
            // dgvLoaiHang
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dgvLoaiHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoaiHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoaiHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiHang.ImeMode = ImeMode.NoControl;
            dgvLoaiHang.Location = new Point(105, 385);
            dgvLoaiHang.Name = "dgvLoaiHang";
            dgvLoaiHang.ReadOnly = true;
            dgvLoaiHang.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Blue;
            dgvLoaiHang.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvLoaiHang.Size = new Size(1079, 259);
            dgvLoaiHang.TabIndex = 5;
            dgvLoaiHang.CellContentClick += dgvLoaiHang_CellContentClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(192, 255, 192);
            btnLamMoi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(933, 305);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(153, 52);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 255, 192);
            btnXoa.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(680, 305);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 52);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(192, 255, 192);
            btnSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(424, 305);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(153, 52);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 255, 192);
            btnThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(173, 305);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 52);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTenLoai);
            groupBox2.Controls.Add(txtMaLoai);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(105, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1079, 169);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin loại hàng";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenLoai.Location = new Point(746, 77);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(235, 43);
            txtTenLoai.TabIndex = 3;
            // 
            // txtMaLoai
            // 
            txtMaLoai.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaLoai.Location = new Point(254, 77);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(235, 43);
            txtMaLoai.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(540, 77);
            label2.Name = "label2";
            label2.Size = new Size(188, 38);
            label2.TabIndex = 1;
            label2.Text = "Tên loại hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 77);
            label1.Name = "label1";
            label1.Size = new Size(184, 38);
            label1.TabIndex = 0;
            label1.Text = "Mã loại hàng:";
            // 
            // FormLoaiHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.Untitled;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1835, 860);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = Color.CornflowerBlue;
            Name = "FormLoaiHang";
            Text = "FormLoaiHang";
            Load += FormLoaiHang_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Button btnThem;
        private TextBox txtTenLoai;
        private TextBox txtMaLoai;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dgvLoaiHang;
    }
}