
namespace QLNongSan.UI
{
    partial class FormNhapHang
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
            pnlContent = new Panel();
            button15 = new Button();
            button14 = new Button();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            a = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            label13 = new Label();
            button7 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            comboBox4 = new ComboBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            pnlContent.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSanPham
            // 
            dgvSanPham.BackgroundColor = Color.DimGray;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 0);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(1902, 1033);
            dgvSanPham.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.BackgroundImage = Properties.Resources.Untitled;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Controls.Add(button15);
            pnlContent.Controls.Add(button14);
            pnlContent.Controls.Add(groupBox3);
            pnlContent.Controls.Add(groupBox2);
            pnlContent.Controls.Add(groupBox1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1902, 1033);
            pnlContent.TabIndex = 14;
            // 
            // button15
            // 
            button15.BackColor = Color.Red;
            button15.Font = new Font("Segoe UI", 16F);
            button15.Location = new Point(1348, 925);
            button15.Name = "button15";
            button15.Size = new Size(202, 42);
            button15.TabIndex = 12;
            button15.Text = "HỦY PHIẾU";
            button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(192, 255, 192);
            button14.Font = new Font("Segoe UI", 16F);
            button14.Location = new Point(1079, 925);
            button14.Name = "button14";
            button14.Size = new Size(213, 42);
            button14.TabIndex = 12;
            button14.Text = "LƯU PHIẾU NHẬP";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Font = new Font("Segoe UI", 16F);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(87, 529);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1491, 371);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách chi tiết phiếu nhập hiện tại";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowDrop = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { a, Column1, Column2, Column3, Column4, Column5 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Location = new Point(3, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1485, 329);
            dataGridView2.TabIndex = 12;
            // 
            // a
            // 
            a.HeaderText = "Mã PN";
            a.MinimumWidth = 6;
            a.Name = "a";
            a.ReadOnly = true;
            a.Resizable = DataGridViewTriState.True;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Sản Phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số Lượng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giá Nhập";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Hạn SD";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Thành Tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Font = new Font("Segoe UI", 16F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(87, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1491, 237);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết Sản phẩm nhập";
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(192, 255, 192);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(1186, 137);
            button10.Name = "button10";
            button10.Size = new Size(138, 40);
            button10.TabIndex = 11;
            button10.Text = "Làm mới";
            button10.UseVisualStyleBackColor = false;
            button10.UseWaitCursor = true;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(192, 255, 192);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(932, 137);
            button9.Name = "button9";
            button9.Size = new Size(138, 40);
            button9.TabIndex = 10;
            button9.Text = "Sửa ";
            button9.UseVisualStyleBackColor = false;
            button9.UseWaitCursor = true;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 128);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(1186, 62);
            button8.Name = "button8";
            button8.Size = new Size(138, 40);
            button8.TabIndex = 9;
            button8.Text = "Xóa";
            button8.UseVisualStyleBackColor = false;
            button8.UseWaitCursor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F);
            label13.Location = new Point(403, 146);
            label13.Name = "label13";
            label13.Size = new Size(156, 32);
            label13.TabIndex = 8;
            label13.Text = "Hạn sử dụng:";
            label13.Click += label13_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 255, 192);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(932, 59);
            button7.Name = "button7";
            button7.Size = new Size(138, 40);
            button7.TabIndex = 7;
            button7.Text = "Thêm ";
            button7.UseVisualStyleBackColor = false;
            button7.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F);
            label12.Location = new Point(403, 62);
            label12.Name = "label12";
            label12.Size = new Size(120, 32);
            label12.TabIndex = 6;
            label12.Text = "Số Lượng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(18, 149);
            label11.Name = "label11";
            label11.Size = new Size(118, 32);
            label11.TabIndex = 5;
            label11.Text = "Giá Nhập:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(18, 62);
            label10.Name = "label10";
            label10.Size = new Size(125, 32);
            label10.TabIndex = 4;
            label10.Text = "Sản Phẩm:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker2.Font = new Font("Segoe UI", 12F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(565, 146);
            dateTimePicker2.MaxDate = new DateTime(2027, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1945, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 34);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(153, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 34);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(565, 62);
            textBox3.MaxLength = 327;
            textBox3.Name = "textBox3";
            textBox3.ShortcutsEnabled = false;
            textBox3.Size = new Size(250, 34);
            textBox3.TabIndex = 1;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 12F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(153, 54);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(207, 36);
            comboBox4.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(87, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1491, 229);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phiếu Nhập ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(951, 55);
            label9.Name = "label9";
            label9.Size = new Size(105, 32);
            label9.TabIndex = 13;
            label9.Text = "Ghi Chú:";
            // 
            // textBox2
            // 
            textBox2.AllowDrop = true;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(951, 87);
            textBox2.MaxLength = 500;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(512, 98);
            textBox2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(403, 55);
            label8.Name = "label8";
            label8.Size = new Size(132, 32);
            label8.TabIndex = 1;
            label8.Text = "Nhân Viên:";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(403, 148);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(488, 36);
            comboBox3.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 6F);
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(153, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 34);
            dateTimePicker1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(18, 151);
            label7.Name = "label7";
            label7.Size = new Size(140, 32);
            label7.TabIndex = 0;
            label7.Text = "Ngày Nhập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(18, 56);
            label6.Name = "label6";
            label6.Size = new Size(91, 32);
            label6.TabIndex = 1;
            label6.Text = "Mã PN:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(153, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 0;
            // 
            // FormNhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlContent);
            Controls.Add(dgvSanPham);
            Name = "FormNhapHang";
            Text = "Form6";
            Load += FormNhapHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            pnlContent.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSanPham;
        private Panel pnlContent;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox4;
        private TextBox textBox3;
        private ComboBox comboBox4;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button7;
        private Label label13;
        private Button button10;
        private Button button9;
        private Button button8;
        private DataGridView dataGridView2;
        private Button button14;
        private Button button15;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}