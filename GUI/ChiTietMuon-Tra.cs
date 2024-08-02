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
    public partial class ChiTietMuon_Tra : UserControl
    {
        //DataTable dta = new DataTable();
        //ChitietBLL service;
        //PhieumuonBLL services;
        //SachBLL servicess;
        //public string idWhenClick;
        public ChiTietMuon_Tra()
        {
            InitializeComponent();
            //service = new ChitietBLL();
            //services = new PhieumuonBLL();
            //servicess = new SachBLL();
            //a();
            //b();
            //rdochuatra.Checked = true;
        }
        //public void loadgrid()
        //{
        //    //dtgView.ColumnCount = 10;
        //    //dtgView.Columns[0].Name = "STT";
        //    //dtgView.Columns[1].Name = "Mã quản lý";
        //    //dtgView.Columns[2].Name = "Mã sách";
        //    //dtgView.Columns[3].Name = "Mã phiếu mượn";
        //    //dtgView.Columns[4].Name = "Ngày mượn";
        //    //dtgView.Columns[5].Name = "Ngày trả";
        //    //dtgView.Columns[6].Name = "Trạng thái sách";
        //    //dtgView.Columns[7].Name = "Số lượng";
        //    //dtgView.Columns[8].Name = "Tổng tiền";
        //    //dtgView.Columns[9].Name = "Ghi chú";
        //    //dtgView.Rows.Clear();
        //    //int stt = 1;
        //    //foreach (var ct in service.GetChiTietPhieuMuons())
        //    //{
        //    //    dtgView.Rows.Add(stt++, ct.MaChiTiet,
        //    //                            ct.MaSach,
        //    //                            ct.MaPhieuMuon,
        //    //                            ct.NgayMuon,
        //    //                            ct.NgayTra,
        //    //                            (bool)ct.TrangThai ? "Đã trả" : "Chưa trả",
        //    //                            ct.SoLuong,
        //    //                            ct.TongTien,
        //    //                            ct.GhiChu);
        //}
        //public void hienThiPhieuQuaHan()
        //{
        //    DateOnly now = DateOnly.FromDateTime(DateTime.Now);
        //    var listPhieuQuaHan = service.GetChiTietPhieuMuons().Where(x => x.NgayTra < now && x.TrangThai == false).ToList();


        //    lblquahan.Text = listPhieuQuaHan.Count.ToString();

        //    dtgView11.Rows.Clear();
        //    dtgView11.ColumnCount = 10;
        //    dtgView11.Columns[0].Name = "STT";
        //    dtgView11.Columns[1].Name = "Mã quản lý";
        //    dtgView11.Columns[2].Name = "Mã sách";
        //    dtgView11.Columns[3].Name = "Mã phiếu mượn";
        //    dtgView11.Columns[4].Name = "Ngày mượn";
        //    dtgView11.Columns[5].Name = "Ngày trả";
        //    dtgView11.Columns[6].Name = "Trạng thái sách";
        //    dtgView11.Columns[7].Name = "Số lượng";
        //    dtgView11.Columns[8].Name = "Tổng tiền";
        //    dtgView11.Columns[9].Name = "Ghi chú";

        //    int stt = 1;
        //    foreach (var ct in listPhieuQuaHan)
        //    {
        //        dtgView11.Rows.Add(stt++, ct.MaChiTiet,
        //                                 ct.MaSach,
        //                                 ct.MaPhieuMuon,
        //                                 ct.NgayMuon,
        //                                 ct.NgayTra,
        //                                 (bool)ct.TrangThai ? "Đã trả" : "Chưa trả",
        //                                 ct.SoLuong,
        //                                 ct.TongTien,
        //                                 ct.GhiChu);
        //    }
        //}
        private void btnsua_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    ChiTietPhieuMuon ct = service.GetChiTietPhieuMuons().Find(x => x.MaChiTiet == idWhenClick);
            //    ct.NgayMuon = DateOnly.Parse(dateNgaymuon.Value.ToShortDateString());
            //    ct.NgayTra = DateOnly.Parse(datengaytra.Value.ToShortDateString());
            //    ct.TrangThai = rdodatra.Checked == true || rdochuatra.Checked == false;

            //    ct.TongTien = float.Parse(labtongtien.Text);
            //    ct.GhiChu = txtghichu.Text;
            //    MessageBox.Show(service.SuaCT(ct));
            //    loadgrid();
            //}
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            // loadgrid();
        }


        //public void a()
        //{
        //    //cbbmaphieumuon.Items.Clear();
        //    //foreach (var pm in services.GetPhieuMuons())
        //    //{
        //    //    cbbmaphieumuon.Items.Add(pm.MaPhieuMuon);
        //    //}
        //    //if (cbbmaphieumuon.Items.Count > 0)
        //    //{
        //    //    cbbmaphieumuon.SelectedIndex = 0;
        //    //}
        //}
        //public void b()
        //{
        //    //cbbmasach.Items.Clear();
        //    //foreach (var pm in servicess.GetSaches())
        //    //{
        //    //    cbbmasach.Items.Add(pm.MaSach);
        //    //}
        //    //if (cbbmasach.Items.Count > 0)
        //    //{
        //    //    cbbmasach.SelectedIndex = 0;
        //    //}
        //}
        //public void sophieu()
        //{
        //    var sophieulist = service.GetChiTietPhieuMuons();
        //    int datra = sophieulist.Count(pm => pm.TrangThai == true);
        //    int chuatra = sophieulist.Count(pm => pm.TrangThai == false);
        //    labtongmuon.Text = datra.ToString();
        //    labtongtra.Text = chuatra.ToString();
        //}
        //public void load()
        //{
        //    var ct = service.GetChiTietPhieuMuons().Find(x => x.MaChiTiet == idWhenClick);


        //    cbbmaphieumuon.Text = ct.MaPhieuMuon;
        //    dateNgaymuon.Text = ct.NgayMuon.ToString();
        //    datengaytra.Text = ct.NgayTra.ToString();
        //    if (ct.TrangThai == true)
        //    {
        //        rdodatra.Checked = true;
        //    }
        //    else
        //    {
        //        rdochuatra.Checked = true;
        //    }

        //    labtongtien.Text = ct.TongTien.ToString();
        //    txtghichu.Text = ct.GhiChu;
        //}


        

    }
}
