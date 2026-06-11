using System;
using System.Data;
using QLNongSan.DAL;
using QLNongSan.DTO;

namespace QLNongSan.BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL dal = new SanPhamDAL();

        // Gọi lớp DAL để lấy dữ liệu
        public DataTable GetListSanPham()
        {
            return dal.GetAllSanPham();
        }

        // Xử lý logic kiểm tra trước khi thêm
        public string AddSanPham(SanPhamDTO sp)
        {
            // Kiểm tra các điều kiện nghiệp vụ (Business Rules)
            if (string.IsNullOrEmpty(sp.MaSP) || string.IsNullOrEmpty(sp.TenSP))
            {
                return "Mã sản phẩm và Tên sản phẩm không được để trống!";
            }
            if (sp.SoLuongTon < 0)
            {
                return "Số lượng tồn không được là số âm!";
            }
            if (sp.GiaBan <= 0)
            {
                return "Giá bán phải lớn hơn 0!";
            }

            // Nếu mọi logic đều hợp lệ, gọi DAL để lưu xuống Database
            bool isSuccess = dal.InsertSanPham(sp);
            if (isSuccess)
            {
                return "SUCCESS";
            }
            else
            {
                return "Thêm thất bại! Thầy cô lưu ý có thể do trùng Mã sản phẩm.";
            }
        }
    }
}