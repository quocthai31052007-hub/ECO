namespace QLNongSan.UI
{
    partial class FormBanHang
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
            pnlContent = new Panel();
            textBox6 = new TextBox();
            label21 = new Label();
            label20 = new Label();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            groupBox2 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlContent.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackgroundImage = Properties.Resources.Untitled;
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.Controls.Add(textBox6);
            pnlContent.Controls.Add(label21);
            pnlContent.Controls.Add(label20);
            pnlContent.Controls.Add(button13);
            pnlContent.Controls.Add(button12);
            pnlContent.Controls.Add(button11);
            pnlContent.Controls.Add(groupBox3);
            pnlContent.Controls.Add(label6);
            pnlContent.Controls.Add(groupBox2);
            pnlContent.Controls.Add(groupBox1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1902, 1033);
            pnlContent.TabIndex = 14;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Gray;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Font = new Font("Segoe UI", 20F);
            textBox6.Location = new Point(1159, 849);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(377, 45);
            textBox6.TabIndex = 30;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1470, 911);
            label21.Name = "label21";
            label21.Size = new Size(0, 20);
            label21.TabIndex = 29;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label20.ForeColor = Color.White;
            label20.Location = new Point(801, 848);
            label20.Name = "label20";
            label20.Size = new Size(352, 46);
            label20.TabIndex = 13;
            label20.Text = "TỔNG THANH TOÁN:";
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(192, 255, 192);
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.Font = new Font("Segoe UI", 16F);
            button13.ForeColor = Color.Black;
            button13.Location = new Point(961, 911);
            button13.Name = "button13";
            button13.Size = new Size(321, 49);
            button13.TabIndex = 26;
            button13.Text = "☎ LƯU PHIẾU BÁN";
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Red;
            button12.BackgroundImageLayout = ImageLayout.None;
            button12.Font = new Font("Segoe UI", 16F);
            button12.ForeColor = Color.Black;
            button12.Location = new Point(1349, 911);
            button12.Name = "button12";
            button12.Size = new Size(246, 49);
            button12.TabIndex = 25;
            button12.Text = "🗑️ HỦY PHIẾU";
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(0, 192, 192);
            button11.BackgroundImageLayout = ImageLayout.None;
            button11.Font = new Font("Segoe UI", 16F);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(421, 911);
            button11.Name = "button11";
            button11.Size = new Size(456, 49);
            button11.TabIndex = 24;
            button11.Text = "\U0001f6d2THANH TOÁN & IN HÓA ĐƠN";
            button11.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 16F);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(104, 508);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1491, 327);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách chi tiết phiếu bán hiện tại";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1485, 285);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã SP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "ĐVT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá bán";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Số lượng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Chiết khấu (%)";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Thành tiền";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(622, 16);
            label6.Name = "label6";
            label6.Size = new Size(436, 54);
            label6.TabIndex = 13;
            label6.Text = "LẬP PHIẾU BÁN HÀNG";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Font = new Font("Segoe UI", 16F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(104, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1491, 197);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(192, 255, 192);
            button10.Font = new Font("Segoe UI", 12F);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(1366, 111);
            button10.Name = "button10";
            button10.Size = new Size(102, 49);
            button10.TabIndex = 26;
            button10.Text = "Làm mới";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(192, 255, 192);
            button9.Font = new Font("Segoe UI", 12F);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(1223, 111);
            button9.Name = "button9";
            button9.Size = new Size(101, 49);
            button9.TabIndex = 25;
            button9.Text = "Sửa";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 128);
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(1366, 31);
            button8.Name = "button8";
            button8.Size = new Size(102, 49);
            button8.TabIndex = 24;
            button8.Text = "Xóa";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 255, 192);
            button7.Font = new Font("Segoe UI", 12F);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(1223, 31);
            button7.Name = "button7";
            button7.Size = new Size(101, 49);
            button7.TabIndex = 23;
            button7.Text = "Thêm";
            button7.UseVisualStyleBackColor = false;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 12F);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(385, 124);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(170, 36);
            comboBox5.TabIndex = 22;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 12F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(32, 124);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(314, 36);
            comboBox4.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F);
            label16.Location = new Point(813, 68);
            label16.Name = "label16";
            label16.Size = new Size(115, 32);
            label16.TabIndex = 19;
            label16.Text = "Số lượng:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F);
            label15.Location = new Point(1003, 68);
            label15.Name = "label15";
            label15.Size = new Size(175, 32);
            label15.TabIndex = 18;
            label15.Text = "Chiết khấu (%):";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F);
            label14.Location = new Point(593, 59);
            label14.Name = "label14";
            label14.Size = new Size(100, 32);
            label14.TabIndex = 17;
            label14.Text = "Giá bán:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F);
            label13.Location = new Point(385, 59);
            label13.Name = "label13";
            label13.Size = new Size(138, 32);
            label13.TabIndex = 16;
            label13.Text = "Đơn vị tính:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F);
            label12.Location = new Point(32, 59);
            label12.Name = "label12";
            label12.Size = new Size(126, 32);
            label12.TabIndex = 15;
            label12.Text = "Sản phẩm:";
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(813, 124);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(149, 34);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(1003, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 34);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(593, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 34);
            textBox3.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(104, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1491, 197);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu bán";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1194, 114);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(274, 36);
            comboBox3.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(641, 114);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(287, 36);
            comboBox2.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(289, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 36);
            comboBox1.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(961, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 34);
            dateTimePicker1.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(961, 61);
            label11.Name = "label11";
            label11.Size = new Size(122, 32);
            label11.TabIndex = 18;
            label11.Text = "Ngày bán:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(1194, 61);
            label10.Name = "label10";
            label10.Size = new Size(189, 32);
            label10.TabIndex = 17;
            label10.Text = "Phương thức TT:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(641, 61);
            label9.Name = "label9";
            label9.Size = new Size(176, 32);
            label9.TabIndex = 16;
            label9.Text = "Nhân viên bán:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(289, 61);
            label8.Name = "label8";
            label8.Size = new Size(145, 32);
            label8.TabIndex = 15;
            label8.Text = "Khách hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(32, 61);
            label7.Name = "label7";
            label7.Size = new Size(87, 32);
            label7.TabIndex = 14;
            label7.Text = "Mã PB:";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(32, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 34);
            textBox2.TabIndex = 12;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlContent);
            Name = "FormBanHang";
            Text = "Form6";
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlContent;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private Button button7;
        private Button button10;
        private Button button9;
        private Button button8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button button11;
        private Button button13;
        private Button button12;
        private Label label21;
        private Label label20;
        private TextBox textBox6;
    }
}
