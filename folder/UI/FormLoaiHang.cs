using QLNongSan.Repositories;
using QLNongSan.schemas;
using System;
using System.Windows.Forms;

namespace QLNongSan.UI
{
    public partial class FormLoaiHang : Form
    {
        private readonly Application application;

        public FormLoaiHang(Application application)
        {
            this.application = application;
            InitializeComponent();
        }

        private void FormLoaiHang_Load(object sender, EventArgs e)
        {
            HienThiData();
        }

        private void HienThiData()
        {
            try
            {
                dgvLoaiHang.DataSource = application.categoryRepository.GetListLoaiHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách loại hàng: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiHangDTO lh = new LoaiHangDTO();
                lh.MaLoai = txtMaLoai.Text.Trim();
                lh.TenLoai = txtTenLoai.Text.Trim();

                string ketQua = application.categoryRepository.AddLoaiHang(lh);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Thêm loại hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiData();
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiHangDTO lh = new LoaiHangDTO();
                lh.MaLoai = txtMaLoai.Text.Trim();
                lh.TenLoai = txtTenLoai.Text.Trim();

                string ketQua = application.categoryRepository.UpdateLoaiHang(lh);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Sửa loại hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiData();
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maLoai = txtMaLoai.Text.Trim();
                    string ketQua = application.categoryRepository.DeleteLoaiHang(maLoai);

                    if (ketQua == "SUCCESS")
                    {
                        MessageBox.Show("Xóa loại hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiData();
                        btnLamMoi.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtMaLoai.Focus();
        }

        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiHang.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaLoai"].Value?.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString();
            }
        }
    }
}
