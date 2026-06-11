using System;
using System.Windows.Forms;
using QLNongSan.repositories;
using QLNongSan.schemas;

namespace QLNongSan.UI
{
    public partial class FormNhanVien : Form
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            HienThiData();
        }

        private void HienThiData()
        {
            try
            {
                dgvNhanVien.Columns.Clear();
                dgvNhanVien.AutoGenerateColumns = true;
                dgvNhanVien.DataSource = nhanVienDAL.GetListNhanVien();
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvNhanVien.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private NhanVienDTO LayDuLieuForm()
        {
            return new NhanVienDTO
            {
                MaNV = txtMaNV.Text.Trim(),
                TenNV = txtTenNV.Text.Trim(),
                ChucVu = cboChucVu.Text.Trim()
            };
        }

        private void LamMoiForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            cboChucVu.SelectedIndex = -1;
            txtMaNV.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = LayDuLieuForm();
            string ketQua = nhanVienDAL.AddNhanVien(nv);
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData();
                LamMoiForm();
            }
            else
                MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = LayDuLieuForm();
            string ketQua = nhanVienDAL.UpdateNhanVien(nv);
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData();
                LamMoiForm();
            }
            else
                MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Hãy chọn nhân viên từ bảng!", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string ketQua = nhanVienDAL.DeleteNhanVien(txtMaNV.Text.Trim());
                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiData();
                    LamMoiForm();
                }
                else
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e) => LamMoiForm();

        // Các handler giữ lại để Designer không lỗi
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtTenNV.Text = row.Cells["HoTen"].Value?.ToString();
                cboChucVu.Text = row.Cells["VaiTro"].Value?.ToString();
            }
        }
    }
}