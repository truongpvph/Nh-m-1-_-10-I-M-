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
    public partial class QuanLyTacGia : UserControl
    {
        //TacgiaBLL service;
        //public string idWhenClick;
        public QuanLyTacGia()
        {
            InitializeComponent();
            //loadccb();
            //service = new TacgiaBLL();
        }
        //public void loadccb()
        //{
        //    cbbgioitinh.Items.Add("Nam");
        //    cbbgioitinh.Items.Add("Nữ");
        //    if (cbbgioitinh.Items.Count > 0)
        //    {
        //        cbbgioitinh.SelectedIndex = 0;
        //    }
        //}
        //public void loadgrid()
        //{
        //    dtgView.ColumnCount = 5;
        //    dtgView.Columns[0].Name = "STT";
        //    dtgView.Columns[1].Name = "Mã tác giả";
        //    dtgView.Columns[2].Name = "Tên tác giả";
        //    dtgView.Columns[3].Name = "Giới tính";
        //    dtgView.Columns[4].Name = "Quốc tịch";
        //    dtgView.Rows.Clear();
        //    int stt = 1;
        //    foreach (var tg in service.GetTacGia())
        //    {
        //        dtgView.Rows.Add(stt++, tg.MaTacGia, tg.TenTacGia, tg.GioiTinh, tg.QuocGia);
        //    }
        //}

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            //loadgrid();

        }
        //public void loadcellclick()
        //{
        //    var tg = service.GetTacGia().Find(x => x.MaTacGia == idWhenClick);

        //    txtHoTen.Text = tg.TenTacGia;
        //    cbbgioitinh.Text = tg.GioiTinh;
        //    txtquoctich.Text = tg.QuocGia;
        //}
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex;
            //if (rowIndex < 0)
            //{
            //    return;
            //}
            //idWhenClick = dtgView.Rows[rowIndex].Cells[1].Value.ToString();
            //loadcellclick();
        }




        //public void loadtk(string search = "")
        //{
        //    dtgView.ColumnCount = 5;
        //    dtgView.Columns[0].Name = "STT";
        //    dtgView.Columns[1].Name = "Mã tác giả";
        //    dtgView.Columns[2].Name = "Tên tác giả";
        //    dtgView.Columns[3].Name = "Giới tính";
        //    dtgView.Columns[4].Name = "Quốc tịch";
        //    dtgView.Rows.Clear();
        //    int stt = 1;
        //    var tg = service.GetTacGia();
        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        tg = tg.Where(x =>
        //        x.TenTacGia.Contains(search) ||
        //        x.GioiTinh.Contains(search) ||
        //        x.QuocGia.Contains(search)).ToList();
        //    }
        //    foreach (var tgg in tg)
        //    {
        //        dtgView.Rows.Add(stt++, tgg.MaTacGia, tgg.TenTacGia, tgg.GioiTinh, tgg.QuocGia);
        //    }
        //}




        private void btnclear_Click_1(object sender, EventArgs e)
        {
            //dtgView.Rows.Clear();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            //string searchvalue = txtTimKiem.Text;
            //loadtk(searchvalue);
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {

            //if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(cbbgioitinh.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(txtquoctich.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            //    return;
            //}
            //DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    TacGium tg = service.GetTacGia().Find(x => x.MaTacGia == idWhenClick);
            //    tg.TenTacGia = txtHoTen.Text;
            //    tg.GioiTinh = cbbgioitinh.SelectedItem.ToString();
            //    tg.QuocGia = txtquoctich.Text;
            //    MessageBox.Show(service.SuaTG(tg));
            //    loadgrid();
            //}
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(cbbgioitinh.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(txtquoctich.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            //    return;
            //}
            //DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    TacGium tg = new TacGium();
            //    tg.MaTacGia = "TG" + (service.GetTacGia().Count + 1);
            //    tg.TenTacGia = txtHoTen.Text;
            //    tg.GioiTinh = cbbgioitinh.SelectedItem.ToString();
            //    tg.QuocGia = txtquoctich.Text;
            //    MessageBox.Show(service.ThemTG(tg));
            //    loadgrid();
            //}
        }
    }
}
