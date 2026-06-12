namespace QLNongSan.UI
{
    partial class FormKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            lblTitle = new Label();
            grpThongTin = new GroupBox();
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            pnlButtons = new Panel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpDanhSach = new GroupBox();
            dgvKhachHang = new DataGridView();
            pnlMain.SuspendLayout();
            grpThongTin.SuspendLayout();
            pnlButtons.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(34, 45, 50);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(grpThongTin);
            pnlMain.Controls.Add(pnlButtons);
            pnlMain.Controls.Add(grpDanhSach);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1280, 800);
            pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 230, 180);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(439, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // grpThongTin
            // 
            grpThongTin.BackColor = Color.FromArgb(44, 62, 70);
            grpThongTin.Controls.Add(lblMaKH);
            grpThongTin.Controls.Add(txtMaKH);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblSDT);
            grpThongTin.Controls.Add(txtSDT);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(txtEmail);
            grpThongTin.Controls.Add(lblGhiChu);
            grpThongTin.Controls.Add(txtGhiChu);
            grpThongTin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            grpThongTin.ForeColor = Color.White;
            grpThongTin.Location = new Point(30, 70);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1200, 220);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin khách hàng";
            // 
            // lblMaKH
            // 
            lblMaKH.Location = new Point(317, 109);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(100, 23);
            lblMaKH.TabIndex = 0;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(115, 80);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(100, 36);
            txtMaKH.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(0, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(250, 54);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(100, 36);
            txtHoTen.TabIndex = 3;
            // 
            // lblSDT
            // 
            lblSDT.Location = new Point(0, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(100, 23);
            lblSDT.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(-18, 109);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(100, 36);
            txtSDT.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(0, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 23);
            lblDiaChi.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(382, 45);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(100, 36);
            txtDiaChi.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(504, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 36);
            txtEmail.TabIndex = 9;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Location = new Point(0, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(100, 23);
            lblGhiChu.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(317, 124);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(100, 36);
            txtGhiChu.TabIndex = 11;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.Transparent;
            pnlButtons.Controls.Add(btnThem);
            pnlButtons.Controls.Add(btnSua);
            pnlButtons.Controls.Add(btnXoa);
            pnlButtons.Controls.Add(btnLamMoi);
            pnlButtons.Location = new Point(30, 305);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1200, 60);
            pnlButtons.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(0, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 0;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 1;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(0, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 2;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(0, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.BackColor = Color.FromArgb(44, 62, 70);
            grpDanhSach.Controls.Add(dgvKhachHang);
            grpDanhSach.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            grpDanhSach.ForeColor = Color.White;
            grpDanhSach.Location = new Point(30, 380);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1200, 380);
            grpDanhSach.TabIndex = 3;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.FromArgb(34, 45, 50);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 100);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 180, 120);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.GridColor = Color.FromArgb(60, 80, 90);
            dgvKhachHang.Location = new Point(3, 32);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1194, 345);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 45, 50);
            ClientSize = new Size(1280, 800);
            Controls.Add(pnlMain);
            DoubleBuffered = true;
            Name = "FormKhachHang";
            Text = "Quản lý khách hàng";
            Load += FormKhachHang_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            pnlButtons.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        private void SetLabel(Label lbl, string text, int x, int y)
        {
            lbl.Text = text; lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 13F);
            lbl.ForeColor = Color.FromArgb(180, 220, 210);
            lbl.Location = new Point(x, y);
        }

        private void SetText(TextBox txt, int x, int y, int w)
        {
            txt.Font = new Font("Segoe UI", 13F);
            txt.Location = new Point(x, y);
            txt.Size = new Size(w, 36);
            txt.BackColor = Color.FromArgb(55, 75, 85);
            txt.ForeColor = Color.White;
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        private void SetButton(Button btn, string text, int x, Color color)
        {
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn.Location = new Point(x, 8);
            btn.Size = new Size(190, 45);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

#pragma warning disable CS0649
        private Panel pnlMain;
        private Label lblTitle;
        private GroupBox grpThongTin, grpDanhSach;
        private Panel pnlButtons;
        private Label lblMaKH, lblHoTen, lblSDT, lblDiaChi, lblEmail, lblGhiChu;
        private TextBox txtMaKH, txtHoTen, txtSDT, txtDiaChi, txtEmail, txtGhiChu;
        private Button btnThem, btnSua, btnXoa, btnLamMoi;
        private DataGridView dgvKhachHang;
#pragma warning restore CS0649
    }
}