using QLNongSan.Repositories;
using QLNongSan.schemas;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNongSan.UI
{
    public partial class FormBanHang : Form
    {
        private readonly Application application;

        // DataTable tạm lưu chi tiết phiếu bán hiện tại
        private DataTable dtChiTiet = new DataTable();

        public FormBanHang(Application application)
        {
            this.application = application;
            InitializeComponent();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            KhoiTaoChiTiet();
            LoadComboBoxes();
            TaoMaPBMoi();
        }

        // Khởi tạo cột cho bảng chi tiết tạm
        private void KhoiTaoChiTiet()
        {
            dtChiTiet.Columns.Add("MaSP");
            dtChiTiet.Columns.Add("TenSP");
            dtChiTiet.Columns.Add("DVT");
            dtChiTiet.Columns.Add("GiaBan", typeof(decimal));
            dtChiTiet.Columns.Add("SoLuong", typeof(int));
            dtChiTiet.Columns.Add("ChietKhau", typeof(decimal));
            dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));
            dataGridView1.DataSource = dtChiTiet;
        }

        // Đổ dữ liệu vào các ComboBox
        private void LoadComboBoxes()
        {
            try
            {
                // Khách hàng
                DataTable dtKH = application.salesRepository.GetDanhSachKhachHang();
                comboBox1.DataSource = dtKH;
                comboBox1.DisplayMember = "TenKH";
                comboBox1.ValueMember = "MaKH";

                // Nhân viên bán
                DataTable dtNV = application.salesRepository.GetDanhSachNhanVien();
                comboBox2.DataSource = dtNV;
                comboBox2.DisplayMember = "TenNV";
                comboBox2.ValueMember = "MaNV";

                // Phương thức thanh toán
                comboBox3.Items.AddRange(new string[] { "Tiền mặt", "Chuyển khoản", "Thẻ tín dụng" });
                comboBox3.SelectedIndex = 0;

                // Sản phẩm
                DataTable dtSP = application.salesRepository.GetDanhSachSanPham();
                comboBox4.DataSource = dtSP;
                comboBox4.DisplayMember = "TenSP";
                comboBox4.ValueMember = "MaSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Tự tạo mã phiếu bán mới theo ngày
        private void TaoMaPBMoi()
        {
            textBox2.Text = "PB" + DateTime.Now.ToString("yyyyMMddHHmm");
        }

        // Khi chọn sản phẩm → tự điền giá bán, DVT
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue == null) return;
            string tenSP = comboBox4.Text;
            DataRow row = application.salesRepository.GetSanPhamByTen(tenSP);
            if (row != null)
            {
                textBox3.Text = row["GiaBan"].ToString();   // Giá bán
                comboBox5.Text = row["DVT"].ToString();     // Đơn vị tính
            }
        }

        // Tính thành tiền = giá bán * số lượng * (1 - chiết khấu/100)
        private decimal TinhThanhTien()
        {
            decimal giaBan = decimal.TryParse(textBox3.Text, out decimal g) ? g : 0;
            int soLuong = int.TryParse(textBox5.Text, out int sl) ? sl : 0;
            decimal chietKhau = decimal.TryParse(textBox4.Text, out decimal ck) ? ck : 0;
            return giaBan * soLuong * (1 - chietKhau / 100);
        }

        // Cập nhật tổng thanh toán
        private void CapNhatTong()
        {
            decimal tong = 0;
            foreach (DataRow row in dtChiTiet.Rows)
                tong += Convert.ToDecimal(row["ThanhTien"]);
            textBox6.Text = tong.ToString("N0") + " VNĐ";
        }

        // Nút Thêm sản phẩm vào chi tiết (button7)
        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo");
                return;
            }
            if (!int.TryParse(textBox5.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo");
                return;
            }

            decimal thanhTien = TinhThanhTien();
            DataTable dtSP = (DataTable)comboBox4.DataSource;
            DataRow spRow = dtSP.Rows[comboBox4.SelectedIndex];

            dtChiTiet.Rows.Add(
                spRow["MaSP"].ToString(),
                comboBox4.Text,
                comboBox5.Text,
                decimal.TryParse(textBox3.Text, out decimal g) ? g : 0,
                soLuong,
                decimal.TryParse(textBox4.Text, out decimal ck) ? ck : 0,
                thanhTien
            );

            CapNhatTong();
            LamMoiChiTiet();
        }

        // Nút Xóa dòng chi tiết (button8)
        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            dtChiTiet.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            CapNhatTong();
        }

        // Nút Sửa dòng chi tiết - điền lại lên form (button9)
        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int idx = dataGridView1.CurrentRow.Index;
            DataRow row = dtChiTiet.Rows[idx];
            comboBox4.Text = row["TenSP"].ToString();
            comboBox5.Text = row["DVT"].ToString();
            textBox3.Text = row["GiaBan"].ToString();
            textBox5.Text = row["SoLuong"].ToString();
            textBox4.Text = row["ChietKhau"].ToString();
            dtChiTiet.Rows.RemoveAt(idx);
            CapNhatTong();
        }

        // Nút Làm mới chi tiết (button10)
        private void button10_Click(object sender, EventArgs e)
        {
            LamMoiChiTiet();
        }

        private void LamMoiChiTiet()
        {
            comboBox4.SelectedIndex = 0;
            comboBox5.Text = "";
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // Nút THANH TOÁN & IN HÓA ĐƠN (button11)
        private void button11_Click(object sender, EventArgs e)
        {
            string ketQua = LuuPhieu();
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Thanh toán thành công!\nĐang in hóa đơn...", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HuyPhieu();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút LƯU PHIẾU BÁN (button13)
        private void button13_Click(object sender, EventArgs e)
        {
            string ketQua = LuuPhieu();
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Lưu phiếu bán thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HuyPhieu();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút HỦY PHIẾU (button12)
        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy phiếu?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HuyPhieu();
            }
        }

        // Lưu phiếu vào DB
        private string LuuPhieu()
        {
            PhieuBanDTO phieu = new PhieuBanDTO
            {
                MaPB = textBox2.Text.Trim(),
                KhachHang = comboBox1.Text,
                NhanVienBan = comboBox2.Text,
                NgayBan = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                PhuongThucTT = comboBox3.Text,
                TongThanhToan = decimal.TryParse(
                    textBox6.Text.Replace(" VNĐ", "").Replace(",", ""), out decimal t) ? t : 0
            };
            return application.salesRepository.LuuPhieuBan(phieu, dtChiTiet);
        }

        // Hủy/reset toàn bộ form
        private void HuyPhieu()
        {
            dtChiTiet.Rows.Clear();
            textBox6.Text = "0 VNĐ";
            TaoMaPBMoi();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            LamMoiChiTiet();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e) { }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}