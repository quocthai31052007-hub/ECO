namespace QLNongSan.UI
{
    partial class FormUserKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserKhachHang));
            button3 = new Button();
            button2 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(1338, 38);
            button3.Name = "button3";
            button3.Size = new Size(387, 71);
            button3.TabIndex = 2;
            button3.Text = "Điều khoản & dịch vụ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDieuKhoan_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(1044, 38);
            button2.Name = "button2";
            button2.Size = new Size(202, 71);
            button2.TabIndex = 3;
            button2.Text = "Tra cứu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += onInitLookupClick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20F);
            button8.ForeColor = Color.Navy;
            button8.Location = new Point(764, 38);
            button8.Name = "button8";
            button8.Size = new Size(156, 71);
            button8.TabIndex = 7;
            button8.Text = "Trở Lại";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnTroLai_Click;
            // 
            // FormUserKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button3);
            DoubleBuffered = true;
            Name = "FormUserKhachHang";
            Text = "Form1";
            Load += FormKhachHang_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button2;
        private Button button3;
        private void btnDieuKhoan_Click(object sender, EventArgs e)
        {
            string tieuDe = "ĐIỀU KHOẢN DỊCH VỤ NGƯỜI DÙNG - ECO FARM";

            string noiDung = "Chào mừng bạn đến với Eco Farm. Bằng việc truy cập và sử dụng các tính năng tra cứu, bạn đồng ý chịu sự ràng buộc bởi các điều khoản dưới đây:\n\n" +
                             "1. PHÂN QUYỀN TRUY CẬP\n" +
                             "- Khách hàng được quyền tự do tra cứu dữ liệu lô hàng nông sản (Mã lô, nguồn gốc, ngày nhập kho) công khai.\n" +
                             "- Quyền quản trị và chỉnh sửa hệ thống được bảo mật nghiêm ngặt bằng tài khoản Admin/Nhân viên.\n\n" +
                             "2. QUY ĐỊNH TRA CỨU & MÃ QR\n" +
                             "- Mã QR phát hành chứa thông tin định danh trực tiếp liên kết dữ liệu thời gian thực của lô hàng.\n" +
                             "- Nghiêm cấm hành vi sao chép, giả mạo thông tin mã QR, hoặc sử dụng công cụ spam tự động gửi yêu cầu liên tục làm nghẽn máy chủ.\n\n" +
                             "3. MIỄN TRỪ TRÁCH NHIỆM\n" +
                             "- Hệ thống cam kết dữ liệu được minh bạch hóa tối đa từ bộ phận kho, tuy nhiên được miễn trừ trách nhiệm pháp lý với các lỗi nhập liệu thủ công từ nhà cung cấp.\n\n" +
                             "4. BẢO MẬT\n" +
                             "- Ứng dụng tôn trọng quyền riêng tư và không thu thập bất kỳ thông tin cá nhân nào của khách hàng khi thực hiện quét mã QR tra cứu.";

            MessageBox.Show(noiDung, tieuDe, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Button button8;
    }
}