namespace QLNongSan.UI
{
    partial class FormNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvNhanVien = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            cboTrangThai = new ComboBox();
            label8 = new Label();
            cboHopDong = new ComboBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            cboChucVu = new ComboBox();
            cboGioiTinh = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSDT = new TextBox();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dgvNhanVien);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboHopDong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 16.2F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(160, 27);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1340, 780);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(56, 377);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.Size = new Size(1196, 359);
            dgvNhanVien.TabIndex = 23;
            dgvNhanVien.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 192);
            button4.Font = new Font("Segoe UI", 14F);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(1060, 297);
            button4.Name = "button4";
            button4.Size = new Size(130, 45);
            button4.TabIndex = 4;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(875, 297);
            button3.Name = "button3";
            button3.Size = new Size(130, 45);
            button3.TabIndex = 3;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(689, 297);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 2;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(507, 297);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(40, 300);
            label9.Name = "label9";
            label9.Size = new Size(125, 32);
            label9.TabIndex = 5;
            label9.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 14F);
            cboTrangThai.Items.AddRange(new object[] { "Đang làm", "Nghỉ việc", "Tạm nghỉ" });
            cboTrangThai.Location = new Point(220, 297);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(200, 39);
            cboTrangThai.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(480, 240);
            label8.Name = "label8";
            label8.Size = new Size(127, 32);
            label8.TabIndex = 7;
            label8.Text = "Hợp đồng:";
            // 
            // cboHopDong
            // 
            cboHopDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHopDong.Font = new Font("Segoe UI", 14F);
            cboHopDong.Items.AddRange(new object[] { "Thử việc", "Chính thức", "Thời vụ" });
            cboHopDong.Location = new Point(660, 237);
            cboHopDong.Name = "cboHopDong";
            cboHopDong.Size = new Size(250, 39);
            cboHopDong.TabIndex = 8;
            cboHopDong.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(40, 240);
            label7.Name = "label7";
            label7.Size = new Size(106, 32);
            label7.TabIndex = 9;
            label7.Text = "Chức vụ:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(660, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 39);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(480, 180);
            label6.Name = "label6";
            label6.Size = new Size(76, 32);
            label6.TabIndex = 11;
            label6.Text = "Email:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 14F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(660, 117);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 39);
            dtpNgaySinh.TabIndex = 12;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(40, 180);
            label5.Name = "label5";
            label5.Size = new Size(161, 32);
            label5.TabIndex = 13;
            label5.Text = "Số điện thoại:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(480, 120);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 14;
            label4.Text = "Ngày sinh:";
            label4.Click += label4_Click;
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.Font = new Font("Segoe UI", 14F);
            cboChucVu.Items.AddRange(new object[] { "Quản lý", "Nhân viên bán hàng", "Kế toán", "Thủ kho" });
            cboChucVu.Location = new Point(220, 237);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(200, 39);
            cboChucVu.TabIndex = 15;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 14F);
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(220, 117);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(200, 39);
            cboGioiTinh.TabIndex = 16;
            cboGioiTinh.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(40, 120);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 17;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(480, 60);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 18;
            label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 19;
            label1.Text = "Mã nhân viên:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 14F);
            txtSDT.Location = new Point(220, 177);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 39);
            txtSDT.TabIndex = 20;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 14F);
            txtMaNV.Location = new Point(220, 57);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(200, 39);
            txtMaNV.TabIndex = 21;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Segoe UI", 14F);
            txtTenNV.Location = new Point(660, 57);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(250, 39);
            txtTenNV.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(980, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(40, 630);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1260, 120);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã NV";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên NV";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày sinh";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "SDT";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.HeaderText = "Email";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 180;
            // 
            // Column7
            // 
            Column7.HeaderText = "Chức vụ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 140;
            // 
            // Column8
            // 
            Column8.HeaderText = "Hợp đồng";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 120;
            // 
            // Column9
            // 
            Column9.HeaderText = "Trạng thái";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 120;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.Untitled;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1835, 860);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = Color.White;
            Name = "FormNhanVien";
            Text = "Quản lý nhân viên";
            Load += FormNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1, button2, button3, button4;
        private Label label1, label2, label3, label4, label5, label6, label7, label8, label9;
        private TextBox txtMaNV, txtTenNV, txtSDT, txtEmail;
        private ComboBox cboGioiTinh, cboChucVu, cboHopDong, cboTrangThai;
        private DateTimePicker dtpNgaySinh;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1, Column2, Column3, Column4, Column5;
        private DataGridViewTextBoxColumn Column6, Column7, Column8, Column9;
        private DataGridView dgvNhanVien;
    }
}