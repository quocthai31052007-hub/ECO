using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace QLNongSan.UI
{
    public partial class FormNhapTraCuu : Form
    {
        public required Application application;
        public required Action<string> onSubmit;

        public FormNhapTraCuu()
        {
            InitializeComponent();
        }

        private void onIdSubmitClick(object sender, EventArgs e)
        {
            string input = idInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            onSubmit(input);
            Close();
        }

        private void onQRRequestClick(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
            };
            fileDialog.ShowDialog();
            var fileName = fileDialog.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Vui lòng chọn một file ảnh để quét mã QR.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var data = application.lookupQRService.ProcessQRFile(fileName);
            var id = data["id"];
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Mã QR không chứa thông tin cần tra cứu. Vui lòng thử lại với một mã QR khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            onSubmit(id);
            Close();
            return;
        }

        private void FormNhapTraCuu_Load(object sender, EventArgs e)
        {

        }
    }
}