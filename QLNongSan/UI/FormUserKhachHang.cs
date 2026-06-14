using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QRCoder;

namespace QLNongSan.UI
{
    public partial class FormUserKhachHang : Form
    {
        private readonly Application application;
        private string? currentLookupId = null;

        public FormUserKhachHang(Application application)
        {
            this.application = application;
            InitializeComponent();
        }

        private void onInitQRExport(object sender, EventArgs e)
        {
            //if (currentLookupId == null)
            //{
            //    return;
            //}
            //var fileDialog = new SaveFileDialog
            //{
            //    Filter = "*.png"
            //};
            //fileDialog.ShowDialog();
            //var fileName = fileDialog.FileName;
            //if (string.IsNullOrEmpty(fileName))
            //{
            //    MessageBox.Show("Vui lòng chọn một file ảnh để xuất mã QR.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //var dict = new Dictionary<string, string>
            //{
            //    { "id", currentLookupId }
            //};
            //this.application.lookupQRService.CreateQRFile(dict, fileName);
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void onLookupIdChange(string id)
        { 
            //Console.WriteLine("Tra cứu thông tin với ID: " + id);
            //var data = application.batchRepository.GetById(id);
            //if (data == null) { 
            //    MessageBox.Show("Không tìm thấy thông tin với ID đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //currentLookupId = data!.MaLo;
            //// Hiển thị thông tin chi tiết của lô hàng
            //return;
        }

        private void onInitLookupClick(object sender, EventArgs e)
        {
            var form = new FormTraCuuLo(this.application);
            form.ShowDialog();
        }


        private void btnTroLai_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
