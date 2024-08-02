using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLyDocGia : UserControl
    {
        DocGiaSevice sevice = new DocGiaSevice();
        public QuanLyDocGia()
        {
            sevice = new DocGiaSevice();
            InitializeComponent();
        }
        public void ShowData(List<DocGium> dg)
        {
            dtg_quanlydg.Rows.Clear();
            dtg_quanlydg.ColumnCount = 4;
            int stt = 1;
            dtg_quanlydg.Columns[0].HeaderText = "Số thứ tự";
            dtg_quanlydg.Columns[1].HeaderText = "Mã độc giả";
            dtg_quanlydg.Columns[2].HeaderText = "Họ và tên";
            dtg_quanlydg.Columns[3].HeaderText = "Số điện thoại";
            foreach (var item in dg)
            {
                dtg_quanlydg.Rows.Add(stt++, item.MaDocGia, item.TenDocGia, item.Sdt);
            }
        }
        public void loadTKiem(string search = "")
        {
            dtg_quanlydg.ColumnCount = 4;
            dtg_quanlydg.Columns[0].HeaderText = "Số thứ tự";
            dtg_quanlydg.Columns[1].HeaderText = "Mã độc giả";
            dtg_quanlydg.Columns[2].HeaderText = "Họ và tên";
            dtg_quanlydg.Columns[3].HeaderText = "Số điện thoại";
            dtg_quanlydg.Rows.Clear();
            int stt = 1;
            var dg = sevice.CNShow();
            if (!string.IsNullOrEmpty(search))
            {
                dg = dg.Where(x =>
                x.MaDocGia.ToLower().Contains(search.ToLower()) ||
                x.TenDocGia.ToLower().Contains(search.ToLower())).ToList();
            }
            foreach (var item in dg)
            {
                dtg_quanlydg.Rows.Add(stt++, item.MaDocGia, item.TenDocGia, item.Sdt);
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            List<DocGium> docGia = sevice.CNShow();
            ShowData(docGia);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sdt = txt_SoDienThoai.Text;
            if (sevice.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại sai");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DocGium dg = new DocGium();
                dg.MaDocGia = "D" + (sevice.CNShow().Count + 1);
                dg.TenDocGia = txt_madocgia.Text;
                dg.Sdt = txt_SoDienThoai.Text;
                MessageBox.Show(sevice.CNThem(dg));
                loadTKiem();
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txt_HoTen.Text;
            string ten = txt_madocgia.Text;
            string sdt = txt_SoDienThoai.Text;
            if (sevice.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại sai");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = sevice.CNSua(ma, ten, sdt);
                MessageBox.Show(kq);
                List<DocGium> docGia = sevice.CNShow();
                ShowData(docGia);
                return;
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchvalue = txt_TimKiem.Text;
            loadTKiem(searchvalue);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_quanlydg.Rows[e.RowIndex];
            txt_HoTen.Text = row.Cells[1].Value.ToString();
            txt_madocgia.Text = row.Cells[2].Value.ToString();
            txt_SoDienThoai.Text = row.Cells[3].Value.ToString();
        }
    }
}
