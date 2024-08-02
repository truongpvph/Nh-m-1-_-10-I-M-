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
    public partial class QuanLyTheLoai : UserControl
    {
        TheLoaiSevice sevice = new TheLoaiSevice();
        public QuanLyTheLoai()
        {
            sevice = new TheLoaiSevice();
            InitializeComponent();
        }
        public void ShowData(List<TheLoai> tl)
        {
            dtg_quanlytl.Rows.Clear();
            dtg_quanlytl.ColumnCount = 3;
            int stt = 1;
            dtg_quanlytl.Columns[0].HeaderText = "Số thứ tự";
            dtg_quanlytl.Columns[1].HeaderText = "Mã thể loại";
            dtg_quanlytl.Columns[2].HeaderText = "Tên thể loại";
            foreach (var item in tl)
            {
                dtg_quanlytl.Rows.Add(stt++, item.MaTheLoai, item.TenTheLoai);
            }
        }
        public void loadTKiem(string search = "")
        {
            dtg_quanlytl.ColumnCount = 3;
            dtg_quanlytl.Columns[0].HeaderText = "Số thứ tự";
            dtg_quanlytl.Columns[1].HeaderText = "Mã thể loại";
            dtg_quanlytl.Columns[2].HeaderText = "Tên thể loại";
            dtg_quanlytl.Rows.Clear();
            int stt = 1;
            var tl = sevice.CNShow();
            if (!string.IsNullOrEmpty(search))
            {
                tl = tl.Where(x =>
                x.MaTheLoai.ToLower().Contains(search.ToLower()) ||
                x.TenTheLoai.ToLower().Contains(search.ToLower())).ToList();
            }
            foreach (var item in tl)
            {
                dtg_quanlytl.Rows.Add(stt++, item.MaTheLoai, item.TenTheLoai);
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            List<TheLoai> theLoais = sevice.CNShow();
            ShowData(theLoais);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TheLoai tl = new TheLoai();
                tl.MaTheLoai = "TL" + (sevice.CNShow().Count + 1);
                tl.TenTheLoai = txt_tentheloai.Text;
                MessageBox.Show(sevice.CNThem(tl));
                loadTKiem();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ten = txt_tentheloai.Text;
            string ma = txt_matheloai.Text;
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = sevice.CNSua(ma, ten);
                MessageBox.Show(kq);
                List<TheLoai> theLoais = sevice.CNShow();
                ShowData(theLoais);
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
            DataGridViewRow row = dtg_quanlytl.Rows[e.RowIndex];
            txt_matheloai.Text = row.Cells[1].Value.ToString();
            txt_tentheloai.Text = row.Cells[2].Value.ToString();
        }
    }
}
