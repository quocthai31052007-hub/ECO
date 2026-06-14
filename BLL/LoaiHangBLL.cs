using System;
using System.Data;
using QLNongSan.DAL;
using QLNongSan.DTO;

namespace QLNongSan.BLL
{
    public class LoaiHangBLL
    {
        private LoaiHangDAL dal = new LoaiHangDAL();

        public DataTable GetListLoaiHang()
        {
            return dal.GetAllLoaiHang();
        }

        public string AddLoaiHang(LoaiHangDTO lh)
        {
            // Kiểm tra tính hợp lệ dữ liệu (Business Logic)
            if (string.IsNullOrEmpty(lh.MaLoai) || string.IsNullOrEmpty(lh.TenLoai))
            {
                return "Mã loại hàng và Tên loại hàng không được bỏ trống!";
            }

            // Gọi xuống DAL thực thi
            bool isSuccess = dal.InsertLoaiHang(lh);
            if (isSuccess)
            {
                return "SUCCESS";
            }
            else
            {
                return "Thêm loại hàng thất bại! Kiểm tra lại xem có trùng mã không.";
            }
        }
    }
}