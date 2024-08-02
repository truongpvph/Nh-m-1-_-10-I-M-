using BLL;
using DAL;
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
    public partial class LapPhieuMuon : UserControl
    {

        LapPhieuMuonChiTietBLL db = new LapPhieuMuonChiTietBLL();
        DataTable dtPhieuMuon = new DataTable();
        DataTable dtChiTiet = new DataTable();
        DataTable dtSach = new DataTable();
        string maSach;
        string maChiTiet;
        string maPhieuMuon;
        double tongTien;
        int soLuong;
        int remove;
        double tongtien;

        public LapPhieuMuon()
        {
            InitializeComponent();
        }

        private void labtongtien_Click(object sender, EventArgs e)
        {

        }

        public void LoadValuePhieuMuon()
        {
            foreach (var i in db.GetAllPhieuMuon().ToList().OrderBy(a => a.MaPhieuMuon.Length))
            {
                DataRow row = dtPhieuMuon.NewRow();
                row["Mã phiếu mượn"] = i.MaPhieuMuon;
                row["Tên độc giả"] = db.GetDocGiaById(i.MaDocGia).TenDocGia;
                row["Tên người tạo"] = db.GetTaiKhoanById(i.MaTaiKhoan).HoTen;
                dtPhieuMuon.Rows.Add(row);
            }
        }

        public void LoadValuesSach()
        {
            foreach (var i in db.GetAllSach().ToList().OrderBy(s => s.MaSach.Length))
            {
                DataRow dr = dtSach.NewRow();
                dr["Mã sách"] = i.MaSach;
                dr["Tên sách"] = i.TenSach;
                dr["Số lượng"] = i.SoLuong;
                dtSach.Rows.Add(dr);
            }
        }

        private void LapPhieuMuon_Load(object sender, EventArgs e)
        {
            dtPhieuMuon.Columns.Add("Mã phiếu mượn", typeof(string));
            dtPhieuMuon.Columns.Add("Tên độc giả", typeof(string));
            dtPhieuMuon.Columns.Add("Tên Người tạo", typeof(string));
            LoadValuePhieuMuon();
            dgvPhieuMuon.DataSource = dtPhieuMuon;


            dtSach.Columns.Add("Mã sách", typeof(string));
            dtSach.Columns.Add("Tên sách", typeof(string));
            dtSach.Columns.Add("Số lượng", typeof(int));
            LoadValuesSach();
            dgvSach.DataSource = dtSach;


            dtChiTiet.Columns.Add("Mã phiếu mượn", typeof(string));
            dtChiTiet.Columns.Add("Tên sách", typeof(string));
            dtChiTiet.Columns.Add("Số lượng", typeof(int));
            dtChiTiet.Columns.Add("Tổng tiền", typeof(int));




            foreach (var i in db.GetAllTaiKhoan().ToList())
            {
                cbbmataikhoan.Items.Add(i.HoTen);
            }

            cbbPhieuMuon.Text = null;
            cbbPhieuMuon.Items.Clear();
            var mapm = db.GetAllPhieuMuon().ToList()
                .Join(db.GetAllChiTietPhieuMuon().ToList(), pm => pm.MaPhieuMuon, ct => ct.MaPhieuMuon, (pm, ct) => new
                {
                    pm.MaTaiKhoan,
                    pm.MaDocGia,
                    pm.MaPhieuMuon,
                    ct.MaChiTiet,
                    ct.MaSach,
                    ct.SoLuong,
                    chitiet = ct.MaPhieuMuon
                }).Where(i => i.chitiet.ToLower().ToString() == i.MaPhieuMuon.ToLower().ToString());

            foreach (var i in db.GetAllPhieuMuon().ToList())
            {
                cbbPhieuMuon.Items.Add(i.MaPhieuMuon);

                foreach (var y in mapm)
                {
                    if (y.chitiet.ToLower().ToString().Contains(y.MaPhieuMuon.ToLower().ToString()))
                    {

                        cbbPhieuMuon.Items.Remove(y.MaPhieuMuon);
                    }

                }
            }


        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            foreach (var i in db.GetAllDocGium().ToList())
            {
                if (i.Sdt.Equals(txtSDT.Text.ToString()))
                {
                    txtMaDocGia.Text = i.TenDocGia;
                }
            }
        }

        private void txtTimKiemSach_TextChanged(object sender, EventArgs e)
        {
            dtSach.Rows.Clear();
            var search = Convert.ToString(txtTimKiemSach.Text);
            var list = db.GetAllSach().ToList()
                .Where(s => s.TenSach.ToLower().ToString().Contains(search.ToLower().ToString()));
            foreach (var i in list.OrderBy(p => p.MaSach.Length))
            {
                DataRow row = dtSach.NewRow();
                row["Mã Sách"] = i.MaSach;

                row["Tên Sách"] = i.TenSach;

                row["Số Lượng"] = i.SoLuong;

                dtSach.Rows.Add(row);

            }
        }

        private void dgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormSoLuong form = new FormSoLuong();
            form.ShowDialog();
            DataGridViewRow dr = dgvSach.Rows[e.RowIndex];
            maSach = dr.Cells[0].Value.ToString();
            if (cbbPhieuMuon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn!!!!");
            }
            else if (form.soLuongMuon < 1)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0 !!!");
            }
            else if (form.soLuongMuon > db.GetSachByID(maSach).SoLuong)
            {
                MessageBox.Show("Sách bạn muốn tìm hiện tại không đủ số lượng bạn cần ");
            }
            else
            {
                DataRow row = dtChiTiet.NewRow();

                row["Mã phiếu mượn"] = cbbPhieuMuon.Text.ToString();
                row["Tên sách"] = db.GetSachByID(maSach).TenSach;
                row["Số lượng"] = form.soLuongMuon;
                row["Tổng tiền"] = Convert.ToInt32(form.soLuongMuon) * 2000;
                tongtien += Convert.ToInt32(form.soLuongMuon) * 2000;
                textBox1.Text = tongtien.ToString();
                dtChiTiet.Rows.Add(row);
                dgvPhieuChitiet.DataSource = dtChiTiet;
                db.UpdateSach(maSach, form.soLuongMuon);
                dtSach.Rows.Clear();
                LoadValuesSach();


            }








        }

        private void btnTaoPhieuMuon_Click(object sender, EventArgs e)
        {
            if (cbbmataikhoan.SelectedItem == null || txtSDT.Text == "")
            {
                MessageBox.Show("Nhập Thiếu dữ liệu");

            }
            else
            {
                var maPhieuMuon = "PM" + (Convert.ToInt32(db.GetAllPhieuMuon().Count(p => p.MaPhieuMuon != null)) + 1).ToString();
                var maDocGia = db.GetDocGiumByName(txtMaDocGia.Text).MaDocGia.ToString();
                var maTaiKhoan = db.GetTaiKhoanByName(cbbmataikhoan.Text).MaTaiKhoan.ToString();
                db.ADDPhieuMuon(maPhieuMuon, maDocGia, maTaiKhoan);

                dtPhieuMuon.Rows.Clear();
                LoadValuePhieuMuon();
            }

            cbbPhieuMuon.Text = null;
            cbbPhieuMuon.Items.Clear();
            var mapm = db.GetAllPhieuMuon().ToList()
                .Join(db.GetAllChiTietPhieuMuon().ToList(), pm => pm.MaPhieuMuon, ct => ct.MaPhieuMuon, (pm, ct) => new
                {
                    pm.MaTaiKhoan,
                    pm.MaDocGia,
                    pm.MaPhieuMuon,
                    ct.MaChiTiet,
                    ct.MaSach,
                    ct.SoLuong,
                    chitiet = ct.MaPhieuMuon
                }).Where(i => i.chitiet.ToLower().ToString() == i.MaPhieuMuon.ToLower().ToString());

            foreach (var i in db.GetAllPhieuMuon().ToList())
            {
                cbbPhieuMuon.Items.Add(i.MaPhieuMuon);

                foreach (var y in mapm)
                {
                    if (y.chitiet.ToLower().ToString().Contains(y.MaPhieuMuon.ToLower().ToString()))
                    {

                        cbbPhieuMuon.Items.Remove(y.MaPhieuMuon);
                    }

                }
            }

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dateNgaymuon.Text == datengaytra.Text)
            {
                MessageBox.Show("Lỗi ngày mượn ngày trả !!!");
            }
            else
            {
                var maChiTiet = "CT" + (Convert.ToInt32(db.GetAllChiTietPhieuMuon().Count(ct => ct.MaChiTiet != null)) + 1).ToString();
                var ngayMuon = DateOnly.Parse(dateNgaymuon.Value.ToShortDateString());
                var ngayTra = DateOnly.Parse(datengaytra.Value.ToShortDateString());
                var trangThai = false;
                var moTa = txtghichu.Text;

                db.AddChiTiet(maChiTiet, maPhieuMuon, maSach, soLuong, tongTien, ngayMuon, ngayTra, moTa, trangThai);

                dtSach.Rows.Clear();
                LoadValuesSach();


                dtChiTiet.Rows.RemoveAt(remove);
                cbbPhieuMuon.Text = null;
                cbbPhieuMuon.Items.Clear();
                var mapm = db.GetAllPhieuMuon().ToList()
                   .Join(db.GetAllChiTietPhieuMuon().ToList(), pm => pm.MaPhieuMuon, ct => ct.MaPhieuMuon, (pm, ct) => new
                   {
                       pm.MaTaiKhoan,
                       pm.MaDocGia,
                       pm.MaPhieuMuon,
                       ct.MaChiTiet,
                       ct.MaSach,
                       ct.SoLuong,
                       chitiet = ct.MaPhieuMuon
                   }).Where(i => i.chitiet.ToLower().ToString() == i.MaPhieuMuon.ToLower().ToString());
                foreach (var i in db.GetAllPhieuMuon().ToList())
                {
                    cbbPhieuMuon.Items.Add(i.MaPhieuMuon);

                    foreach (var y in mapm)
                    {
                        if (y.chitiet.ToLower().ToString().Contains(y.MaPhieuMuon.ToLower().ToString()))
                        {

                            cbbPhieuMuon.Items.Remove(y.MaPhieuMuon);
                        }

                    }
                }

            }

        }

        private void dgvPhieuChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            remove = e.RowIndex;
            DataGridViewRow dr = dgvPhieuChitiet.Rows[e.RowIndex];
            maSach = db.GetSachByName(dr.Cells[1].Value.ToString()).MaSach;
            maPhieuMuon = dr.Cells[0].Value.ToString();
            soLuong = Convert.ToInt32(dr.Cells[2].Value);
            tongTien = Convert.ToDouble(dr.Cells[3].Value);





        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var maPhieuMuon = txtMaPhieuMuon.Text;
            var maDocGia = db.GetDocGiumByName(txtMaDocGia.Text).MaDocGia.ToString();
            var maTaiKhoan = db.GetTaiKhoanByName(cbbmataikhoan.Text).MaTaiKhoan.ToString();
            db.UpdatePhieuMuon(maPhieuMuon, maDocGia, maTaiKhoan);
            dtPhieuMuon.Rows.Clear();
            LoadValuePhieuMuon();
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvPhieuMuon.Rows[e.RowIndex];
            txtMaPhieuMuon.Text = dr.Cells[0].Value.ToString();
            cbbmataikhoan.Text = dr.Cells[2].Value.ToString();
            txtMaDocGia.Text = dr.Cells[1].Value.ToString();
            txtSDT.Text = db.GetDocGiumByName(dr.Cells[1].Value.ToString()).Sdt.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtMaPhieuMuon.Text = "";
            cbbmataikhoan.SelectedItem = null;
            txtSDT.Text = "";
            txtMaDocGia.Text = "";
        }
    }
}
