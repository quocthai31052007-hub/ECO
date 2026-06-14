namespace QLNongSan.UI
{
    partial class FormTraCuuLo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            lblKetQua = new Label();
            lblHuongDan = new Label();
            dgvKetQua = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            pnlChiTiet = new Panel();
            lblTieuDeChiTiet = new Label();
            lblChiTietMaLo = new Label();
            lblChiTietTenLo = new Label();
            lblChiTietSanPham = new Label();
            lblChiTietSoLuong = new Label();
            lblChiTietNguonGoc = new Label();
            lblChiTietGhiChu = new Label();
            lblChiTietNgayNhap = new Label();
            lblChiTietNgayMua = new Label();
            lblChiTietTrangThai = new Label();
            lblChiTietLienHe = new Label();
            lblChiTietMaPN = new Label();
            btnDong = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            pnlChiTiet.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 12F);
            txtTimKiem.Location = new Point(20, 55);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã lô (VD: LO001) hoặc tên lô...";
            txtTimKiem.Size = new Size(480, 34);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.DarkGreen;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(515, 52);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 38);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tra cứu";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKetQua.Location = new Point(20, 100);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(500, 24);
            lblKetQua.TabIndex = 3;
            // 
            // lblHuongDan
            // 
            lblHuongDan.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblHuongDan.ForeColor = Color.DarkGreen;
            lblHuongDan.Location = new Point(20, 18);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(700, 28);
            lblHuongDan.TabIndex = 0;
            lblHuongDan.Text = "Nhập mã lô hoặc tên lô để tra cứu thông tin nguồn gốc hàng hóa";
            // 
            // dgvKetQua
            // 
            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.BackgroundColor = Color.White;
            dgvKetQua.BorderStyle = BorderStyle.None;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvKetQua.Font = new Font("Segoe UI", 10F);
            dgvKetQua.Location = new Point(20, 127);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.ReadOnly = true;
            dgvKetQua.RowHeadersVisible = false;
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.Size = new Size(960, 211);
            dgvKetQua.TabIndex = 4;
            dgvKetQua.CellClick += dgvKetQua_CellClick;
            dgvKetQua.CellContentClick += dgvKetQua_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã lô";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên lô";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Sản phẩm";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ngày nhập";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Tình trạng";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // pnlChiTiet
            // 
            pnlChiTiet.BackColor = Color.White;
            pnlChiTiet.BorderStyle = BorderStyle.FixedSingle;
            pnlChiTiet.Controls.Add(lblTieuDeChiTiet);
            pnlChiTiet.Controls.Add(lblChiTietMaLo);
            pnlChiTiet.Controls.Add(lblChiTietTenLo);
            pnlChiTiet.Controls.Add(lblChiTietSanPham);
            pnlChiTiet.Controls.Add(lblChiTietSoLuong);
            pnlChiTiet.Controls.Add(lblChiTietNguonGoc);
            pnlChiTiet.Controls.Add(lblChiTietGhiChu);
            pnlChiTiet.Controls.Add(lblChiTietNgayNhap);
            pnlChiTiet.Controls.Add(lblChiTietNgayMua);
            pnlChiTiet.Controls.Add(lblChiTietTrangThai);
            pnlChiTiet.Controls.Add(lblChiTietLienHe);
            pnlChiTiet.Controls.Add(lblChiTietMaPN);
            pnlChiTiet.Location = new Point(20, 350);
            pnlChiTiet.Name = "pnlChiTiet";
            pnlChiTiet.Size = new Size(960, 290);
            pnlChiTiet.TabIndex = 5;
            pnlChiTiet.Visible = false;
            // 
            // lblTieuDeChiTiet
            // 
            lblTieuDeChiTiet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTieuDeChiTiet.ForeColor = Color.DarkGreen;
            lblTieuDeChiTiet.Location = new Point(10, 10);
            lblTieuDeChiTiet.Name = "lblTieuDeChiTiet";
            lblTieuDeChiTiet.Size = new Size(600, 28);
            lblTieuDeChiTiet.TabIndex = 0;
            lblTieuDeChiTiet.Text = "THONG TIN CHI TIET LO HANG";
            // 
            // lblChiTietMaLo
            // 
            lblChiTietMaLo.Font = new Font("Segoe UI", 10F);
            lblChiTietMaLo.Location = new Point(15, 48);
            lblChiTietMaLo.Name = "lblChiTietMaLo";
            lblChiTietMaLo.Size = new Size(450, 26);
            lblChiTietMaLo.TabIndex = 1;
            // 
            // lblChiTietTenLo
            // 
            lblChiTietTenLo.Font = new Font("Segoe UI", 10F);
            lblChiTietTenLo.Location = new Point(15, 82);
            lblChiTietTenLo.Name = "lblChiTietTenLo";
            lblChiTietTenLo.Size = new Size(450, 26);
            lblChiTietTenLo.TabIndex = 2;
            // 
            // lblChiTietSanPham
            // 
            lblChiTietSanPham.Font = new Font("Segoe UI", 10F);
            lblChiTietSanPham.Location = new Point(15, 116);
            lblChiTietSanPham.Name = "lblChiTietSanPham";
            lblChiTietSanPham.Size = new Size(450, 26);
            lblChiTietSanPham.TabIndex = 3;
            // 
            // lblChiTietSoLuong
            // 
            lblChiTietSoLuong.Font = new Font("Segoe UI", 10F);
            lblChiTietSoLuong.Location = new Point(15, 150);
            lblChiTietSoLuong.Name = "lblChiTietSoLuong";
            lblChiTietSoLuong.Size = new Size(450, 26);
            lblChiTietSoLuong.TabIndex = 4;
            // 
            // lblChiTietNguonGoc
            // 
            lblChiTietNguonGoc.Font = new Font("Segoe UI", 10F);
            lblChiTietNguonGoc.Location = new Point(15, 184);
            lblChiTietNguonGoc.Name = "lblChiTietNguonGoc";
            lblChiTietNguonGoc.Size = new Size(450, 26);
            lblChiTietNguonGoc.TabIndex = 5;
            // 
            // lblChiTietGhiChu
            // 
            lblChiTietGhiChu.Font = new Font("Segoe UI", 10F);
            lblChiTietGhiChu.Location = new Point(15, 252);
            lblChiTietGhiChu.Name = "lblChiTietGhiChu";
            lblChiTietGhiChu.Size = new Size(900, 26);
            lblChiTietGhiChu.TabIndex = 11;
            // 
            // lblChiTietNgayNhap
            // 
            lblChiTietNgayNhap.Font = new Font("Segoe UI", 10F);
            lblChiTietNgayNhap.Location = new Point(490, 48);
            lblChiTietNgayNhap.Name = "lblChiTietNgayNhap";
            lblChiTietNgayNhap.Size = new Size(450, 26);
            lblChiTietNgayNhap.TabIndex = 6;
            // 
            // lblChiTietNgayMua
            // 
            lblChiTietNgayMua.Font = new Font("Segoe UI", 10F);
            lblChiTietNgayMua.Location = new Point(490, 82);
            lblChiTietNgayMua.Name = "lblChiTietNgayMua";
            lblChiTietNgayMua.Size = new Size(450, 26);
            lblChiTietNgayMua.TabIndex = 7;
            // 
            // lblChiTietTrangThai
            // 
            lblChiTietTrangThai.Font = new Font("Segoe UI", 10F);
            lblChiTietTrangThai.Location = new Point(490, 116);
            lblChiTietTrangThai.Name = "lblChiTietTrangThai";
            lblChiTietTrangThai.Size = new Size(450, 26);
            lblChiTietTrangThai.TabIndex = 8;
            // 
            // lblChiTietLienHe
            // 
            lblChiTietLienHe.Font = new Font("Segoe UI", 10F);
            lblChiTietLienHe.Location = new Point(490, 150);
            lblChiTietLienHe.Name = "lblChiTietLienHe";
            lblChiTietLienHe.Size = new Size(450, 26);
            lblChiTietLienHe.TabIndex = 9;
            // 
            // lblChiTietMaPN
            // 
            lblChiTietMaPN.Font = new Font("Segoe UI", 10F);
            lblChiTietMaPN.Location = new Point(490, 184);
            lblChiTietMaPN.Name = "lblChiTietMaPN";
            lblChiTietMaPN.Size = new Size(450, 26);
            lblChiTietMaPN.TabIndex = 10;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.Gray;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 10F);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(880, 650);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(100, 34);
            btnDong.TabIndex = 6;
            btnDong.Text = "Dong";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(641, 49);
            button1.Name = "button1";
            button1.Size = new Size(147, 41);
            button1.TabIndex = 7;
            button1.Text = "Xuất mã QR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += onInitQRExport;
            // 
            // FormTraCuuLo
            // 
            BackColor = Color.MistyRose;
            ClientSize = new Size(1000, 690);
            Controls.Add(button1);
            Controls.Add(lblHuongDan);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(lblKetQua);
            Controls.Add(dgvKetQua);
            Controls.Add(pnlChiTiet);
            Controls.Add(btnDong);
            Font = new Font("Segoe UI", 10F);
            Name = "FormTraCuuLo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tra Cứu Lô Hàng - Eco Farm";
            Load += FormTraCuuLo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            pnlChiTiet.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label lblKetQua;
        private Label lblHuongDan;
        private DataGridView dgvKetQua;
        private Panel pnlChiTiet;
        private Label lblTieuDeChiTiet;
        private Label lblChiTietMaLo;
        private Label lblChiTietTenLo;
        private Label lblChiTietSanPham;
        private Label lblChiTietSoLuong;
        private Label lblChiTietNguonGoc;
        private Label lblChiTietNgayNhap;
        private Label lblChiTietNgayMua;
        private Label lblChiTietTrangThai;
        private Label lblChiTietLienHe;
        private Label lblChiTietMaPN;
        private Label lblChiTietGhiChu;
        private Button btnDong;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}