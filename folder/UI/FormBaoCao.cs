using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;

namespace QLNongSan.UI
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ngay = NgayBC.Value.ToShortDateString(); 
            string loai = LoaiBC.Text;                       
            string noiDung = NoiDung.Text;                 

            if (string.IsNullOrWhiteSpace(noiDung))
            {
                MessageBox.Show("Vui lòng nhập nội dung báo cáo!");
                return;
            }


            dataGridView1.Rows.Add(ngay, loai, noiDung);

            NoiDung.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa báo cáo này?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa trong bảng!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Không có nội dung nào để xuất PDF!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files (.pdf)|.pdf";
            sfd.FileName = "BaoCaoNongSan.pdf"; 

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 30f, 30f, 30f, 30f);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();
                    string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font contentFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                    iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("BÁO CÁO NÔNG SẢN\n\n", titleFont);
                    title.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Căn giữa
                    pdfDoc.Add(title);

                    iTextSharp.text.Paragraph content = new iTextSharp.text.Paragraph(txtNoiDung.Text, contentFont);
                    content.Alignment = iTextSharp.text.Element.ALIGN_LEFT; // Căn trái
                    pdfDoc.Add(content);

 
                    pdfDoc.Close();
                    MessageBox.Show("Xuất file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        DataTable dtBaoCao = new DataTable();

        private void Form_Load(object sender, EventArgs e)
        {

            dtBaoCao.Columns.Add("NgayBaoCao", typeof(string));
            dtBaoCao.Columns.Add("LoaiBaoCao", typeof(string));
            dtBaoCao.Columns.Add("NoiDung", typeof(string));


            dataGridView1.DataSource = dtBaoCao;


            dataGridView1.Columns["NgayBaoCao"].HeaderText = "Ngày";
            dataGridView1.Columns["LoaiBaoCao"].HeaderText = "Loại báo cáo";
            dataGridView1.Columns["NoiDung"].HeaderText = "Nội dung";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

           
                if (row.Cells["colNoiDung"].Value != null)
                {
                    txtNoiDung.Text = row.Cells["colNoiDung"].Value.ToString();
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoaiBC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}