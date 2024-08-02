using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LapPhieuMuonChiTietDAL
    {
        QuanLyDuAnNhom1Sd19315Context db = new QuanLyDuAnNhom1Sd19315Context();
        public List<PhieuMuon> GetAllPhieuMuon()
        {
            var list = db.PhieuMuons.ToList();
            return list;
        }
        public List<Sach> GetAllSach()
        {
            var list = db.Saches.ToList();
            return list;
        }
        public List<DocGium> GetAllDocGium()
        {
            var list = db.DocGia.ToList();
            return list;
        }
        public List<ChiTietPhieuMuon> GetAllChiTietPhieuMuon()
        {
            var list = db.ChiTietPhieuMuons.ToList();
            return list;
        }
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            var list = db.TaiKhoans.ToList();
            return list;
        }
        public void AddPhieuMuon(PhieuMuon phieumuon)
        {
            db.PhieuMuons.Add(phieumuon);
            db.SaveChanges();
        }
        public void AddPhieuChiTiet(ChiTietPhieuMuon chiTiet, Sach s)
        {
            db.Saches.Update(s);
            db.ChiTietPhieuMuons.Add(chiTiet);
            db.SaveChanges();
        }
        public void UpdatePhieuMuon(PhieuMuon phieu)
        {
            db.PhieuMuons.Update(phieu);
            db.SaveChanges();
        }
        public void UpdateSach(Sach sach)
        {
            db.Saches.Update(sach);
            db.SaveChanges();
        }


    }
}
