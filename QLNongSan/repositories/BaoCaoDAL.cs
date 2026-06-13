using QLNongSan.schemas;
using System.Collections.Generic;
using System.Data;

namespace QLNongSan.repositories
{
    public class BaoCaoDAL
    {
        // In-memory list acting as the data store (replace with DB calls as needed)
        private static List<BaoCaoDTO> _dsBaoCao = new List<BaoCaoDTO>();
        private static int _nextId = 1;

        /// <summary>
        /// Lấy toàn bộ danh sách báo cáo dưới dạng DataTable để bind vào DataGridView.
        /// </summary>
        public DataTable GetAllBaoCao()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaBaoCao",   typeof(int));
            dt.Columns.Add("NgayBaoCao", typeof(string));
            dt.Columns.Add("LoaiBaoCao", typeof(string));
            dt.Columns.Add("NoiDung",    typeof(string));

            foreach (BaoCaoDTO bc in _dsBaoCao)
            {
                dt.Rows.Add(bc.MaBaoCao, bc.NgayBaoCao, bc.LoaiBaoCao, bc.NoiDung);
            }

            return dt;
        }

        /// <summary>
        /// Thêm một báo cáo mới.
        /// </summary>
        public bool ThemBaoCao(BaoCaoDTO baoCao)
        {
            if (baoCao == null) return false;
            if (string.IsNullOrWhiteSpace(baoCao.NoiDung)) return false;

            baoCao.MaBaoCao = _nextId++;
            _dsBaoCao.Add(baoCao);
            return true;
        }

        /// <summary>
        /// Xóa báo cáo theo mã.
        /// </summary>
        public bool XoaBaoCao(int maBaoCao)
        {
            BaoCaoDTO target = _dsBaoCao.Find(bc => bc.MaBaoCao == maBaoCao);
            if (target == null) return false;

            _dsBaoCao.Remove(target);
            return true;
        }

        /// <summary>
        /// Lấy báo cáo theo mã.
        /// </summary>
        public BaoCaoDTO GetBaoCaoById(int maBaoCao)
        {
            return _dsBaoCao.Find(bc => bc.MaBaoCao == maBaoCao);
        }
    }
}
