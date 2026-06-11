using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLNongSan.repositories;
using QLNongSan.schemas;

namespace QLNongSan.UI
{
    public partial class FormNhapHang : Form
    {
        private NhapHangDAL dal = new NhapHangDAL();
        private DataTable dtChiTiet;          // bảng tạm lưu chi tiết phiếu nhập
        private string maPNDangNhap;           // mã phiếu nhập hiện tại

        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            // Khởi tạo DataTable cho chi tiết
            dtChiTiet = new DataTable();
            dtChiTiet.Columns.Add("MaSP", typeof(string));
            dtChiTiet.Columns.Add("TenSP", typeof(string));
            dtChiTiet.Columns.Add("SoLuong", typeof(int));
            dtChiTiet.Columns.Add("GiaNhap", typeof(decimal));
            dtChiTiet.Columns.Add("HanSuDung", typeof(DateTime));
            dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));
            dataGridView2.DataSource = dtChiTiet;

            // Load combobox sản phẩm
            var spList = dal.GetSanPhamList();
            comboBox4.DataSource = spList;
            comboBox4.DisplayMember = "TenSP";
            comboBox4.ValueMember = "MaSP";

            // Load combobox nhân viên
            var nvList = dal.GetNhanVienList();
            comboBox3.DataSource = nvList;
            comboBox3.DisplayMember = "TenNV";
            comboBox3.ValueMember = "MaNV";

            // Tạo mã phiếu nhập mới
            maPNDangNhap = dal.TaoMaPhieuNhap();
            textBox1.Text = maPNDangNhap;
            dateTimePicker1.Value = DateTime.Now;
        }

        // Nút Thêm chi tiết sản phẩm
        private void button7_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (comboBox4.SelectedValue == null)
            {
                MessageBox.Show("Chọn sản phẩm!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !int.TryParse(textBox3.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text) || !decimal.TryParse(textBox4.Text, out decimal giaNhap) || giaNhap <= 0)
            {
                MessageBox.Show("Giá nhập phải là số dương!");
                return;
            }

            string maSP = comboBox4.SelectedValue.ToString();
            string tenSP = comboBox4.Text;
            DateTime hanSD = dateTimePicker2.Value;

            // Kiểm tra trùng sản phẩm trong phiếu tạm? Có thể cập nhật số lượng
            DataRow[] existing = dtChiTiet.Select($"MaSP = '{maSP}'");
            if (existing.Length > 0)
            {
                // Nếu đã có thì cộng dồn số lượng
                int oldSL = Convert.ToInt32(existing[0]["SoLuong"]);
                existing[0]["SoLuong"] = oldSL + soLuong;
                existing[0]["ThanhTien"] = (oldSL + soLuong) * giaNhap;
            }
            else
            {
                DataRow row = dtChiTiet.NewRow();
                row["MaSP"] = maSP;
                row["TenSP"] = tenSP;
                row["SoLuong"] = soLuong;
                row["GiaNhap"] = giaNhap;
                row["HanSuDung"] = hanSD;
                row["ThanhTien"] = soLuong * giaNhap;
                dtChiTiet.Rows.Add(row);
            }

            // Xóa các ô nhập sau khi thêm
            textBox3.Clear();
            textBox4.Clear();
            comboBox4.SelectedIndex = -1;
            dateTimePicker2.Value = DateTime.Now;
        }

        // Nút Sửa dòng đang chọn
        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;
            DataRowView rowView = (DataRowView)dataGridView2.CurrentRow.DataBoundItem;
            DataRow row = rowView.Row;

            // Đưa thông tin lên các ô nhập để sửa
            comboBox4.SelectedValue = row["MaSP"].ToString();
            textBox3.Text = row["SoLuong"].ToString();
            textBox4.Text = row["GiaNhap"].ToString();
            dateTimePicker2.Value = Convert.ToDateTime(row["HanSuDung"]);

            // Xóa dòng cũ (sau khi sửa sẽ thêm mới lại)
            dtChiTiet.Rows.Remove(row);
        }

        // Nút Xóa dòng đang chọn
        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;
            DataRowView rowView = (DataRowView)dataGridView2.CurrentRow.DataBoundItem;
            dtChiTiet.Rows.Remove(rowView.Row);
        }

        // Nút Làm mới các ô nhập
        private void button10_Click(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = -1;
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker2.Value = DateTime.Now;
        }

        // Nút Lưu phiếu nhập
        private void button14_Click_1(object sender, EventArgs e)
        {
            if (dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong phiếu nhập!");
                return;
            }

            // Tạo đối tượng Phiếu nhập
            PhieuNhapDTO pn = new PhieuNhapDTO
            {
                MaPN = maPNDangNhap,
                NgayNhap = dateTimePicker1.Value,
                MaNV = comboBox3.SelectedValue?.ToString(),
                GhiChu = textBox2.Text
            };

            // Tạo danh sách chi tiết
            List<ChiTietPhieuNhapDTO> chiTietList = new List<ChiTietPhieuNhapDTO>();
            foreach (DataRow row in dtChiTiet.Rows)
            {
                chiTietList.Add(new ChiTietPhieuNhapDTO
                {
                    MaPN = maPNDangNhap,
                    MaSP = row["MaSP"].ToString(),
                    SoLuong = Convert.ToInt32(row["SoLuong"]),
                    GiaNhap = Convert.ToDecimal(row["GiaNhap"]),
                    HanSuDung = Convert.ToDateTime(row["HanSuDung"])
                });
            }

            // Gọi DAL lưu
            bool kq = dal.LuuPhieuNhap(pn, chiTietList);
            if (kq)
            {
                MessageBox.Show("Lưu phiếu nhập thành công!");
                // Reset form
                dtChiTiet.Clear();
                maPNDangNhap = dal.TaoMaPhieuNhap();
                textBox1.Text = maPNDangNhap;
                textBox2.Clear();
                comboBox3.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Lỗi khi lưu phiếu nhập, vui lòng thử lại!");
            }
        }

        // Nút Hủy phiếu: xóa dữ liệu tạm và tạo mã mới
        private void button15_Click(object sender, EventArgs e)
        {
            dtChiTiet.Clear();
            maPNDangNhap = dal.TaoMaPhieuNhap();
            textBox1.Text = maPNDangNhap;
            textBox2.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        // Các sự kiện rỗng khác giữ nguyên (hoặc có thể bỏ)
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void button14_Click(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
    }
}