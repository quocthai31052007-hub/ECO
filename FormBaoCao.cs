using iTextSharp.text.pdf;
using QLNongSan.repositories;
using QLNongSan.schemas;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QLNongSan.UI
{
    public partial class FormBaoCao : Form
    {
        // ── DAL instance ────────────────────────────────────────────────────────
        private readonly BaoCaoDAL _baoCaoDAL = new BaoCaoDAL();

        public FormBaoCao()
        {
            InitializeComponent();
            LoadData();
        }

        // ── Helpers ─────────────────────────────────────────────────────────────

        /// <summary>
        /// Reload DataGridView from DAL.
        /// </summary>
        private void LoadData()
        {
            dataGridView1.DataSource = _baoCaoDAL.GetAllBaoCao();

            // Map column headers (DataTable columns may differ from designer columns)
            if (dataGridView1.Columns["NgayBaoCao"] != null)
                dataGridView1.Columns["NgayBaoCao"].HeaderText = "Ngày Báo Cáo";
            if (dataGridView1.Columns["LoaiBaoCao"] != null)
                dataGridView1.Columns["LoaiBaoCao"].HeaderText = "Loại Báo Cáo";
            if (dataGridView1.Columns["NoiDung"] != null)
                dataGridView1.Columns["NoiDung"].Visible = false;   // hidden; shown in txtNoiDung
            if (dataGridView1.Columns["MaBaoCao"] != null)
                dataGridView1.Columns["MaBaoCao"].Visible = false;  // internal key, hide from user
        }

        // ── Button: Lưu (Save) ──────────────────────────────────────────────────
        private void button1_Click(object sender, EventArgs e)
        {
            string ngay    = NgayBC.Value.ToShortDateString();
            string loai    = LoaiBC.Text;
            string noiDung = NoiDung.Text;

            if (string.IsNullOrWhiteSpace(noiDung))
            {
                MessageBox.Show("Vui lòng nhập nội dung báo cáo!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaoCaoDTO baoCao = new BaoCaoDTO(0, ngay, loai, noiDung);

            if (_baoCaoDAL.ThemBaoCao(baoCao))
            {
                LoadData();
                NoiDung.Clear();
                MessageBox.Show("Đã lưu báo cáo thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu báo cáo thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Button: Xóa (Delete) ────────────────────────────────────────────────
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa trong bảng!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa báo cáo này?",
                                              "Xác nhận", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            // Read the hidden MaBaoCao from the bound DataTable row
            DataRowView drv = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;

            int maBaoCao = Convert.ToInt32(drv["MaBaoCao"]);

            if (_baoCaoDAL.XoaBaoCao(maBaoCao))
            {
                LoadData();
                txtNoiDung.Clear();
                MessageBox.Show("Đã xóa thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy báo cáo để xóa!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Button: Xuất PDF ────────────────────────────────────────────────────
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Không có nội dung nào để xuất PDF!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter   = "PDF Files (*.pdf)|*.pdf",
                FileName = "BaoCaoNongSan.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(
                    iTextSharp.text.PageSize.A4, 30f, 30f, 30f, 30f);

                PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                pdfDoc.Open();

                string fontPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                iTextSharp.text.Font titleFont   = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font contentFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("BÁO CÁO NÔNG SẢN\n\n", titleFont)
                {
                    Alignment = iTextSharp.text.Element.ALIGN_CENTER
                };
                pdfDoc.Add(title);

                iTextSharp.text.Paragraph content = new iTextSharp.text.Paragraph(txtNoiDung.Text, contentFont)
                {
                    Alignment = iTextSharp.text.Element.ALIGN_LEFT
                };
                pdfDoc.Add(content);

                pdfDoc.Close();
                MessageBox.Show("Xuất file PDF thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xuất PDF: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── DataGridView: CellClick ─────────────────────────────────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView drv = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv == null) return;

            txtNoiDung.Text = drv["NoiDung"]?.ToString() ?? string.Empty;
        }

        // ── Unused stubs kept to match Designer event wiring ───────────────────
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void LoaiBC_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
